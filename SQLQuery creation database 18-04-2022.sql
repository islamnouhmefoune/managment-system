USE [master]
GO

/****** Object:  Database [droit_propriter_etat]    Script Date: 04/18/2022 12:05:51 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'droit_propriter_etat')
DROP DATABASE [droit_propriter_etat]
GO

USE [master]
GO

/****** Object:  Database [droit_propriter_etat]    Script Date: 04/18/2022 12:05:51 ******/
CREATE DATABASE [droit_propriter_etat] ON  primary
( NAME = N'droit_propriter_etat', FILENAME =  N'J:\DATA\droit_prop_etat.MDF' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'droit_propriter_etat_log', FILENAME = N'J:\DATA\droit_prop_etat_log.LDF' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [droit_propriter_etat] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [droit_propriter_etat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
Alter DATABASE [droit_propriter_etat] Collate Arabic_100_CI_AI
GO
ALTER DATABASE [droit_propriter_etat] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET ARITHABORT OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [droit_propriter_etat] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [droit_propriter_etat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [droit_propriter_etat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET  ENABLE_BROKER 
GO

ALTER DATABASE [droit_propriter_etat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [droit_propriter_etat] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [droit_propriter_etat] SET  READ_WRITE 
GO

ALTER DATABASE [droit_propriter_etat] SET RECOVERY FULL 
GO

ALTER DATABASE [droit_propriter_etat] SET  MULTI_USER 
GO

ALTER DATABASE [droit_propriter_etat] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [droit_propriter_etat] SET DB_CHAINING OFF 
GO



USE [droit_propriter_etat]
GO
/****** Object:  Table [dbo].[Abattement]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abattement](
	[Cd_abat] [int]identity NOT NULL,
	[Duree_vers] [int] NULL,
	[Coef_ech] [float] NULL,
	[Taux_Abat] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_abat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directeur]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Directeur](
	[Cd_direc_] [int] identity NOT NULL,
	[Nom_direc] [varchar](25) NOT NULL,
	[Pre_direc] [varchar](25) NOT NULL,
	[N_rapp_nomin_direc] [int] NOT NULL,
	[Dat_rapp_nomin_direc] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_direc_] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gestionnaire]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gestionnaire](
	[Cd_gestion] [int] identity NOT NULL,
	[Nom_gestion] [varchar](25) NOT NULL,
	[Adr_gestion] [varchar](25) NOT NULL,
	[N_rapp_dec_vent] [int] NOT NULL,
	[Dat_rapp_dec_vent] [date] NOT NULL,
	[Aut_sor_rapp_dec_vent] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_gestion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Wilaya]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Wilaya](
	[Cd_wilaya] [int] identity NOT NULL,
	[Nom_wilaya] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_wilaya] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rapport_evaluation]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rapport_evaluation](
	[Cd_rapp_eval_immb] [int] identity NOT NULL,
	[Dat_rapp_eval_immb] [date] NULL,
	[N_rappi_eval_immb] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_rapp_eval_immb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Commission_cession_immobiliere]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commission_cession_immobiliere](
	[Cd_comi_reno_immb] [int] identity NOT NULL,
	[N_rapp_cre__reno_immb] [int] NULL,
	[Dat_rapp_cre_reno_immb] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_comi_reno_immb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PV_Commession_Cession]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PV_Commession_Cession](
	[Cd_Pv_com_cess] [int] identity NOT NULL,
	[Dat_PV_com_cess] [date] NULL,
	[Cd_comi_reno_immb] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_Pv_com_cess] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Daira]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Daira](
	[Cd_daira] [int] identity NOT NULL,
	[Nom_daira] [varchar](25) NULL,
	[Cd_wilaya] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_daira] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Commune]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Commune](
	[Cd_commune] [int] identity NOT NULL,
	[Nom_commune] [varchar](25) NULL,
	[Cd_daira] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_commune] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quartier]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quartier](
	[Cd_Quartier] [int] identity NOT NULL,
	[Nom_Quartier] [varchar](25) NULL,
	[Cd_commune] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_Quartier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Residence]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Residence](
	[Cd_residence] [int] identity NOT NULL,
	[Adr_residence] [varchar](20) NULL,
	[beneficiaire_cd_bene] [int] NULL,
	[Cd_Quartier] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_residence] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Beneficiaire]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Beneficiaire](
	[Cd_bene] [int]identity NOT NULL,
	[nom_bene] [varchar](25) NOT NULL,
	[pre_bene] [varchar](25) NOT NULL,
	[Date_nais] [date] NOT NULL,
	[lieu_nais] [varchar](25) NULL,
	[pre_pere_bene] [varchar](25) NOT NULL,
	[Nom_mere_bene] [varchar](25) NOT NULL,
	[Pre_mere_bene] [varchar](25) NOT NULL,
	[residence_cd_residence] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_bene] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Local]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Local](
	[Cd_Loc] [int] identity NOT NULL,
	[Type_Loc] [varchar](20) NULL,
	[Adr_Loc] [varchar](20) NULL,
	[Date_Utili_Loc] [date] NULL,
	[Zone_Loc] [float] NULL,
	[N_Loc] [int] NULL,
	[Disc_immb] [varchar](150) NULL,
	[N_bat] [int] NULL,
	[N_escal] [int] NULL,
	[N_etage] [int] NULL,
	[N_port] [int] NULL,
	[Prix_immob] [float] NULL,
	[beneficiaire_cd_bene] [int] NULL,
	[Cd_rapp_eval_immb] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_Loc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Certificat_engagement_achat]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certificat_engagement_achat](
	[N_Cert_Engag_Acht] [int] identity NOT NULL,
	[Date_Cert_Engeg_Acht] [date] NULL,
	[beneficiaire_cd_bene] [int] NULL,
	[Cd_gestion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_Cert_Engag_Acht] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calendrier_valueur_initale]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendrier_valueur_initale](
	[N_tab_val_ava_init] [int] identity NOT NULL,
	[Dat_tab_val_ava_init] [date] NULL,
	[Val_ava_init] [int] NULL,
	[beneficiaire_cd_bene] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_tab_val_ava_init] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attestation_paiemnet_loyer]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attestation_paiemnet_loyer](
	[N_cert_loc] [int] identity NOT NULL,
	[Dat_cert_loc_] [date] NULL,
	[Deb_paiement] [date] NULL,
	[Fin_paiement] [date] NULL,
	[Mont_paiement] [float] NULL,
	[N_bon] [int] NULL,
	[Dat_bon] [date] NULL,
	[Cd_bene] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_cert_loc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arrete_cession_bien_etat]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arrete_cession_bien_etat](
	[N_rapp_ren_immb] [int] identity NOT NULL,
	[Dat_rapp_ren_immob] [date] NULL,
	[Cd_direc_] [int] NULL,
	[beneficiaire_cd_bene] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_rapp_ren_immb] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Echencer_Versement]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Echencer_Versement](
	[Num_tab_vers] [int] identity NOT NULL,
	[Dat_tab_vers] [date] NULL,
	[Mont_loy_ret] [float] NULL,
	[Mont_vers_init] [float] NULL,
	[Mont_Gar] [float] NULL,
	[Coef_Appli] [float] NULL,
	[beneficiaire_cd_bene] [int] NULL,
	[abattement_cd_abat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Num_tab_vers] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Droits_de_propriete_de_etat]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Droits_de_propriete_de_etat](
	[N_tab_vers_droi_prop_etat] [int] identity NOT NULL,
	[Dat_tab_vers_droi_prop_etat] [date] NULL,
	[Droi_prop_etat] [float] NULL,
	[beneficiaire_cd_bene] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[N_tab_vers_droi_prop_etat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Demande_acquisition]    Script Date: 04/18/2022 12:14:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demande_acquisition](
	[Cd_dem] [int] identity NOT NULL,
	[Dat_dem_acqu] [date] NULL,
	[N_dem_acqu] [int] NULL,
	[N_rapp_ren_immb] [int] NULL,
	[Cd_Pv_com_cess] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cd_dem] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/******               Object:  Table [dbo].[users]                          *********/
create table users(
    Id_User int identity not null primary key,
	username varchar(20)not null,
	password nvarchar(50) not null,
	full_name varchar(20) not null,
	type varchar(20) null,
	phone int ,
	address varchar(20)
)
GO







/****** Object:  ForeignKey [FK_PV_Commession_Cession_Cd_comi_reno_immb]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[PV_Commession_Cession]  WITH CHECK ADD  CONSTRAINT [FK_PV_Commession_Cession_Cd_comi_reno_immb] FOREIGN KEY([Cd_comi_reno_immb])
REFERENCES [dbo].[Commission_cession_immobiliere] ([Cd_comi_reno_immb])
GO
ALTER TABLE [dbo].[PV_Commession_Cession] CHECK CONSTRAINT [FK_PV_Commession_Cession_Cd_comi_reno_immb]
GO
/****** Object:  ForeignKey [FK_Daira_Cd_wilaya]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Daira]  WITH CHECK ADD  CONSTRAINT [FK_Daira_Cd_wilaya] FOREIGN KEY([Cd_wilaya])
REFERENCES [dbo].[Wilaya] ([Cd_wilaya])
GO
ALTER TABLE [dbo].[Daira] CHECK CONSTRAINT [FK_Daira_Cd_wilaya]
GO
/****** Object:  ForeignKey [FK_commune_Cd_daira]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Commune]  WITH CHECK ADD  CONSTRAINT [FK_commune_Cd_daira] FOREIGN KEY([Cd_daira])
REFERENCES [dbo].[Daira] ([Cd_daira])
GO
ALTER TABLE [dbo].[Commune] CHECK CONSTRAINT [FK_commune_Cd_daira]
GO
/****** Object:  ForeignKey [FK_Quartier_Cd_commune]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Quartier]  WITH CHECK ADD  CONSTRAINT [FK_Quartier_Cd_commune] FOREIGN KEY([Cd_commune])
REFERENCES [dbo].[Commune] ([Cd_commune])
GO
ALTER TABLE [dbo].[Quartier] CHECK CONSTRAINT [FK_Quartier_Cd_commune]
GO
/****** Object:  ForeignKey [FK_residence_Cd_Quartier]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Residence]  WITH CHECK ADD  CONSTRAINT [FK_residence_Cd_Quartier] FOREIGN KEY([Cd_Quartier])
REFERENCES [dbo].[Quartier] ([Cd_Quartier])
GO
ALTER TABLE [dbo].[Residence] CHECK CONSTRAINT [FK_residence_Cd_Quartier]
GO
/****** Object:  ForeignKey [FK_Beneficiaire_residence_cd_residence]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Beneficiaire]  WITH CHECK ADD  CONSTRAINT [FK_Beneficiaire_residence_cd_residence] FOREIGN KEY([residence_cd_residence])
REFERENCES [dbo].[Residence] ([Cd_residence])
GO
ALTER TABLE [dbo].[Beneficiaire] CHECK CONSTRAINT [FK_Beneficiaire_residence_cd_residence]
GO
/****** Object:  ForeignKey [FK_Local_beneficiaire_cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Local]  WITH CHECK ADD  CONSTRAINT [FK_Local_beneficiaire_cd_bene] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Local] CHECK CONSTRAINT [FK_Local_beneficiaire_cd_bene]
GO
/****** Object:  ForeignKey [FK_Local_Cd_rapp_eval_immb]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Local]  WITH CHECK ADD  CONSTRAINT [FK_Local_Cd_rapp_eval_immb] FOREIGN KEY([Cd_rapp_eval_immb])
REFERENCES [dbo].[Rapport_evaluation] ([Cd_rapp_eval_immb])
GO
ALTER TABLE [dbo].[Local] CHECK CONSTRAINT [FK_Local_Cd_rapp_eval_immb]
GO
/****** Object:  ForeignKey [FK_Certificat_engagement_achat_Beneficiaire]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Certificat_engagement_achat]  WITH CHECK ADD  CONSTRAINT [FK_Certificat_engagement_achat_Beneficiaire] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Certificat_engagement_achat] CHECK CONSTRAINT [FK_Certificat_engagement_achat_Beneficiaire]
GO
/****** Object:  ForeignKey [FK_certificat_engagement_achat_Cd_gestion]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Certificat_engagement_achat]  WITH CHECK ADD  CONSTRAINT [FK_certificat_engagement_achat_Cd_gestion] FOREIGN KEY([Cd_gestion])
REFERENCES [dbo].[Gestionnaire] ([Cd_gestion])
GO
ALTER TABLE [dbo].[Certificat_engagement_achat] CHECK CONSTRAINT [FK_certificat_engagement_achat_Cd_gestion]
GO
/****** Object:  ForeignKey [FK_calendrier_valueur_initale_beneficiaire_cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Calendrier_valueur_initale]  WITH CHECK ADD  CONSTRAINT [FK_calendrier_valueur_initale_beneficiaire_cd_bene] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Calendrier_valueur_initale] CHECK CONSTRAINT [FK_calendrier_valueur_initale_beneficiaire_cd_bene]
GO
/****** Object:  ForeignKey [FK_attestation__paiemnet__loyer_Cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Attestation_paiemnet_loyer]  WITH CHECK ADD  CONSTRAINT [FK_attestation__paiemnet__loyer_Cd_bene] FOREIGN KEY([Cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Attestation_paiemnet_loyer] CHECK CONSTRAINT [FK_attestation__paiemnet__loyer_Cd_bene]
GO
/****** Object:  ForeignKey [FK_arrete_cession_bien_etat_beneficiaire_cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Arrete_cession_bien_etat]  WITH CHECK ADD  CONSTRAINT [FK_arrete_cession_bien_etat_beneficiaire_cd_bene] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Arrete_cession_bien_etat] CHECK CONSTRAINT [FK_arrete_cession_bien_etat_beneficiaire_cd_bene]
GO
/****** Object:  ForeignKey [FK_arrete_cession_bien_etat_Cd_direc_]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Arrete_cession_bien_etat]  WITH CHECK ADD  CONSTRAINT [FK_arrete_cession_bien_etat_Cd_direc_] FOREIGN KEY([Cd_direc_])
REFERENCES [dbo].[Directeur] ([Cd_direc_])
GO
ALTER TABLE [dbo].[Arrete_cession_bien_etat] CHECK CONSTRAINT [FK_arrete_cession_bien_etat_Cd_direc_]
GO
/****** Object:  ForeignKey [FK_echencer_Versement_abattement_cd_abat]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Echencer_Versement]  WITH CHECK ADD  CONSTRAINT [FK_echencer_Versement_abattement_cd_abat] FOREIGN KEY([abattement_cd_abat])
REFERENCES [dbo].[Abattement] ([Cd_abat])
GO
ALTER TABLE [dbo].[Echencer_Versement] CHECK CONSTRAINT [FK_echencer_Versement_abattement_cd_abat]
GO
/****** Object:  ForeignKey [FK_echencer_Versement_beneficiaire_cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Echencer_Versement]  WITH CHECK ADD  CONSTRAINT [FK_echencer_Versement_beneficiaire_cd_bene] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Echencer_Versement] CHECK CONSTRAINT [FK_echencer_Versement_beneficiaire_cd_bene]
GO
/****** Object:  ForeignKey [FK_Droits_de_propriete_de_etat_beneficiaire_cd_bene]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Droits_de_propriete_de_etat]  WITH CHECK ADD  CONSTRAINT [FK_Droits_de_propriete_de_etat_beneficiaire_cd_bene] FOREIGN KEY([beneficiaire_cd_bene])
REFERENCES [dbo].[Beneficiaire] ([Cd_bene])
GO
ALTER TABLE [dbo].[Droits_de_propriete_de_etat] CHECK CONSTRAINT [FK_Droits_de_propriete_de_etat_beneficiaire_cd_bene]
GO
/****** Object:  ForeignKey [FK_Demande_acquisition_Cd_Pv_com_cess]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Demande_acquisition]  WITH CHECK ADD  CONSTRAINT [FK_Demande_acquisition_Cd_Pv_com_cess] FOREIGN KEY([Cd_Pv_com_cess])
REFERENCES [dbo].[PV_Commession_Cession] ([Cd_Pv_com_cess])
GO
ALTER TABLE [dbo].[Demande_acquisition] CHECK CONSTRAINT [FK_Demande_acquisition_Cd_Pv_com_cess]
GO
/****** Object:  ForeignKey [FK_Demande_acquisition_N_rapp_ren_immb]    Script Date: 04/18/2022 12:14:55 ******/
ALTER TABLE [dbo].[Demande_acquisition]  WITH CHECK ADD  CONSTRAINT [FK_Demande_acquisition_N_rapp_ren_immb] FOREIGN KEY([N_rapp_ren_immb])
REFERENCES [dbo].[Arrete_cession_bien_etat] ([N_rapp_ren_immb])
GO
ALTER TABLE [dbo].[Demande_acquisition] CHECK CONSTRAINT [FK_Demande_acquisition_N_rapp_ren_immb]
GO
