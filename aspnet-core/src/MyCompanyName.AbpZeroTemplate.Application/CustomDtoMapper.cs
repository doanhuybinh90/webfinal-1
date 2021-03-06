using MyCompanyName.AbpZeroTemplate.LinkPro.Dtos;
using MyCompanyName.AbpZeroTemplate.LinkPro;
using MyCompanyName.AbpZeroTemplate.PriceUser.Dtos;
using MyCompanyName.AbpZeroTemplate.PriceUser;
using MyCompanyName.AbpZeroTemplate.DownloadEbook.Dtos;
using MyCompanyName.AbpZeroTemplate.DownloadEbook;
using MyCompanyName.AbpZeroTemplate.Oppinion.Dtos;
using MyCompanyName.AbpZeroTemplate.Oppinion;
using MyCompanyName.AbpZeroTemplate.Ebook.Dtos;
using MyCompanyName.AbpZeroTemplate.Ebook;
using MyCompanyName.AbpZeroTemplate.TypeEbook.Dtos;
using MyCompanyName.AbpZeroTemplate.TypeEbook;
using MyCompanyName.AbpZeroTemplate.Place.Dtos;
using MyCompanyName.AbpZeroTemplate.Place;
using MyCompanyName.AbpZeroTemplate.SubjectEducation.Dtos;
using MyCompanyName.AbpZeroTemplate.SubjectEducation;
using MyCompanyName.AbpZeroTemplate.Status.Dtos;
using MyCompanyName.AbpZeroTemplate.Status;
using MyCompanyName.AbpZeroTemplate.TypeFile.Dtos;
using MyCompanyName.AbpZeroTemplate.TypeFile;
using MyCompanyName.AbpZeroTemplate.Rank.Dtos;
using MyCompanyName.AbpZeroTemplate.Rank;
using MyCompanyName.AbpZeroTemplate.Class.Dtos;
using MyCompanyName.AbpZeroTemplate.Class;
using MyCompanyName.AbpZeroTemplate.Subject.Dtos;
using MyCompanyName.AbpZeroTemplate.Subject;
using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.EntityHistory;
using Abp.Localization;
using Abp.Notifications;
using Abp.Organizations;
using Abp.UI.Inputs;
using AutoMapper;
using MyCompanyName.AbpZeroTemplate.Auditing.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Accounts.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Permissions.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Roles;
using MyCompanyName.AbpZeroTemplate.Authorization.Roles.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Users;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Importing.Dto;
using MyCompanyName.AbpZeroTemplate.Authorization.Users.Profile.Dto;
using MyCompanyName.AbpZeroTemplate.Chat;
using MyCompanyName.AbpZeroTemplate.Chat.Dto;
using MyCompanyName.AbpZeroTemplate.Editions;
using MyCompanyName.AbpZeroTemplate.Editions.Dto;
using MyCompanyName.AbpZeroTemplate.Friendships;
using MyCompanyName.AbpZeroTemplate.Friendships.Cache;
using MyCompanyName.AbpZeroTemplate.Friendships.Dto;
using MyCompanyName.AbpZeroTemplate.Localization.Dto;
using MyCompanyName.AbpZeroTemplate.MultiTenancy;
using MyCompanyName.AbpZeroTemplate.MultiTenancy.Dto;
using MyCompanyName.AbpZeroTemplate.MultiTenancy.HostDashboard.Dto;
using MyCompanyName.AbpZeroTemplate.MultiTenancy.Payments;
using MyCompanyName.AbpZeroTemplate.MultiTenancy.Payments.Dto;
using MyCompanyName.AbpZeroTemplate.Notifications.Dto;
using MyCompanyName.AbpZeroTemplate.Organizations.Dto;
using MyCompanyName.AbpZeroTemplate.Sessions.Dto;

