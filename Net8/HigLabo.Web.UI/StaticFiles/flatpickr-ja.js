(function (global, factory) {
    typeof exports === 'object' && typeof module !== 'undefined' ? factory(exports) :
        typeof define === 'function' && define.amd ? define(['exports'], factory) :
            (global = typeof globalThis !== 'undefined' ? globalThis : global || self, factory(global.ja = {}));
}(this, (function (exports) {
    'use strict';

    var fp = typeof window !== "undefined" && window.flatpickr !== undefined
        ? window.flatpickr
        : {
            l10ns: {},
        };
    var Japanese = {
        weekdays: {
            shorthand: ["��", "��", "��", "��", "��", "��", "�y"],
            longhand: [
                "���j��",
                "���j��",
                "�Ηj��",
                "���j��",
                "�ؗj��",
                "���j��",
                "�y�j��",
            ],
        },
        months: {
            shorthand: [
                "1��",
                "2��",
                "3��",
                "4��",
                "5��",
                "6��",
                "7��",
                "8��",
                "9��",
                "10��",
                "11��",
                "12��",
            ],
            longhand: [
                "1��",
                "2��",
                "3��",
                "4��",
                "5��",
                "6��",
                "7��",
                "8��",
                "9��",
                "10��",
                "11��",
                "12��",
            ],
        },
        time_24hr: true,
        rangeSeparator: " ���� ",
        monthAriaLabel: "��",
        amPM: ["�ߑO", "�ߌ�"],
        yearAriaLabel: "�N",
        hourAriaLabel: "����",
        minuteAriaLabel: "��",
    };
    fp.l10ns.ja = Japanese;
    var ja = fp.l10ns;

    exports.Japanese = Japanese;
    exports.default = ja;

    Object.defineProperty(exports, '__esModule', { value: true });

})));