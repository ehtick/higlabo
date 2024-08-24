﻿using HigLabo.Net.OAuth;

namespace HigLabo.Net.Microsoft
{
    /// <summary>
    /// https://learn.microsoft.com/en-us/graph/api/resources/user?view=graph-rest-1.0
    /// </summary>
    public partial class User
    {
        public enum UserAgeGroup
        {
            Null,
            Minor,
            NotAdult,
            Adult,
            Eq,
            Ne,
            Not,
            In,
        }
        public enum UserConsentProvidedForMinor
        {
            Null,
            Granted,
            Denied,
            NotRequired,
            Eq,
            Ne,
            Not,
            In,
        }
        public enum UserLegalAgeGroupClassification
        {
            Null,
            MinorWithOutParentalConsent,
            MinorWithParentalConsent,
            MinorNoParentalConsentRequired,
            NotAdult,
            Adult,
        }

        public string? AboutMe { get; set; }
        public bool? AccountEnabled { get; set; }
        public UserAgeGroup AgeGroup { get; set; }
        public AssignedLicense[]? AssignedLicenses { get; set; }
        public AssignedPlan[]? AssignedPlans { get; set; }
        public DateTimeOffset? Birthday { get; set; }
        public String[]? BusinessPhones { get; set; }
        public string? City { get; set; }
        public string? CompanyName { get; set; }
        public UserConsentProvidedForMinor ConsentProvidedForMinor { get; set; }
        public string? Country { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string? CreationType { get; set; }
        public DateTimeOffset? DeletedDateTime { get; set; }
        public string? Department { get; set; }
        public string? DisplayName { get; set; }
        public DateTimeOffset? EmployeeHireDate { get; set; }
        public DateTimeOffset? EmployeeLeaveDateTime { get; set; }
        public string? EmployeeId { get; set; }
        public EmployeeOrgData? EmployeeOrgData { get; set; }
        public string? EmployeeType { get; set; }
        public string? ExternalUserState { get; set; }
        public DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }
        public string? FaxNumber { get; set; }
        public string? GivenName { get; set; }
        public DateTimeOffset? HireDate { get; set; }
        public string? Id { get; set; }
        public ObjectIdentity[]? Identities { get; set; }
        public String[]? ImAddresses { get; set; }
        public String[]? Interests { get; set; }
        public bool? IsResourceAccount { get; set; }
        public string? JobTitle { get; set; }
        public DateTimeOffset? LastPasswordChangeDateTime { get; set; }
        public UserLegalAgeGroupClassification LegalAgeGroupClassification { get; set; }
        public LicenseAssignmentState[]? LicenseAssignmentStates { get; set; }
        public string? Mail { get; set; }
        public MailboxSettings? MailboxSettings { get; set; }
        public string? MailNickname { get; set; }
        public string? MobilePhone { get; set; }
        public string? MySite { get; set; }
        public string? OfficeLocation { get; set; }
        public string? OnPremisesDistinguishedName { get; set; }
        public string? OnPremisesDomainName { get; set; }
        public OnPremisesExtensionAttributes? OnPremisesExtensionAttributes { get; set; }
        public string? OnPremisesImmutableId { get; set; }
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        public OnPremisesProvisioningError[]? OnPremisesProvisioningErrors { get; set; }
        public string? OnPremisesSamAccountName { get; set; }
        public string? OnPremisesSecurityIdentifier { get; set; }
        public bool? OnPremisesSyncEnabled { get; set; }
        public string? OnPremisesUserPrincipalName { get; set; }
        public String[]? OtherMails { get; set; }
        public string? PasswordPolicies { get; set; }
        public PasswordProfile? PasswordProfile { get; set; }
        public String[]? PastProjects { get; set; }
        public string? PostalCode { get; set; }
        public string? PreferredDataLocation { get; set; }
        public string? PreferredLanguage { get; set; }
        public string? PreferredName { get; set; }
        public ProvisionedPlan[]? ProvisionedPlans { get; set; }
        public String[]? ProxyAddresses { get; set; }
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
        public String[]? Responsibilities { get; set; }
        public String[]? Schools { get; set; }
        public string? SecurityIdentifier { get; set; }
        public bool? ShowInAddressList { get; set; }
        public SignInActivity? SignInActivity { get; set; }
        public DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }
        public String[]? Skills { get; set; }
        public string? State { get; set; }
        public string? StreetAddress { get; set; }
        public string? Surname { get; set; }
        public string? UsageLocation { get; set; }
        public string? UserPrincipalName { get; set; }
        public string? UserType { get; set; }
        public Activity[]? Activities { get; set; }
        public AgreementAcceptance[]? AgreementAcceptances { get; set; }
        public AppRoleAssignment[]? AppRoleAssignments { get; set; }
        public Authentication? Authentication { get; set; }
        public Calendar? Calendar { get; set; }
        public CalendarGroup[]? CalendarGroups { get; set; }
        public Calendar[]? Calendars { get; set; }
        public Event[]? CalendarView { get; set; }
        public ContactFolder[]? ContactFolders { get; set; }
        public Contact[]? Contacts { get; set; }
        public DirectoryObject[]? CreatedObjects { get; set; }
        public DirectoryObject[]? DirectReports { get; set; }
        public Drive? Drive { get; set; }
        public Drive[]? Drives { get; set; }
        public Event[]? Events { get; set; }
        public Extension[]? Extensions { get; set; }
        public InferenceClassification? InferenceClassification { get; set; }
        public OfficeGraphInsights? Insights { get; set; }
        public LicenseDetails[]? LicenseDetails { get; set; }
        public MailFolder[]? MailFolders { get; set; }
        public DirectoryObject? Manager { get; set; }
        public DirectoryObject[]? MemberOf { get; set; }
        public Message[]? Messages { get; set; }
        public Onenote? Onenote { get; set; }
        public OutlookUser? Outlook { get; set; }
        public DirectoryObject[]? OwnedDevices { get; set; }
        public DirectoryObject[]? OwnedObjects { get; set; }
        public Person[]? People { get; set; }
        public ProfilePhoto? Photo { get; set; }
        public PlannerUser? Planner { get; set; }
        public DirectoryObject[]? RegisteredDevices { get; set; }
        public Todo? Todo { get; set; }
        public DirectoryObject[]? TransitiveMemberOf { get; set; }
    }
}