namespace MyCompanyName.AbpZeroTemplate
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
           configuration.CreateMap<CreateOrEditPbLinkProDto, PbLinkPro>().ReverseMap();
           configuration.CreateMap<PbLinkProDto, PbLinkPro>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbPriceUserDto, PbPriceUser>().ReverseMap();
           configuration.CreateMap<PbPriceUserDto, PbPriceUser>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbDownloadEbookDto, PbDownloadEbook>().ReverseMap();
           configuration.CreateMap<PbDownloadEbookDto, PbDownloadEbook>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbOppinionDto, PbOppinion>().ReverseMap();
           configuration.CreateMap<PbOppinionDto, PbOppinion>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbEbookDto, PbEbook>().ReverseMap();
           configuration.CreateMap<PbEbookDto, PbEbook>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbTypeEbookDto, PbTypeEbook>().ReverseMap();
           configuration.CreateMap<PbTypeEbookDto, PbTypeEbook>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbPlaceDto, PbPlace>().ReverseMap();
           configuration.CreateMap<PbPlaceDto, PbPlace>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbSubjectEducationDto, PbSubjectEducation>().ReverseMap();
           configuration.CreateMap<PbSubjectEducationDto, PbSubjectEducation>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbStatusDto, PbStatus>().ReverseMap();
           configuration.CreateMap<PbStatusDto, PbStatus>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbTypeFileDto, PbTypeFile>().ReverseMap();
           configuration.CreateMap<PbTypeFileDto, PbTypeFile>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbRankDto, PbRank>().ReverseMap();
           configuration.CreateMap<PbRankDto, PbRank>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbClassDto, PbClass>().ReverseMap();
           configuration.CreateMap<PbClassDto, PbClass>().ReverseMap();
           configuration.CreateMap<CreateOrEditPbSubjectDto, PbSubject>().ReverseMap();
           configuration.CreateMap<PbSubjectDto, PbSubject>().ReverseMap();
            //Inputs
            configuration.CreateMap<CheckboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<SingleLineStringInputType, FeatureInputTypeDto>();
            configuration.CreateMap<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<IInputType, FeatureInputTypeDto>()
                .Include<CheckboxInputType, FeatureInputTypeDto>()
                .Include<SingleLineStringInputType, FeatureInputTypeDto>()
                .Include<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<ILocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>()
                .Include<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<LocalizableComboboxItem, LocalizableComboboxItemDto>();
            configuration.CreateMap<ILocalizableComboboxItem, LocalizableComboboxItemDto>()
                .Include<LocalizableComboboxItem, LocalizableComboboxItemDto>();

            //Chat
            configuration.CreateMap<ChatMessage, ChatMessageDto>();
            configuration.CreateMap<ChatMessage, ChatMessageExportDto>();

            //Feature
            configuration.CreateMap<FlatFeatureSelectDto, Feature>().ReverseMap();
            configuration.CreateMap<Feature, FlatFeatureDto>();

            //Role
            configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            configuration.CreateMap<Role, RoleListDto>();
            configuration.CreateMap<UserRole, UserListRoleDto>();

            //Edition
            configuration.CreateMap<EditionEditDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<EditionCreateDto, SubscribableEdition>();
            configuration.CreateMap<EditionSelectDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<Edition, EditionInfoDto>().Include<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<SubscribableEdition, EditionListDto>();
            configuration.CreateMap<Edition, EditionEditDto>();
            configuration.CreateMap<Edition, SubscribableEdition>();
            configuration.CreateMap<Edition, EditionSelectDto>();


            //Payment
            configuration.CreateMap<SubscriptionPaymentDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPaymentListDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPayment, SubscriptionPaymentInfoDto>();

            //Permission
            configuration.CreateMap<Permission, FlatPermissionDto>();
            configuration.CreateMap<Permission, FlatPermissionWithLevelDto>();

            //Language
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageEditDto>();
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageListDto>();
            configuration.CreateMap<NotificationDefinition, NotificationSubscriptionWithDisplayNameDto>();
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageEditDto>()
                .ForMember(ldto => ldto.IsEnabled, options => options.MapFrom(l => !l.IsDisabled));

            //Tenant
            configuration.CreateMap<Tenant, RecentTenant>();
            configuration.CreateMap<Tenant, TenantLoginInfoDto>();
            configuration.CreateMap<Tenant, TenantListDto>();
            configuration.CreateMap<TenantEditDto, Tenant>().ReverseMap();
            configuration.CreateMap<CurrentTenantInfoDto, Tenant>().ReverseMap();

            //User
            configuration.CreateMap<User, UserEditDto>()
                .ForMember(dto => dto.Password, options => options.Ignore())
                .ReverseMap()
                .ForMember(user => user.Password, options => options.Ignore());
            configuration.CreateMap<User, UserLoginInfoDto>();
            configuration.CreateMap<User, UserListDto>();
            configuration.CreateMap<User, ChatUserDto>();
            configuration.CreateMap<User, OrganizationUnitUserListDto>();
            configuration.CreateMap<Role, OrganizationUnitRoleListDto>();
            configuration.CreateMap<CurrentUserProfileEditDto, User>().ReverseMap();
            configuration.CreateMap<UserLoginAttemptDto, UserLoginAttempt>().ReverseMap();
            configuration.CreateMap<ImportUserDto, User>();

            //AuditLog
            configuration.CreateMap<AuditLog, AuditLogListDto>();
            configuration.CreateMap<EntityChange, EntityChangeListDto>();
            configuration.CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();

            //Friendship
            configuration.CreateMap<Friendship, FriendDto>();
            configuration.CreateMap<FriendCacheItem, FriendDto>();

            //OrganizationUnit
            configuration.CreateMap<OrganizationUnit, OrganizationUnitDto>();

            /* ADD YOUR OWN CUSTOM AUTOMAPPER MAPPINGS HERE */
        }
    }
}
