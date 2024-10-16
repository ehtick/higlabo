import { $ } from "./HtmlElementQuery.js";
import { Htmx } from "./Htmx.js";
export class DataRecordPopupPanel {
    panel = document.getElementById("data-record-popup-panel");
    currentPanel;
    targetPanel;
    htmx = new Htmx();
    initialize() {
        $("body").on("click", "[show-data-record-popup-panel]", this.panel_Click.bind(this));
        $("body").on("keydown", "[show-data-record-popup-panel]", this.panel_Keydown.bind(this));
        $("body").on("click", "[selection-mode='Template'] [add-template]", this.addTemplate_Click.bind(this));
        $("body").on("click", "#data-record-popup-panel [search-button]", this.searchButton_Click.bind(this));
        $("body").on("keydown", "#data-record-popup-panel [search-textbox]", this.searchTextbox_Keydown.bind(this));
        $("body").on("click", "#data-record-popup-panel [data-record-panel]", this.dataRecordPanel_Click.bind(this));
        $("body").on("keydown", "#data-record-popup-panel [data-record-panel]", this.dataRecordPanel_Keydown.bind(this));
        $("body").on("click", "[data-record-panel] [delete-record]", this.dataRecordIcon_Click.bind(this));
        $("body").on("keydown", "[data-record-panel] [delete-record]", this.dataRecordIcon_Keydown.bind(this));
        $("body").on("click", "#data-record-popup-panel [close-button]", this.closeButton_Click.bind(this));
        $("body").on("click", "[close-data-record-popup-panel]", this.closeButton_Click.bind(this));
        document.body.addEventListener('htmx:configRequest', (e) => {
            if (e.target == this.panel) {
                e.detail.path = this.panel.getAttribute("hx-post");
            }
        });
        document.body.addEventListener('htmx:afterSwap', (e) => {
            if (e.target == $(this.panel).find("[record-list-panel]").getFirstElement()) {
                this.setPanelPosition(this.currentPanel.getBoundingClientRect());
            }
        });
        $("body").click(this.body_Click.bind(this));
    }
    panel_Click(element, e) {
        if ($(e.target).hasAttribute("href") == true) {
            return;
        }
        if ($(e.target).hasAttribute("delete-record") == true) {
            return;
        }
        if (element.getAttribute("prevent-default") == "true") {
            e.preventDefault();
        }
        this.show(element);
        e.stopPropagation();
    }
    panel_Keydown(element, e) {
        if (e.key == "Enter") {
            if (element.getAttribute("prevent-default") == "true") {
                e.preventDefault();
            }
            this.show(element);
        }
    }
    show(element) {
        this.currentPanel = $(element).getAttribute("target-panel-type") == "input-record-list-panel"
            ? $(element.parentElement).getFirstElement()
            : $(element).getFirstElement();
        this.targetPanel = $(element).getAttribute("target-panel-type") == "input-record-list-panel"
            ? $(this.currentPanel).find("[record-list-panel]").getFirstElement()
            : this.currentPanel;
        $(this.panel).setAttribute("selection-mode", $(this.currentPanel).getAttribute("selection-mode"));
        $(this.panel).setAttribute("hx-post", $(this.currentPanel).getAttribute("hx-post"));
        $(this.panel).find("[search-textbox]").setValue("");
        if ($(this.panel).getAttribute("search-default-list") == "true") {
            const loadingTemplateId = $(this.currentPanel).getAttribute("loading-template-id");
            if (loadingTemplateId == "") {
                $(this.panel).find("[record-list-panel]").setInnerHtml($("#loading-panel-template").getInnerHtml());
            }
            else {
                $(this.panel).find("[record-list-panel]").setInnerHtml($(loadingTemplateId).getInnerHtml());
            }
        }
        else {
            $(this.panel).find("[record-list-panel]").setInnerHtml("");
        }
        const allowSearch = $(this.currentPanel).getAttribute("allow-search") == "true";
        if (allowSearch) {
            $(this.panel).find("[search-panel]").removeClass("display-none");
        }
        else {
            $(this.panel).find("[search-panel]").addClass("display-none");
        }
        if ($(this.currentPanel).getAttribute("footer-visible") == "false") {
            $(this.panel).find("[footer-panel]").addClass("display-none");
        }
        const rect = this.currentPanel.getBoundingClientRect();
        $(this.panel).setAttribute("processing", "true");
        $(this.panel).removeClass("display-none");
        if ($(this.currentPanel).hasAttribute("panel-width")) {
            $(this.panel).setStyle("width", $(this.currentPanel).getAttribute("panel-width"));
        }
        else {
            $(this.panel).setStyle("width", rect.width + "px");
        }
        this.setPanelPosition(rect);
        setTimeout(function () {
            $(this.panel).removeAttribute("processing");
            const tx = $(this.panel).find("[search-textbox]").getFirstElement();
            if (allowSearch == true || tx != null) {
                $(tx).setFocus();
            }
            else {
                $(this.panel).find("[tabindex]").setFocus();
            }
            this.setPanelPosition(this.currentPanel.getBoundingClientRect());
        }.bind(this), 100);
        if ($(this.panel).getAttribute("search-default-list") == "true") {
            this.htmx.trigger("#data-record-popup-panel", "search");
        }
    }
    setPanelPosition(rect) {
        const scrollBarAdjustWidth = 20;
        if (this.panel.getAttribute("selection-mode") == "Multiple" ||
            rect.x + $(this.panel).getOuterWidth() > window.innerWidth) {
            if ($(this.panel).getOuterWidth() > window.innerWidth) {
                $(this.panel).setStyle("left", "0px");
            }
            else {
                $(this.panel).setStyle("left", (window.innerWidth - $(this.panel).getInnerWidth() - scrollBarAdjustWidth) + "px");
            }
        }
        else {
            $(this.panel).setStyle("left", rect.x + "px");
        }
        if ((rect.y + rect.height) + $(this.panel).getOuterHeight() > window.innerHeight) {
            if ($(this.panel).getOuterHeight() > window.innerHeight) {
                $(this.panel).setStyle("top", "0px");
            }
            else {
                $(this.panel).setStyle("top", (window.innerHeight - $(this.panel).getOuterHeight()) + "px");
            }
        }
        else {
            if (this.panel.getAttribute("selection-mode") == "Multiple") {
                if (rect.y < 0) {
                    $(this.panel).setStyle("top", "0px");
                }
                else {
                    $(this.panel).setStyle("top", rect.y + "px");
                }
            }
            else {
                $(this.panel).setStyle("top", (rect.y + rect.height) + "px");
            }
        }
    }
    addTemplate_Click(target, e) {
        const rpl = $(target).getFirstParent("[selection-mode='Template']").find("[record-list-panel]").getFirstElement();
        const templateId = "#" + $(target).getAttribute("template-id");
        const html = $(templateId).getInnerHtml();
        const div = document.createElement("div");
        div.innerHTML = html;
        rpl.insertAdjacentElement("beforeend", div.children[0]);
    }
    searchButton_Click(element, e) {
        this.htmx.trigger("#data-record-popup-panel", "search");
    }
    searchTextbox_Keydown(element, e) {
        if (e.key == "Enter") {
            this.htmx.trigger("#data-record-popup-panel", "search");
        }
        if (e.key == "Escape") {
            this.hide();
        }
        if (e.key == "ArrowDown") {
            const pl = $(this.panel).find("[record-list-panel] [data-record-panel]").getFirstElement();
            if (pl != null) {
                $(pl).setFocus();
                $(this.panel).find("[record-list-panel]").setScrollTop(0);
                e.preventDefault();
            }
        }
    }
    dataRecordPanel_Click(element, e) {
        if ($(e.target).hasAttribute("href") == true) {
            return;
        }
        if ($(e.target).hasAttribute("delete-record") == true) {
            return;
        }
        let pl = $(e.target).getFirstElement();
        if ($(pl).hasAttribute("data-record-panel") == false) {
            pl = $(pl).getParent("[data-record-panel]").getFirstElement();
        }
        this.recordSelected(pl);
    }
    dataRecordPanel_Keydown(element, e) {
        const recordListPanel = $(e.target).getFirstParent("[record-list-panel]").getFirstElement();
        if (e.key == "Escape") {
            $(this.panel).find("[search-textbox]").setFocus();
        }
        else if (e.key == "Enter") {
            this.recordSelected(element);
        }
        else if (e.key == "ArrowUp") {
            const pl = $(element).getSibling("Previous").getLastElement();
            if (pl == null) {
                $($(recordListPanel).find("[data-record-panel]").getLastElement()).setFocus();
            }
            else {
                $(pl).setFocus();
            }
        }
        else if (e.key == "ArrowDown") {
            const pl = $(element).getSibling("Next").getFirstElement();
            if (pl == null) {
                $(recordListPanel).find("[data-record-panel]").setFocus();
            }
            else {
                $(pl).setFocus();
            }
        }
    }
    recordSelected(panel) {
        const pl = panel;
        if ($(this.panel).getAttribute("selection-mode") == "Single") {
            if (this.targetPanel != null) {
                $(this.targetPanel).setInnerHtml("");
                $(this.targetPanel).setInnerHtml($(pl).getInnerHtml());
                $(this.targetPanel).setFocus();
            }
            $(this.panel).addClass("display-none");
            this.targetPanel = null;
        }
        if ($(this.panel).getAttribute("selection-mode") == "Multiple") {
            $(this.targetPanel).appendInnerHtml($(pl).getOuterHtml());
            $(this.targetPanel).setScrollTop(100000);
            const recordListPanel = $(pl).getFirstParent("[record-list-panel]").getFirstElement();
            const plNext = $(pl).getSibling("Next").getFirstElement();
            if (plNext == null) {
                $(recordListPanel).find("[data-record-panel]").setFocus();
            }
            else {
                $(plNext).setFocus();
            }
            $(pl).remove();
            if ($(recordListPanel).find("[data-record-panel]").getElementCount() == 0) {
                $(this.panel).find("[search-textbox]").setFocus();
            }
        }
    }
    dataRecordIcon_Click(element, e) {
        $(element).getFirstParent("[data-record-panel]").remove();
    }
    dataRecordIcon_Keydown(element, e) {
        if (e.key == "Enter") {
            $(element).getFirstParent("[data-record-panel]").remove();
        }
    }
    closeButton_Click(element, e) {
        this.hide();
    }
    hide() {
        $(this.targetPanel).setFocus();
        $(this.panel).addClass("display-none");
        this.targetPanel = null;
    }
    body_Click(e) {
        if ($(this.panel).hasClass("display-none") == false &&
            $(this.panel).hasAttribute("processing") == false) {
            const rect = this.panel.getBoundingClientRect();
            if (rect.left > e.clientX || rect.left + rect.width < e.clientX || rect.top > e.clientY || rect.top + rect.height < e.clientY) {
                $(this.panel).addClass("display-none");
                this.targetPanel = null;
            }
        }
    }
}
//# sourceMappingURL=DataRecordPopupPanel.js.map