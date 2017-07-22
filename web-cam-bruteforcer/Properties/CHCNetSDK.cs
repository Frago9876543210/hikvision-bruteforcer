using System;
using System.Runtime.InteropServices;
namespace HCNetSDK
{
	/// <summary>
	/// CHCNetSDK µДХЄТЄЛµГчЎЈ
	/// </summary>
    public class CHCNetSDK
    {
        public CHCNetSDK()
        {
            //
            // TODO: ФЪґЛґ¦МнјУ№№ФмєЇКэВЯј­
            //
        }
        
        //SDKАаРН
        public const int SDK_PLAYMPEG4 = 1;//ІҐ·Еїв
        public const int SDK_HCNETSDK = 2;//НшВзїв

        public const int NAME_LEN = 32;//УГ»§Гыі¤¶И
        public const int PASSWD_LEN = 16;//ГЬВлі¤¶И
        public const int GUID_LEN = 16;      //GUIDі¤¶И
        public const int DEV_TYPE_NAME_LEN = 24;      //Йи±ёАаРНГыіЖі¤¶И
        public const int MAX_NAMELEN = 16;//DVR±ѕµШµЗВЅГы
        public const int MAX_RIGHT = 32;//Йи±ёЦ§іЦµДИЁПЮЈЁ1-12±нКѕ±ѕµШИЁПЮЈ¬13-32±нКѕФ¶іМИЁПЮЈ©
        public const int SERIALNO_LEN = 48;//РтБРєЕі¤¶И
        public const int MACADDR_LEN = 6;//macµШЦ·і¤¶И
        public const int MAX_ETHERNET = 2;//Йи±ёїЙЕдТФМ«НшВз
        public const int MAX_NETWORK_CARD = 4; //Йи±ёїЙЕдЧоґуНшїЁКэДї
        public const int PATHNAME_LEN = 128;//В·ѕ¶і¤¶И

        public const int MAX_NUMBER_LEN = 32;	//єЕВлЧоґуі¤¶И
        public const int MAX_NAME_LEN = 128; //Йи±ёГыіЖЧоґуі¤¶И

        public const int MAX_TIMESEGMENT_V30 = 8;//9000Йи±ёЧоґуК±јд¶ОКэ
        public const int MAX_TIMESEGMENT = 4;//8000Йи±ёЧоґуК±јд¶ОКэ
        public const int MAX_ICR_NUM = 8;   //ЧҐЕД»ъємНвВЛ№вЖ¬Ф¤ЦГµгКэ

        public const int MAX_SHELTERNUM = 4;//8000Йи±ёЧоґуХЪµІЗшУтКэ
        public const int PHONENUMBER_LEN = 32;//pppoeІ¦єЕєЕВлЧоґуі¤¶И

        public const int MAX_DISKNUM = 16;//8000Йи±ёЧоґуУІЕМКэ
        public const int MAX_DISKNUM_V10 = 8;//1.2°ж±ѕЦ®З°°ж±ѕ

        public const int MAX_WINDOW_V30 = 32;//9000Йи±ё±ѕµШПФКѕЧоґуІҐ·Еґ°їЪКэ
        public const int MAX_WINDOW = 16;//8000Йи±ёЧоґуУІЕМКэ
        public const int MAX_VGA_V30 = 4;//9000Йи±ёЧоґуїЙЅУVGAКэ
        public const int MAX_VGA = 1;//8000Йи±ёЧоґуїЙЅУVGAКэ

        public const int MAX_USERNUM_V30 = 32;//9000Йи±ёЧоґуУГ»§Кэ
        public const int MAX_USERNUM = 16;//8000Йи±ёЧоґуУГ»§Кэ
        public const int MAX_EXCEPTIONNUM_V30 = 32;//9000Йи±ёЧоґуТміЈґ¦АнКэ
        public const int MAX_EXCEPTIONNUM = 16;//8000Йи±ёЧоґуТміЈґ¦АнКэ
        public const int MAX_LINK = 6;//8000Йи±ёµҐНЁµАЧоґуКУЖµБчБ¬ЅУКэ
        public const int MAX_ITC_EXCEPTIONOUT = 32;//ЧҐЕД»ъЧоґу±ЁѕЇКдіц

        public const int MAX_DECPOOLNUM = 4;//µҐВ·ЅвВлЖчГїёцЅвВлНЁµАЧоґуїЙС­»·ЅвВлКэ
        public const int MAX_DECNUM = 4;//µҐВ·ЅвВлЖчµДЧоґуЅвВлНЁµАКэЈЁКµјКЦ»УРТ»ёцЈ¬ЖдЛыИэёц±ЈБфЈ©
        public const int MAX_TRANSPARENTNUM = 2;//µҐВ·ЅвВлЖчїЙЕдЦГЧоґуНёГчНЁµАКэ
        public const int MAX_CYCLE_CHAN = 16; //µҐВ·ЅвВлЖчЧоґуВЦС­НЁµАКэ
        public const int MAX_CYCLE_CHAN_V30 = 64;//ЧоґуВЦСЇНЁµАКэЈЁА©Х№Ј©
        public const int MAX_DIRNAME_LENGTH = 80;//ЧоґуДїВјі¤¶И

        public const int MAX_STRINGNUM_V30 = 8;//9000Йи±ёЧоґуOSDЧЦ·ыРРКэКэ
        public const int MAX_STRINGNUM = 4;//8000Йи±ёЧоґуOSDЧЦ·ыРРКэКэ
        public const int MAX_STRINGNUM_EX = 8;//8000¶ЁЦЖА©Х№
        public const int MAX_AUXOUT_V30 = 16;//9000Йи±ёЧоґуёЁЦъКдіцКэ
        public const int MAX_AUXOUT = 4;//8000Йи±ёЧоґуёЁЦъКдіцКэ
        public const int MAX_HD_GROUP = 16;//9000Йи±ёЧоґуУІЕМЧйКэ
        public const int MAX_NFS_DISK = 8; //8000Йи±ёЧоґуNFSУІЕМКэ

        public const int IW_ESSID_MAX_SIZE = 32;//WIFIµДSSIDєЕі¤¶И
        public const int IW_ENCODING_TOKEN_MAX = 32;//WIFIГЬЛшЧоґуЧЦЅЪКэ
        public const int WIFI_WEP_MAX_KEY_COUNT = 4;
        public const int WIFI_WEP_MAX_KEY_LENGTH = 33;
        public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;
        public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;
        public const int WIFI_MAX_AP_COUNT = 20;
        public const int MAX_SERIAL_NUM = 64;//Чо¶аЦ§іЦµДНёГчНЁµАВ·Кэ
        public const int MAX_DDNS_NUMS = 10;//9000Йи±ёЧоґуїЙЕдddnsКэ
        public const int MAX_EMAIL_ADDR_LEN = 48;//ЧоґуemailµШЦ·і¤¶И
        public const int MAX_EMAIL_PWD_LEN = 32;//ЧоґуemailГЬВлі¤¶И

        public const int MAXPROGRESS = 100;//»Ш·ЕК±µДЧоґу°Щ·ЦВК
        public const int MAX_SERIALNUM = 2;//8000Йи±ёЦ§іЦµДґ®їЪКэ 1-232Ј¬ 2-485
        public const int CARDNUM_LEN = 20;//їЁєЕі¤¶И
        public const int CARDNUM_LEN_OUT = 32; //НвІїЅб№№МеїЁєЕі¤¶И
        public const int MAX_VIDEOOUT_V30 = 4;//9000Йи±ёµДКУЖµКдіцКэ
        public const int MAX_VIDEOOUT = 2;//8000Йи±ёµДКУЖµКдіцКэ

        public const int MAX_PRESET_V30 = 256;// 9000Йи±ёЦ§іЦµДФЖМЁФ¤ЦГµгКэ
        public const int MAX_TRACK_V30 = 256;// 9000Йи±ёЦ§іЦµДФЖМЁ№мјЈКэ
        public const int MAX_CRUISE_V30 = 256;// 9000Йи±ёЦ§іЦµДФЖМЁСІєЅКэ
        public const int MAX_PRESET = 128;// 8000Йи±ёЦ§іЦµДФЖМЁФ¤ЦГµгКэ 
        public const int MAX_TRACK = 128;// 8000Йи±ёЦ§іЦµДФЖМЁ№мјЈКэ
        public const int MAX_CRUISE = 128;// 8000Йи±ёЦ§іЦµДФЖМЁСІєЅКэ 

        public const int CRUISE_MAX_PRESET_NUMS = 32;// Т»МхСІєЅЧо¶аµДСІєЅµг 

        public const int MAX_SERIAL_PORT = 8;//9000Йи±ёЦ§іЦ232ґ®їЪКэ
        public const int MAX_PREVIEW_MODE = 8;// Йи±ёЦ§іЦЧоґуФ¤ААДЈКЅКэДї 1»­Гж,4»­Гж,9»­Гж,16»­Гж.... 
        public const int MAX_MATRIXOUT = 16;// ЧоґуДЈДвѕШХуКдіцёцКэ 
        public const int LOG_INFO_LEN = 11840; // ИХЦѕёЅјУРЕПў 
        public const int DESC_LEN = 16;// ФЖМЁГиКцЧЦ·ыґ®і¤¶И 
        public const int PTZ_PROTOCOL_NUM = 200;// 9000ЧоґуЦ§іЦµДФЖМЁР­ТйКэ 

        public const int MAX_AUDIO = 1;//8000УпТф¶ФЅІНЁµАКэ
        public const int MAX_AUDIO_V30 = 2;//9000УпТф¶ФЅІНЁµАКэ
        public const int MAX_CHANNUM = 16;//8000Йи±ёЧоґуНЁµАКэ
        public const int MAX_ALARMIN = 16;//8000Йи±ёЧоґу±ЁѕЇКдИлКэ
        public const int MAX_ALARMOUT = 4;//8000Йи±ёЧоґу±ЁѕЇКдіцКэ
        //9000 IPCЅУИл
        public const int MAX_ANALOG_CHANNUM = 32;//Чоґу32ёцДЈДвНЁµА
        public const int MAX_ANALOG_ALARMOUT = 32; //Чоґу32В·ДЈДв±ЁѕЇКдіц 
        public const int MAX_ANALOG_ALARMIN = 32;//Чоґу32В·ДЈДв±ЁѕЇКдИл

        public const int MAX_IP_DEVICE = 32;//ФКРнЅУИлµДЧоґуIPЙи±ёКэ
        public const int MAX_IP_DEVICE_V40 = 64;//ФКРнЅУИлµДЧоґуIPЙи±ёКэ
        public const int MAX_IP_CHANNEL = 32;//ФКРнјУИлµДЧо¶аIPНЁµАКэ
        public const int MAX_IP_ALARMIN = 128;//ФКРнјУИлµДЧо¶а±ЁѕЇКдИлКэ
        public const int MAX_IP_ALARMOUT = 64;//ФКРнјУИлµДЧо¶а±ЁѕЇКдіцКэ
        public const int MAX_IP_ALARMIN_V40 = 4096;    //ФКРнјУИлµДЧо¶а±ЁѕЇКдИлКэ
        public const int MAX_IP_ALARMOUT_V40 = 4096;    //ФКРнјУИлµДЧо¶а±ЁѕЇКдіцКэ

        public const int MAX_RECORD_FILE_NUM = 20;      // ГїґОЙѕіэ»тХЯїМВјµДЧоґуОДјюКэ

        //SDK_V31 ATM
        public const int MAX_ATM_NUM = 1;
        public const int MAX_ACTION_TYPE = 12;
        public const int ATM_FRAMETYPE_NUM = 4;
        public const int MAX_ATM_PROTOCOL_NUM = 1025;
        public const int ATM_PROTOCOL_SORT = 4;
        public const int ATM_DESC_LEN = 32;
        // SDK_V31 ATM

        /* ЧоґуЦ§іЦµДНЁµАКэ ЧоґуДЈДвјУЙПЧоґуIPЦ§іЦ */
        public const int MAX_CHANNUM_V30 = MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL;//64
        public const int MAX_ALARMOUT_V30 = MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT;//96
        public const int MAX_ALARMIN_V30 = MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN;//160

        public const int MAX_CHANNUM_V40 = 512;
        public const int MAX_ALARMOUT_V40 = MAX_IP_ALARMOUT_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_ALARMIN_V40 = MAX_IP_ALARMIN_V40 + MAX_ANALOG_ALARMOUT;//4128

        public const int MAX_HUMAN_PICTURE_NUM = 10;   //ЧоґуХХЖ¬Кэ
        public const int MAX_HUMAN_BIRTHDATE_LEN = 10;

        public const int MAX_LAYERNUMS = 32;

        public const int MAX_ROIDETECT_NUM = 8;    //Ц§іЦµДROIЗшУтКэ
        public const int MAX_LANERECT_NUM   =     5;    //ЧоґуіµЕЖК¶±рЗшУтКэ
        public const int MAX_FORTIFY_NUM   =      10;   //ЧоґуІј·АёцКэ
        public const int MAX_INTERVAL_NUM  =      4;    //ЧоґуК±јдјдёфёцКэ
        public const int MAX_CHJC_NUM     =       3;    //ЧоґуіµБѕКЎ·ЭјтіЖЧЦ·ыёцКэ
        public const int MAX_VL_NUM        =      5;    //ЧоґуРйДвПЯИ¦ёцКэ
        public const int MAX_DRIVECHAN_NUM =      16;   //ЧоґуіµµАКэ
        public const int MAX_COIL_NUM      =      3;    //ЧоґуПЯИ¦ёцКэ
        public const int MAX_SIGNALLIGHT_NUM =    6;   //ЧоґуРЕєЕµЖёцКэ
        public const int LEN_32				=	32;
        public const int LEN_31				=	31; 
        public const int MAX_CABINET_COUNT  =     8;    //ЧоґуЦ§іЦ»ъ№сКэБї
        public const int MAX_ID_LEN         =     48;
        public const int MAX_PARKNO_LEN    =      16;
        public const int MAX_ALARMREASON_LEN =    32;
        public const int MAX_UPGRADE_INFO_LEN=    48; //»сИЎЙэј¶ОДјюЖҐЕдРЕПў(ДЈєэЙэј¶)
        public const int MAX_CUSTOMDIR_LEN  =     32; //ЧФ¶ЁТеДїВјі¤¶И

        public const int MAX_TRANSPARENT_CHAN_NUM  =    4;   //Гїёцґ®їЪФКРнЅЁБўµДЧоґуНёГчНЁµАКэ
        public const int MAX_TRANSPARENT_ACCESS_NUM =   4;   //ГїёцјаМэ¶ЛїЪФКРнЅУИлµДЧоґуЦч»ъКэ

        //ITS
        public const int MAX_PARKING_STATUS  =     8;    //іµО»ЧґМ¬ 0ґъ±нОЮіµЈ¬1ґъ±нУРіµЈ¬2ґъ±нС№ПЯ(УЕПИј¶ЧоёЯ), 3МШКвіµО» 
        public const int MAX_PARKING_NUM	   =      4;    //Т»ёцНЁµАЧоґу4ёціµО» (ґУЧуµЅУТіµО» КэЧй0Ў«3)

        public const int MAX_ITS_SCENE_NUM    =    16;   //ЧоґуіЎѕ°КэБї
        public const int MAX_SCENE_TIMESEG_NUM =   16;   //ЧоґуіЎѕ°К±јд¶ОКэБї
        public const int MAX_IVMS_IP_CHANNEL  =    128;  //ЧоґуIPНЁµАКэ
        public const int DEVICE_ID_LEN      =      48;   //Йи±ё±аєЕі¤¶И
        public const int MONITORSITE_ID_LEN  =     48;   //јаІвµг±аєЕі¤¶И
        public const int MAX_AUXAREA_NUM       =   16;   //ёЁЦъЗшУтЧоґуКэДї
        public const int MAX_SLAVE_CHANNEL_NUM =   16;   //ЧоґуґУНЁµАКэБї

        public const int MAX_SCH_TASKS_NUM = 10;

        public const int MAX_SERVERID_LEN   =         64; //Чоґу·юОсЖчIDµДі¤¶И
        public const int MAX_SERVERDOMAIN_LEN =       128; //·юОсЖчУтГыЧоґуі¤¶И
        public const int MAX_AUTHENTICATEID_LEN =     64; //ИПЦ¤IDЧоґуі¤¶И
        public const int MAX_AUTHENTICATEPASSWD_LEN = 32; //ИПЦ¤ГЬВлЧоґуі¤¶И
        public const int MAX_SERVERNAME_LEN =         64; //Чоґу·юОсЖчУГ»§Гы 
        public const int MAX_COMPRESSIONID_LEN =      64; //±аВлIDµДЧоґуі¤¶И
        public const int MAX_SIPSERVER_ADDRESS_LEN =  128; //SIP·юОсЖчµШЦ·Ц§іЦУтГыєНIPµШЦ·
        //С№ПЯ±ЁѕЇ
        public const int MAX_PlATE_NO_LEN =        32;   //іµЕЖєЕВлЧоґуі¤¶И 2013-09-27
        public const int UPNP_PORT_NUM	=		12;	  //upnp¶ЛїЪУіЙд¶ЛїЪКэДї

        
        public const int MAX_LOCAL_ADDR_LEN	= 96;		//SOCKSЧоґу±ѕµШНш¶ОёцКэ
        public const int MAX_COUNTRY_NAME_LEN = 4;		//№ъјТјтРґГыіЖі¤¶И

        //ВлБчБ¬ЅУ·ЅКЅ
        public const int NORMALCONNECT = 1;
        public const int MEDIACONNECT = 2;

        //Йи±ёРНєЕ(ґуАа)
        public const int HCDVR = 1;
        public const int MEDVR = 2;
        public const int PCDVR = 3;
        public const int HC_9000 = 4;
        public const int HF_I = 5;
        public const int PCNVR = 6;
        public const int HC_76NVR = 8;

        //NVRАаРН
        public const int DS8000HC_NVR = 0;
        public const int DS9000HC_NVR = 1;
        public const int DS8000ME_NVR = 2;

        /*******************И«ѕЦґнОуВл begin**********************/
        public const int NET_DVR_NOERROR = 0;//Г»УРґнОу
        public const int NET_DVR_PASSWORD_ERROR = 1;//УГ»§ГыГЬВлґнОу
        public const int NET_DVR_NOENOUGHPRI = 2;//ИЁПЮІ»Чг
        public const int NET_DVR_NOINIT = 3;//Г»УРіхКј»Ї
        public const int NET_DVR_CHANNEL_ERROR = 4;//НЁµАєЕґнОу
        public const int NET_DVR_OVER_MAXLINK = 5;//Б¬ЅУµЅDVRµДїН»§¶ЛёцКэі¬№эЧоґу
        public const int NET_DVR_VERSIONNOMATCH = 6;//°ж±ѕІ»ЖҐЕд
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//Б¬ЅУ·юОсЖчК§°Ь
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;//Пт·юОсЖч·ўЛНК§°Ь
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//ґУ·юОсЖчЅУКХКэѕЭК§°Ь
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;//ґУ·юОсЖчЅУКХКэѕЭі¬К±
        public const int NET_DVR_NETWORK_ERRORDATA = 11;//ґ«ЛНµДКэѕЭУРОу
        public const int NET_DVR_ORDER_ERROR = 12;//µчУГґОРтґнОу
        public const int NET_DVR_OPERNOPERMIT = 13;//ОЮґЛИЁПЮ
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVRГьБоЦґРРі¬К±
        public const int NET_DVR_ERRORSERIALPORT = 15;//ґ®їЪєЕґнОу
        public const int NET_DVR_ERRORALARMPORT = 16;//±ЁѕЇ¶ЛїЪґнОу
        public const int NET_DVR_PARAMETER_ERROR = 17;//ІОКэґнОу
        public const int NET_DVR_CHAN_EXCEPTION = 18;//·юОсЖчНЁµАґ¦УЪґнОуЧґМ¬
        public const int NET_DVR_NODISK = 19;//Г»УРУІЕМ
        public const int NET_DVR_ERRORDISKNUM = 20;//УІЕМєЕґнОу
        public const int NET_DVR_DISK_FULL = 21;//·юОсЖчУІЕМВъ
        public const int NET_DVR_DISK_ERROR = 22;//·юОсЖчУІЕМіцґн
        public const int NET_DVR_NOSUPPORT = 23;//·юОсЖчІ»Ц§іЦ
        public const int NET_DVR_BUSY = 24;//·юОсЖчГ¦
        public const int NET_DVR_MODIFY_FAIL = 25;//·юОсЖчРЮёДІ»іЙ№¦
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;//ГЬВлКдИлёсКЅІ»ХэИ·
        public const int NET_DVR_DISK_FORMATING = 27;//УІЕМХэФЪёсКЅ»ЇЈ¬І»ДЬЖф¶ЇІЩЧч
        public const int NET_DVR_DVRNORESOURCE = 28;//DVRЧКФґІ»Чг
        public const int NET_DVR_DVROPRATEFAILED = 29;//DVRІЩЧчК§°Ь
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;//ґтїЄPCЙщТфК§°Ь
        public const int NET_DVR_DVRVOICEOPENED = 31;//·юОсЖчУпТф¶ФЅІ±»ХјУГ
        public const int NET_DVR_TIMEINPUTERROR = 32;//К±јдКдИлІ»ХэИ·
        public const int NET_DVR_NOSPECFILE = 33;//»Ш·ЕК±·юОсЖчГ»УРЦё¶ЁµДОДјю
        public const int NET_DVR_CREATEFILE_ERROR = 34;//ґґЅЁОДјюіцґн
        public const int NET_DVR_FILEOPENFAIL = 35;//ґтїЄОДјюіцґн
        public const int NET_DVR_OPERNOTFINISH = 36; //ЙПґОµДІЩЧч»№Г»УРНкіЙ
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;//»сИЎµ±З°ІҐ·ЕµДК±јдіцґн
        public const int NET_DVR_PLAYFAIL = 38;//ІҐ·Еіцґн
        public const int NET_DVR_FILEFORMAT_ERROR = 39;//ОДјюёсКЅІ»ХэИ·
        public const int NET_DVR_DIR_ERROR = 40;//В·ѕ¶ґнОу
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;//ЧКФґ·ЦЕдґнОу
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;//ЙщїЁДЈКЅґнОу
        public const int NET_DVR_NOENOUGH_BUF = 43;//»єіеЗшМ«РЎ
        public const int NET_DVR_CREATESOCKET_ERROR = 44;//ґґЅЁSOCKETіцґн
        public const int NET_DVR_SETSOCKET_ERROR = 45;//ЙиЦГSOCKETіцґн
        public const int NET_DVR_MAX_NUM = 46;//ёцКэґпµЅЧоґу
        public const int NET_DVR_USERNOTEXIST = 47;//УГ»§І»ґжФЪ
        public const int NET_DVR_WRITEFLASHERROR = 48;//РґFLASHіцґн
        public const int NET_DVR_UPGRADEFAIL = 49;//DVRЙэј¶К§°Ь
        public const int NET_DVR_CARDHAVEINIT = 50;//ЅвВлїЁТСѕ­іхКј»Ї№э
        public const int NET_DVR_PLAYERFAILED = 51;//µчУГІҐ·ЕївЦРДіёцєЇКэК§°Ь
        public const int NET_DVR_MAX_USERNUM = 52;//Йи±ё¶ЛУГ»§КэґпµЅЧоґу
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;//»сµГїН»§¶ЛµДIPµШЦ·»тОпАнµШЦ·К§°Ь
        public const int NET_DVR_NOENCODEING = 54;//ёГНЁµАГ»УР±аВл
        public const int NET_DVR_IPMISMATCH = 55;//IPµШЦ·І»ЖҐЕд
        public const int NET_DVR_MACMISMATCH = 56;//MACµШЦ·І»ЖҐЕд
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//Йэј¶ОДјюУпСФІ»ЖҐЕд
        public const int NET_DVR_MAX_PLAYERPORT = 58;//ІҐ·ЕЖчВ·КэґпµЅЧоґу
        public const int NET_DVR_NOSPACEBACKUP = 59;//±ё·ЭЙи±ёЦРГ»УРЧг№»їХјдЅшРР±ё·Э
        public const int NET_DVR_NODEVICEBACKUP = 60;//Г»УРХТµЅЦё¶ЁµД±ё·ЭЙи±ё
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;//НјПсЛШО»КэІ»·ыЈ¬ПЮ24Й«
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;//НјЖ¬ёЯ*їні¬ПЮЈ¬ ПЮ128*256
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;//НјЖ¬ґуРЎі¬ПЮЈ¬ПЮ100K
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;//ФШИлµ±З°ДїВјПВPlayer Sdkіцґн
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;//ХТІ»µЅPlayer SdkЦРДіёцєЇКэИлїЪ
        public const int NET_DVR_LOADDSSDKFAILED = 66;//ФШИлµ±З°ДїВјПВDSsdkіцґн
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;//ХТІ»µЅDsSdkЦРДіёцєЇКэИлїЪ
        public const int NET_DVR_DSSDK_ERROR = 68;//µчУГУІЅвВлївDsSdkЦРДіёцєЇКэК§°Ь
        public const int NET_DVR_VOICEMONOPOLIZE = 69;//ЙщїЁ±»¶АХј
        public const int NET_DVR_JOINMULTICASTFAILED = 70;//јУИл¶аІҐЧйК§°Ь
        public const int NET_DVR_CREATEDIR_ERROR = 71;//ЅЁБўИХЦѕОДјюДїВјК§°Ь
        public const int NET_DVR_BINDSOCKET_ERROR = 72;//°у¶ЁМЧЅУЧЦК§°Ь
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;//socketБ¬ЅУЦР¶ПЈ¬ґЛґнОуНЁіЈКЗУЙУЪБ¬ЅУЦР¶П»тДїµДµШІ»їЙґп
        public const int NET_DVR_USERID_ISUSING = 74;//ЧўПъК±УГ»§IDХэФЪЅшРРДіІЩЧч
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;//јаМэК§°Ь
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;//іМРтТміЈ
        public const int NET_DVR_WRITEFILE_FAILED = 77;//РґОДјюК§°Ь
        public const int NET_DVR_FORMAT_READONLY = 78;//ЅыЦ№ёсКЅ»ЇЦ»¶БУІЕМ
        public const int NET_DVR_WITHSAMEUSERNAME = 79;//УГ»§ЕдЦГЅб№№ЦРґжФЪПаН¬µДУГ»§Гы
        public const int NET_DVR_DEVICETYPE_ERROR = 80;//µјИлІОКэК±Йи±ёРНєЕІ»ЖҐЕд
        public const int NET_DVR_LANGUAGE_ERROR = 81;//µјИлІОКэК±УпСФІ»ЖҐЕд
        public const int NET_DVR_PARAVERSION_ERROR = 82;//µјИлІОКэК±Инјю°ж±ѕІ»ЖҐЕд
        public const int NET_DVR_IPCHAN_NOTALIVE = 83; //Ф¤ААК±НвЅУIPНЁµАІ»ФЪПЯ
        public const int NET_DVR_RTSP_SDK_ERROR = 84;//јУФШёЯЗеIPCНЁС¶ївStreamTransClient.dllК§°Ь
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;//јУФШЧЄВлївК§°Ь
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;//і¬іцЧоґуµДipЅУИлНЁµАКэ

        public const int NET_PLAYM4_NOERROR = 500;//no error
        public const int NET_PLAYM4_PARA_OVER = 501;//input parameter is invalid
        public const int NET_PLAYM4_ORDER_ERROR = 502;//The order of the function to be called is error
        public const int NET_PLAYM4_TIMER_ERROR = 503;//Create multimedia clock failed
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;//Decode video data failed
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;//Decode audio data failed
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;//Allocate memory failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;//Open the file failed
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;//Create thread or event failed
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;//Create DirectDraw object failed
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;//failed when creating off-screen surface
        public const int NET_PLAYM4_BUF_OVER = 511;//buffer is overflow
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;//failed when creating audio device
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;//Set volume failed
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;//The function only support play file
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;//The function only support play stream
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;//System not support
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;//No file header
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;//The version of decoder and encoder is not adapted
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;//Initialize decoder failed
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;//The file data is unknown
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;//Initialize multimedia clock failed
        public const int NET_PLAYM4_BLT_ERROR = 522;//Blt failed
        public const int NET_PLAYM4_UPDATE_ERROR = 523;//Update failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;//openfile error, streamtype is multi
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;//openfile error, streamtype is video
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;//JPEG compress error
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;//Don't support the version of this file
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;//extract video data failed
        /*******************И«ѕЦґнОуВл end**********************/

        /*************************************************
        NET_DVR_IsSupport()·µ»ШЦµ
        1Ј­9О»·Ц±р±нКѕТФПВРЕПўЈЁО»УлКЗTRUE)±нКѕЦ§іЦЈ»
        **************************************************/
        public const int NET_DVR_SUPPORT_DDRAW = 1;//Ц§іЦDIRECTDRAWЈ¬Из№ыІ»Ц§іЦЈ¬ФтІҐ·ЕЖчІ»ДЬ№¤Чч
        public const int NET_DVR_SUPPORT_BLT = 2;//ПФїЁЦ§іЦBLTІЩЧчЈ¬Из№ыІ»Ц§іЦЈ¬ФтІҐ·ЕЖчІ»ДЬ№¤Чч
        public const int NET_DVR_SUPPORT_BLTFOURCC = 4;//ПФїЁBLTЦ§іЦСХЙ«ЧЄ»»Ј¬Из№ыІ»Ц§іЦЈ¬ІҐ·ЕЖч»бУГИнјю·Ѕ·ЁЧчRGBЧЄ»»
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;//ПФїЁBLTЦ§іЦXЦбЛхРЎЈ»Из№ыІ»Ц§іЦЈ¬ПµНі»бУГИнјю·Ѕ·ЁЧЄ»»
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;//ПФїЁBLTЦ§іЦYЦбЛхРЎЈ»Из№ыІ»Ц§іЦЈ¬ПµНі»бУГИнјю·Ѕ·ЁЧЄ»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;//ПФїЁBLTЦ§іЦXЦб·ЕґуЈ»Из№ыІ»Ц§іЦЈ¬ПµНі»бУГИнјю·Ѕ·ЁЧЄ»»
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;//ПФїЁBLTЦ§іЦYЦб·ЕґуЈ»Из№ыІ»Ц§іЦЈ¬ПµНі»бУГИнјю·Ѕ·ЁЧЄ»»
        public const int NET_DVR_SUPPORT_SSE = 128;//CPUЦ§іЦSSEЦёБоЈ¬Intel Pentium3ТФЙПЦ§іЦSSEЦёБо
        public const int NET_DVR_SUPPORT_MMX = 256;//CPUЦ§іЦMMXЦёБојЇЈ¬Intel Pentium3ТФЙПЦ§іЦSSEЦёБо

        /**********************ФЖМЁїШЦЖГьБо begin*************************/
        public const int LIGHT_PWRON = 2;// ЅУНЁµЖ№вµзФґ
        public const int WIPER_PWRON = 3;// ЅУНЁУкЛўїЄ№Ш 
        public const int FAN_PWRON = 4;// ЅУНЁ·зЙИїЄ№Ш
        public const int HEATER_PWRON = 5;// ЅУНЁјУИИЖчїЄ№Ш
        public const int AUX_PWRON1 = 6;// ЅУНЁёЁЦъЙи±ёїЄ№Ш
        public const int AUX_PWRON2 = 7;// ЅУНЁёЁЦъЙи±ёїЄ№Ш 
        public const int SET_PRESET = 8;// ЙиЦГФ¤ЦГµг 
        public const int CLE_PRESET = 9;// ЗеіэФ¤ЦГµг 

        public const int ZOOM_IN = 11;// Ѕ№ѕаТФЛЩ¶ИSS±дґу(±¶ВК±дґу)
        public const int ZOOM_OUT = 12;// Ѕ№ѕаТФЛЩ¶ИSS±дРЎ(±¶ВК±дРЎ)
        public const int FOCUS_NEAR = 13;// Ѕ№µгТФЛЩ¶ИSSЗ°µч 
        public const int FOCUS_FAR = 14;// Ѕ№µгТФЛЩ¶ИSSєуµч
        public const int IRIS_OPEN = 15;// №вИ¦ТФЛЩ¶ИSSА©ґу
        public const int IRIS_CLOSE = 16;// №вИ¦ТФЛЩ¶ИSSЛхРЎ 

        public const int TILT_UP = 21;/* ФЖМЁТФSSµДЛЩ¶ИЙПСц */
        public const int TILT_DOWN = 22;/* ФЖМЁТФSSµДЛЩ¶ИПВё© */
        public const int PAN_LEFT = 23;/* ФЖМЁТФSSµДЛЩ¶ИЧуЧЄ */
        public const int PAN_RIGHT = 24;/* ФЖМЁТФSSµДЛЩ¶ИУТЧЄ */
        public const int UP_LEFT = 25;/* ФЖМЁТФSSµДЛЩ¶ИЙПСцєНЧуЧЄ */
        public const int UP_RIGHT = 26;/* ФЖМЁТФSSµДЛЩ¶ИЙПСцєНУТЧЄ */
        public const int DOWN_LEFT = 27;/* ФЖМЁТФSSµДЛЩ¶ИПВё©єНЧуЧЄ */
        public const int DOWN_RIGHT = 28;/* ФЖМЁТФSSµДЛЩ¶ИПВё©єНУТЧЄ */
        public const int PAN_AUTO = 29;/* ФЖМЁТФSSµДЛЩ¶ИЧуУТЧФ¶ЇЙЁГи */

        public const int FILL_PRE_SEQ = 30;/* Ѕ«Ф¤ЦГµгјУИлСІєЅРтБР */
        public const int SET_SEQ_DWELL = 31;/* ЙиЦГСІєЅµгНЈ¶ЩК±јд */
        public const int SET_SEQ_SPEED = 32;/* ЙиЦГСІєЅЛЩ¶И */
        public const int CLE_PRE_SEQ = 33;/* Ѕ«Ф¤ЦГµгґУСІєЅРтБРЦРЙѕіэ */
        public const int STA_MEM_CRUISE = 34;/* їЄКјјЗВј№мјЈ */
        public const int STO_MEM_CRUISE = 35;/* НЈЦ№јЗВј№мјЈ */
        public const int RUN_CRUISE = 36;/* їЄКј№мјЈ */
        public const int RUN_SEQ = 37;/* їЄКјСІєЅ */
        public const int STOP_SEQ = 38;/* НЈЦ№СІєЅ */
        public const int GOTO_PRESET = 39;/* їмЗтЧЄµЅФ¤ЦГµг */
        /**********************ФЖМЁїШЦЖГьБо end*************************/

        /*************************************************
        »Ш·ЕК±ІҐ·ЕїШЦЖГьБоєк¶ЁТе 
        NET_DVR_PlayBackControl
        NET_DVR_PlayControlLocDisplay
        NET_DVR_DecPlayBackCtrlµДєк¶ЁТе
        ѕЯМеЦ§іЦІйїґєЇКэЛµГчєНґъВл
        **************************************************/
        public const int NET_DVR_PLAYSTART = 1;//їЄКјІҐ·Е
        public const int NET_DVR_PLAYSTOP = 2;//НЈЦ№ІҐ·Е
        public const int NET_DVR_PLAYPAUSE = 3;//ФЭНЈІҐ·Е
        public const int NET_DVR_PLAYRESTART = 4;//»ЦёґІҐ·Е
        public const int NET_DVR_PLAYFAST = 5;//їм·Е
        public const int NET_DVR_PLAYSLOW = 6;//Вэ·Е
        public const int NET_DVR_PLAYNORMAL = 7;//ХэіЈЛЩ¶И
        public const int NET_DVR_PLAYFRAME = 8;//µҐЦЎ·Е
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//ґтїЄЙщТф
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//№Ш±ХЙщТф
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//µчЅЪТфБї
        public const int NET_DVR_PLAYSETPOS = 12;//ёД±дОДјю»Ш·ЕµДЅш¶И
        public const int NET_DVR_PLAYGETPOS = 13;//»сИЎОДјю»Ш·ЕµДЅш¶И
        public const int NET_DVR_PLAYGETTIME = 14;//»сИЎµ±З°ТСѕ­ІҐ·ЕµДК±јд(°ґОДјю»Ш·ЕµДК±єтУРР§)
        public const int NET_DVR_PLAYGETFRAME = 15;//»сИЎµ±З°ТСѕ­ІҐ·ЕµДЦЎКэ(°ґОДјю»Ш·ЕµДК±єтУРР§)
        public const int NET_DVR_GETTOTALFRAMES = 16;//»сИЎµ±З°ІҐ·ЕОДјюЧЬµДЦЎКэ(°ґОДјю»Ш·ЕµДК±єтУРР§)
        public const int NET_DVR_GETTOTALTIME = 17;//»сИЎµ±З°ІҐ·ЕОДјюЧЬµДК±јд(°ґОДјю»Ш·ЕµДК±єтУРР§)
        public const int NET_DVR_THROWBFRAME = 20;//¶ЄBЦЎ
        public const int NET_DVR_SETSPEED = 24;//ЙиЦГВлБчЛЩ¶И
        public const int NET_DVR_KEEPALIVE = 25;//±ЈіЦУлЙи±ёµДРДМш(Из№ы»ШµчЧиИыЈ¬ЅЁТй2Гл·ўЛНТ»ґО)
        public const int NET_DVR_PLAYSETTIME = 26;//°ґѕш¶ФК±јд¶ЁО»
        public const int NET_DVR_PLAYGETTOTALLEN = 27;//»сИЎ°ґК±јд»Ш·Е¶ФУ¦К±јд¶ОДЪµДЛщУРОДјюµДЧЬі¤¶И
        public const int NET_DVR_PLAY_FORWARD = 29;//µ№·ЕЗР»»ОЄХэ·Е
        public const int NET_DVR_PLAY_REVERSE = 30;//Хэ·ЕЗР»»ОЄµ№·Е
        public const int NET_DVR_SET_TRANS_TYPE = 32;//ЙиЦГЧЄ·вЧ°АаРН
        public const int NET_DVR_PLAY_CONVERT = 33;//Хэ·ЕЗР»»ОЄµ№·Е

        //Ф¶іМ°ґјь¶ЁТеИзПВЈє
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;


        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT;/* №вИ¦+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN;/* №вИ¦- */
        public const int KEY_PTZ_AP2_STOP = 37;

        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A;/* ѕЫЅ№+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* ѕЫЅ№- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        public const int KEY_PTZ_B1_START = 40;/* ±д±¶+ */
        public const int KEY_PTZ_B1_STOP = 41;

        public const int KEY_PTZ_B2_START = 42;/* ±д±¶- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000РВФц
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /*************************ІОКэЕдЦГГьБо begin*******************************/
        //УГУЪNET_DVR_SetDVRConfigєНNET_DVR_GetDVRConfig,ЧўТвЖд¶ФУ¦µДЕдЦГЅб№№
        public const int NET_DVR_GET_DEVICECFG = 100;//»сИЎЙи±ёІОКэ
        public const int NET_DVR_SET_DEVICECFG = 101;//ЙиЦГЙи±ёІОКэ
        public const int NET_DVR_GET_NETCFG = 102;//»сИЎНшВзІОКэ
        public const int NET_DVR_SET_NETCFG = 103;//ЙиЦГНшВзІОКэ
        public const int NET_DVR_GET_PICCFG = 104;//»сИЎНјПуІОКэ
        public const int NET_DVR_SET_PICCFG = 105;//ЙиЦГНјПуІОКэ
        public const int NET_DVR_GET_COMPRESSCFG = 106;//»сИЎС№ЛхІОКэ
        public const int NET_DVR_SET_COMPRESSCFG = 107;//ЙиЦГС№ЛхІОКэ
        public const int NET_DVR_GET_RECORDCFG = 108;//»сИЎВјПсК±јдІОКэ
        public const int NET_DVR_SET_RECORDCFG = 109;//ЙиЦГВјПсК±јдІОКэ
        public const int NET_DVR_GET_DECODERCFG = 110;//»сИЎЅвВлЖчІОКэ
        public const int NET_DVR_SET_DECODERCFG = 111;//ЙиЦГЅвВлЖчІОКэ
        public const int NET_DVR_GET_RS232CFG = 112;//»сИЎ232ґ®їЪІОКэ
        public const int NET_DVR_SET_RS232CFG = 113;//ЙиЦГ232ґ®їЪІОКэ
        public const int NET_DVR_GET_ALARMINCFG = 114;//»сИЎ±ЁѕЇКдИлІОКэ
        public const int NET_DVR_SET_ALARMINCFG = 115;//ЙиЦГ±ЁѕЇКдИлІОКэ
        public const int NET_DVR_GET_ALARMOUTCFG = 116;//»сИЎ±ЁѕЇКдіцІОКэ
        public const int NET_DVR_SET_ALARMOUTCFG = 117;//ЙиЦГ±ЁѕЇКдіцІОКэ
        public const int NET_DVR_GET_TIMECFG = 118;//»сИЎDVRК±јд
        public const int NET_DVR_SET_TIMECFG = 119;//ЙиЦГDVRК±јд
        public const int NET_DVR_GET_PREVIEWCFG = 120;//»сИЎФ¤ААІОКэ
        public const int NET_DVR_SET_PREVIEWCFG = 121;//ЙиЦГФ¤ААІОКэ
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;//»сИЎКУЖµКдіцІОКэ
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;//ЙиЦГКУЖµКдіцІОКэ
        public const int NET_DVR_GET_USERCFG = 124;//»сИЎУГ»§ІОКэ
        public const int NET_DVR_SET_USERCFG = 125;//ЙиЦГУГ»§ІОКэ
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;//»сИЎТміЈІОКэ
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;//ЙиЦГТміЈІОКэ
        public const int NET_DVR_GET_ZONEANDDST = 128;//»сИЎК±ЗшєНПДК±ЦЖІОКэ
        public const int NET_DVR_SET_ZONEANDDST = 129;//ЙиЦГК±ЗшєНПДК±ЦЖІОКэ
        public const int NET_DVR_GET_SHOWSTRING = 130;//»сИЎµюјУЧЦ·ыІОКэ
        public const int NET_DVR_SET_SHOWSTRING = 131;//ЙиЦГµюјУЧЦ·ыІОКэ
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;//»сИЎКВјюґҐ·ўВјПсІОКэ
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;//ЙиЦГКВјюґҐ·ўВјПсІОКэ

        public const int NET_DVR_GET_AUXOUTCFG = 140;//»сИЎ±ЁѕЇґҐ·ўёЁЦъКдіцЙиЦГ(HSЙи±ёёЁЦъКдіц2006-02-28)
        public const int NET_DVR_SET_AUXOUTCFG = 141;//ЙиЦГ±ЁѕЇґҐ·ўёЁЦъКдіцЙиЦГ(HSЙи±ёёЁЦъКдіц2006-02-28)
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;//»сИЎ-sПµБРЛ«КдіцФ¤ААІОКэ(-sПµБРЛ«Кдіц2006-04-13)
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;//ЙиЦГ-sПµБРЛ«КдіцФ¤ААІОКэ(-sПµБРЛ«Кдіц2006-04-13)

        public const int NET_DVR_GET_PICCFG_EX = 200;//»сИЎНјПуІОКэ(SDK_V14А©Х№ГьБо)
        public const int NET_DVR_SET_PICCFG_EX = 201;//ЙиЦГНјПуІОКэ(SDK_V14А©Х№ГьБо)
        public const int NET_DVR_GET_USERCFG_EX = 202;//»сИЎУГ»§ІОКэ(SDK_V15А©Х№ГьБо)
        public const int NET_DVR_SET_USERCFG_EX = 203;//ЙиЦГУГ»§ІОКэ(SDK_V15А©Х№ГьБо)
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;//»сИЎС№ЛхІОКэ(SDK_V15А©Х№ГьБо2006-05-15)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;//ЙиЦГС№ЛхІОКэ(SDK_V15А©Х№ГьБо2006-05-15)

        public const int NET_DVR_GET_NETAPPCFG = 222;//»сИЎНшВзУ¦УГІОКэ NTP/DDNS/EMAIL
        public const int NET_DVR_SET_NETAPPCFG = 223;//ЙиЦГНшВзУ¦УГІОКэ NTP/DDNS/EMAIL
        public const int NET_DVR_GET_NTPCFG = 224;//»сИЎНшВзУ¦УГІОКэ NTP
        public const int NET_DVR_SET_NTPCFG = 225;//ЙиЦГНшВзУ¦УГІОКэ NTP
        public const int NET_DVR_GET_DDNSCFG = 226;//»сИЎНшВзУ¦УГІОКэ DDNS
        public const int NET_DVR_SET_DDNSCFG = 227;//ЙиЦГНшВзУ¦УГІОКэ DDNS
        //¶ФУ¦NET_DVR_EMAILPARA
        public const int NET_DVR_GET_EMAILCFG = 228;//»сИЎНшВзУ¦УГІОКэ EMAIL
        public const int NET_DVR_SET_EMAILCFG = 229;//ЙиЦГНшВзУ¦УГІОКэ EMAIL

        public const int NET_DVR_GET_NFSCFG = 230;/* NFS disk config */
        public const int NET_DVR_SET_NFSCFG = 231;/* NFS disk config */

        public const int NET_DVR_GET_SHOWSTRING_EX = 238;//»сИЎµюјУЧЦ·ыІОКэА©Х№(Ц§іЦ8МхЧЦ·ы)
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;//ЙиЦГµюјУЧЦ·ыІОКэА©Х№(Ц§іЦ8МхЧЦ·ы)
        public const int NET_DVR_GET_NETCFG_OTHER = 244;//»сИЎНшВзІОКэ
        public const int NET_DVR_SET_NETCFG_OTHER = 245;//ЙиЦГНшВзІОКэ

        //¶ФУ¦NET_DVR_EMAILCFGЅб№№
        public const int NET_DVR_GET_EMAILPARACFG = 250;//Get EMAIL parameters
        public const int NET_DVR_SET_EMAILPARACFG = 251;//Setup EMAIL parameters

        public const int NET_DVR_GET_DDNSCFG_EX = 274;//»сИЎА©Х№DDNSІОКэ
        public const int NET_DVR_SET_DDNSCFG_EX = 275;//ЙиЦГА©Х№DDNSІОКэ

        public const int NET_DVR_SET_PTZPOS = 292;//ФЖМЁЙиЦГPTZО»ЦГ
        public const int NET_DVR_GET_PTZPOS = 293;//ФЖМЁ»сИЎPTZО»ЦГ
        public const int NET_DVR_GET_PTZSCOPE = 294;//ФЖМЁ»сИЎPTZ·¶О§

        public const int NET_DVR_GET_AP_INFO_LIST = 305;//»сИЎОЮПЯНшВзЧКФґІОКэ
        public const int NET_DVR_SET_WIFI_CFG = 306;//ЙиЦГIPјаїШЙи±ёОЮПЯІОКэ
        public const int NET_DVR_GET_WIFI_CFG = 307;//»сИЎIPјаїШЙи±ёОЮПЯІОКэ
        public const int NET_DVR_SET_WIFI_WORKMODE = 308;//ЙиЦГIPјаїШЙи±ёНшїЪ№¤ЧчДЈКЅІОКэ
        public const int NET_DVR_GET_WIFI_WORKMODE = 309;//»сИЎIPјаїШЙи±ёНшїЪ№¤ЧчДЈКЅІОКэ 
        public const int NET_DVR_GET_WIFI_STATUS = 310;	//»сИЎЙи±ёµ±З°wifiБ¬ЅУЧґМ¬
        /***************************DS9000РВФцГьБо(_V30) begin *****************************/
        //НшВз(NET_DVR_NETCFG_V30Ѕб№№)
        public const int NET_DVR_GET_NETCFG_V30 = 1000;//»сИЎНшВзІОКэ
        public const int NET_DVR_SET_NETCFG_V30 = 1001;//ЙиЦГНшВзІОКэ

        //НјПу(NET_DVR_PICCFG_V30Ѕб№№)
        public const int NET_DVR_GET_PICCFG_V30 = 1002;//»сИЎНјПуІОКэ
        public const int NET_DVR_SET_PICCFG_V30 = 1003;//ЙиЦГНјПуІОКэ

        //ВјПсК±јд(NET_DVR_RECORD_V30Ѕб№№)
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;//»сИЎВјПсІОКэ
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;//ЙиЦГВјПсІОКэ

        //УГ»§(NET_DVR_USER_V30Ѕб№№)
        public const int NET_DVR_GET_USERCFG_V30 = 1006;//»сИЎУГ»§ІОКэ
        public const int NET_DVR_SET_USERCFG_V30 = 1007;//ЙиЦГУГ»§ІОКэ

        //9000DDNSІОКэЕдЦГ(NET_DVR_DDNSPARA_V30Ѕб№№)
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;//»сИЎDDNS(9000А©Х№)
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;//ЙиЦГDDNS(9000А©Х№)

        //EMAIL№¦ДЬ(NET_DVR_EMAILCFG_V30Ѕб№№)
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;//»сИЎEMAILІОКэ 
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;//ЙиЦГEMAILІОКэ 

        //СІєЅІОКэ (NET_DVR_CRUISE_PARAЅб№№)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;

        //±ЁѕЇКдИлЅб№№ІОКэ (NET_DVR_ALARMINCFG_V30Ѕб№№)
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

        //±ЁѕЇКдіцЅб№№ІОКэ (NET_DVR_ALARMOUTCFG_V30Ѕб№№)
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

        //КУЖµКдіцЅб№№ІОКэ (NET_DVR_VIDEOOUT_V30Ѕб№№)
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

        //µюјУЧЦ·ыЅб№№ІОКэ (NET_DVR_SHOWSTRING_V30Ѕб№№)
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

        //ТміЈЅб№№ІОКэ (NET_DVR_EXCEPTION_V30Ѕб№№)
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        //ґ®їЪ232Ѕб№№ІОКэ (NET_DVR_RS232CFG_V30Ѕб№№)
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;

        //НшВзУІЕМЅУИлЅб№№ІОКэ (NET_DVR_NET_DISKCFGЅб№№)
        public const int NET_DVR_GET_NET_DISKCFG = 1038;//НшВзУІЕМЅУИл»сИЎ
        public const int NET_DVR_SET_NET_DISKCFG = 1039;//НшВзУІЕМЅУИлЙиЦГ

        //С№ЛхІОКэ (NET_DVR_COMPRESSIONCFG_V30Ѕб№№)
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

        //»сИЎ485ЅвВлЖчІОКэ (NET_DVR_DECODERCFG_V30Ѕб№№)
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;//»сИЎЅвВлЖчІОКэ
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;//ЙиЦГЅвВлЖчІОКэ

        //»сИЎФ¤ААІОКэ (NET_DVR_PREVIEWCFG_V30Ѕб№№)
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;//»сИЎФ¤ААІОКэ
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;//ЙиЦГФ¤ААІОКэ

        //ёЁЦъФ¤ААІОКэ (NET_DVR_PREVIEWCFG_AUX_V30Ѕб№№)
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;//»сИЎёЁЦъФ¤ААІОКэ
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;//ЙиЦГёЁЦъФ¤ААІОКэ

        //IPЅУИлЕдЦГІОКэ ЈЁNET_DVR_IPPARACFGЅб№№Ј©
        public const int NET_DVR_GET_IPPARACFG = 1048; //»сИЎIPЅУИлЕдЦГРЕПў 
        public const int NET_DVR_SET_IPPARACFG = 1049;//ЙиЦГIPЅУИлЕдЦГРЕПў

        //IPЅУИлЕдЦГІОКэ ЈЁNET_DVR_IPPARACFG_V40Ѕб№№Ј©
        public const int NET_DVR_GET_IPPARACFG_V40 = 1062; //»сИЎIPЅУИлЕдЦГРЕПў 
        public const int NET_DVR_SET_IPPARACFG_V40 = 1063;//ЙиЦГIPЅУИлЕдЦГРЕПў

        //IP±ЁѕЇКдИлЅУИлЕдЦГІОКэ ЈЁNET_DVR_IPALARMINCFGЅб№№Ј©
        public const int NET_DVR_GET_IPALARMINCFG = 1050; //»сИЎIP±ЁѕЇКдИлЅУИлЕдЦГРЕПў 
        public const int NET_DVR_SET_IPALARMINCFG = 1051; //ЙиЦГIP±ЁѕЇКдИлЅУИлЕдЦГРЕПў

        //IP±ЁѕЇКдіцЅУИлЕдЦГІОКэ ЈЁNET_DVR_IPALARMOUTCFGЅб№№Ј©
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;//»сИЎIP±ЁѕЇКдіцЅУИлЕдЦГРЕПў 
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;//ЙиЦГIP±ЁѕЇКдіцЅУИлЕдЦГРЕПў

        //УІЕМ№ЬАнµДІОКэ»сИЎ (NET_DVR_HDCFGЅб№№)
        public const int NET_DVR_GET_HDCFG = 1054;//»сИЎУІЕМ№ЬАнЕдЦГІОКэ
        public const int NET_DVR_SET_HDCFG = 1055;//ЙиЦГУІЕМ№ЬАнЕдЦГІОКэ

        //ЕМЧй№ЬАнµДІОКэ»сИЎ (NET_DVR_HDGROUP_CFGЅб№№)
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;//»сИЎЕМЧй№ЬАнЕдЦГІОКэ
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;//ЙиЦГЕМЧй№ЬАнЕдЦГІОКэ

        //Йи±ё±аВлАаРНЕдЦГ(NET_DVR_COMPRESSION_AUDIOЅб№№)
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;//»сИЎЙи±ёУпТф¶ФЅІ±аВлІОКэ
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;//ЙиЦГЙи±ёУпТф¶ФЅІ±аВлІОКэ

        //IPЅУИлЕдЦГІОКэ ЈЁNET_DVR_IPPARACFG_V31Ѕб№№Ј©
        public const int NET_DVR_GET_IPPARACFG_V31 = 1060;//»сИЎIPЅУИлЕдЦГРЕПў 
        public const int NET_DVR_SET_IPPARACFG_V31 = 1061; //ЙиЦГIPЅУИлЕдЦГРЕПў

        //Йи±ёІОКэЕдЦГ ЈЁNET_DVR_DEVICECFG_V40Ѕб№№Ј©
        public const int NET_DVR_GET_DEVICECFG_V40 = 1100;//»сИЎЙи±ёІОКэ
        public const int NET_DVR_SET_DEVICECFG_V40 = 1101;//ЙиЦГЙи±ёІОКэ

        //¶аНшїЁЕдЦГ(NET_DVR_NETCFG_MULTIЅб№№)
        public const int NET_DVR_GET_NETCFG_MULTI = 1161;
        public const int NET_DVR_SET_NETCFG_MULTI = 1162;

        //BONDINGНшїЁ(NET_DVR_NETWORK_BONDINGЅб№№)
        public const int NET_DVR_GET_NETWORK_BONDING = 1254;
        public const int NET_DVR_SET_NETWORK_BONDING = 1255;

        //NATУіЙдЕдЦГІОКэ ЈЁNET_DVR_NAT_CFGЅб№№Ј©
        public const int NET_DVR_GET_NAT_CFG = 6111;    //»сИЎNATУіЙдІОКэ
        public const int NET_DVR_SET_NAT_CFG = 6112;    //ЙиЦГNATУіЙдІОКэ  
        /*************************ІОКэЕдЦГГьБо end*******************************/

        /************************DVRИХЦѕ begin***************************/
        /* ±ЁѕЇ */
        //ЦчАаРН
        public const int MAJOR_ALARM = 1;
        //ґОАаРН
        public const int MINOR_ALARM_IN = 1;/* ±ЁѕЇКдИл */
        public const int MINOR_ALARM_OUT = 2;/* ±ЁѕЇКдіц */
        public const int MINOR_MOTDET_START = 3; /* ТЖ¶ЇХмІв±ЁѕЇїЄКј */
        public const int MINOR_MOTDET_STOP = 4; /* ТЖ¶ЇХмІв±ЁѕЇЅбКш */
        public const int MINOR_HIDE_ALARM_START = 5;/* ХЪµІ±ЁѕЇїЄКј */
        public const int MINOR_HIDE_ALARM_STOP = 6;/* ХЪµІ±ЁѕЇЅбКш */
        public const int MINOR_VCA_ALARM_START = 7;/*ЦЗДЬ±ЁѕЇїЄКј*/
        public const int MINOR_VCA_ALARM_STOP = 8;/*ЦЗДЬ±ЁѕЇНЈЦ№*/

        /* ТміЈ */
        //ЦчАаРН
        public const int MAJOR_EXCEPTION = 2;
        //ґОАаРН
        public const int MINOR_VI_LOST = 33;/* КУЖµРЕєЕ¶ЄК§ */
        public const int MINOR_ILLEGAL_ACCESS = 34;/* ·З·Ё·ГОК */
        public const int MINOR_HD_FULL = 35;/* УІЕМВъ */
        public const int MINOR_HD_ERROR = 36;/* УІЕМґнОу */
        public const int MINOR_DCD_LOST = 37;/* MODEM µфПЯ(±ЈБфІ»К№УГ) */
        public const int MINOR_IP_CONFLICT = 38;/* IPµШЦ·іеН» */
        public const int MINOR_NET_BROKEN = 39;/* НшВз¶ПїЄ*/
        public const int MINOR_REC_ERROR = 40;/* ВјПсіцґн */
        public const int MINOR_IPC_NO_LINK = 41;/* IPCБ¬ЅУТміЈ */
        public const int MINOR_VI_EXCEPTION = 42;/* КУЖµКдИлТміЈ(Ц»Хл¶ФДЈДвНЁµА) */
        public const int MINOR_IPC_IP_CONFLICT = 43;/*ipc ip µШЦ· іеН»*/

        //КУЖµЧЫєПЖЅМЁ
        public const int MINOR_FANABNORMAL = 49;/* КУЖµЧЫєПЖЅМЁЈє·зЙИЧґМ¬ТміЈ */
        public const int MINOR_FANRESUME = 50;/* КУЖµЧЫєПЖЅМЁЈє·зЙИЧґМ¬»ЦёґХэіЈ */
        public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;/* КУЖµЧЫєПЖЅМЁЈє6467ТміЈЦШЖф */
        public const int MINOR_MATRIX_STARTBUZZER = 52;/* КУЖµЧЫєПЖЅМЁЈєdm6467ТміЈЈ¬Жф¶Ї·дГщЖч */

        /* ІЩЧч */
        //ЦчАаРН
        public const int MAJOR_OPERATION = 3;
        //ґОАаРН
        public const int MINOR_START_DVR = 65;/* їЄ»ъ */
        public const int MINOR_STOP_DVR = 66;/* №Ш»ъ */
        public const int MINOR_STOP_ABNORMAL = 67;/* ТміЈ№Ш»ъ */
        public const int MINOR_REBOOT_DVR = 68;/*±ѕµШЦШЖфЙи±ё*/

        public const int MINOR_LOCAL_LOGIN = 80;/* ±ѕµШµЗВЅ */
        public const int MINOR_LOCAL_LOGOUT = 81;/* ±ѕµШЧўПъµЗВЅ */
        public const int MINOR_LOCAL_CFG_PARM = 82;/* ±ѕµШЕдЦГІОКэ */
        public const int MINOR_LOCAL_PLAYBYFILE = 83;/* ±ѕµШ°ґОДјю»Ш·Е»тПВФШ */
        public const int MINOR_LOCAL_PLAYBYTIME = 84;/* ±ѕµШ°ґК±јд»Ш·Е»тПВФШ*/
        public const int MINOR_LOCAL_START_REC = 85;/* ±ѕµШїЄКјВјПс */
        public const int MINOR_LOCAL_STOP_REC = 86;/* ±ѕµШНЈЦ№ВјПс */
        public const int MINOR_LOCAL_PTZCTRL = 87;/* ±ѕµШФЖМЁїШЦЖ */
        public const int MINOR_LOCAL_PREVIEW = 88;/* ±ѕµШФ¤АА (±ЈБфІ»К№УГ)*/
        public const int MINOR_LOCAL_MODIFY_TIME = 89;/* ±ѕµШРЮёДК±јд(±ЈБфІ»К№УГ) */
        public const int MINOR_LOCAL_UPGRADE = 90;/* ±ѕµШЙэј¶ */
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;/* ±ѕµШ±ё·ЭВјПуОДјю */
        public const int MINOR_LOCAL_FORMAT_HDD = 92;/* ±ѕµШіхКј»ЇУІЕМ */
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;/* µјіц±ѕµШЕдЦГОДјю */
        public const int MINOR_LOCAL_CFGFILE_INPUT = 94;/* µјИл±ѕµШЕдЦГОДјю */
        public const int MINOR_LOCAL_COPYFILE = 95;/* ±ѕµШ±ё·ЭОДјю */
        public const int MINOR_LOCAL_LOCKFILE = 96;/* ±ѕµШЛш¶ЁВјПсОДјю */
        public const int MINOR_LOCAL_UNLOCKFILE = 97;/* ±ѕµШЅвЛшВјПсОДјю */
        public const int MINOR_LOCAL_DVR_ALARM = 98;/* ±ѕµШКЦ¶ЇЗеіэєНґҐ·ў±ЁѕЇ*/
        public const int MINOR_IPC_ADD = 99;/* ±ѕµШМнјУIPC */
        public const int MINOR_IPC_DEL = 100;/* ±ѕµШЙѕіэIPC */
        public const int MINOR_IPC_SET = 101;/* ±ѕµШЙиЦГIPC */
        public const int MINOR_LOCAL_START_BACKUP = 102;/* ±ѕµШїЄКј±ё·Э */
        public const int MINOR_LOCAL_STOP_BACKUP = 103;/* ±ѕµШНЈЦ№±ё·Э*/
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;/* ±ѕµШ±ё·ЭїЄКјК±јд*/
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;/* ±ѕµШ±ё·ЭЅбКшК±јд*/
        public const int MINOR_LOCAL_ADD_NAS = 106;/*±ѕµШМнјУНшВзУІЕМ*/
        public const int MINOR_LOCAL_DEL_NAS = 107;/* ±ѕµШЙѕіэnasЕМ*/
        public const int MINOR_LOCAL_SET_NAS = 108;/* ±ѕµШЙиЦГnasЕМ*/

        public const int MINOR_REMOTE_LOGIN = 112;/* Ф¶іМµЗВј */
        public const int MINOR_REMOTE_LOGOUT = 113;/* Ф¶іМЧўПъµЗВЅ */
        public const int MINOR_REMOTE_START_REC = 114;/* Ф¶іМїЄКјВјПс */
        public const int MINOR_REMOTE_STOP_REC = 115;/* Ф¶іМНЈЦ№ВјПс */
        public const int MINOR_START_TRANS_CHAN = 116;/* їЄКјНёГчґ«Кд */
        public const int MINOR_STOP_TRANS_CHAN = 117;/* НЈЦ№НёГчґ«Кд */
        public const int MINOR_REMOTE_GET_PARM = 118;/* Ф¶іМ»сИЎІОКэ */
        public const int MINOR_REMOTE_CFG_PARM = 119;/* Ф¶іМЕдЦГІОКэ */
        public const int MINOR_REMOTE_GET_STATUS = 120;/* Ф¶іМ»сИЎЧґМ¬ */
        public const int MINOR_REMOTE_ARM = 121;/* Ф¶іМІј·А */
        public const int MINOR_REMOTE_DISARM = 122;/* Ф¶іМі··А */
        public const int MINOR_REMOTE_REBOOT = 123;/* Ф¶іМЦШЖф */
        public const int MINOR_START_VT = 124;/* їЄКјУпТф¶ФЅІ */
        public const int MINOR_STOP_VT = 125;/* НЈЦ№УпТф¶ФЅІ */
        public const int MINOR_REMOTE_UPGRADE = 126;/* Ф¶іМЙэј¶ */
        public const int MINOR_REMOTE_PLAYBYFILE = 127;/* Ф¶іМ°ґОДјю»Ш·Е */
        public const int MINOR_REMOTE_PLAYBYTIME = 128;/* Ф¶іМ°ґК±јд»Ш·Е */
        public const int MINOR_REMOTE_PTZCTRL = 129;/* Ф¶іМФЖМЁїШЦЖ */
        public const int MINOR_REMOTE_FORMAT_HDD = 130;/* Ф¶іМёсКЅ»ЇУІЕМ */
        public const int MINOR_REMOTE_STOP = 131;/* Ф¶іМ№Ш»ъ */
        public const int MINOR_REMOTE_LOCKFILE = 132;/* Ф¶іМЛш¶ЁОДјю */
        public const int MINOR_REMOTE_UNLOCKFILE = 133;/* Ф¶іМЅвЛшОДјю */
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;/* Ф¶іМµјіцЕдЦГОДјю */
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;/* Ф¶іМµјИлЕдЦГОДјю */
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;/* Ф¶іМµјіцВјПуОДјю */
        public const int MINOR_REMOTE_DVR_ALARM = 137;/* Ф¶іМКЦ¶ЇЗеіэєНґҐ·ў±ЁѕЇ*/
        public const int MINOR_REMOTE_IPC_ADD = 138;/* Ф¶іММнјУIPC */
        public const int MINOR_REMOTE_IPC_DEL = 139;/* Ф¶іМЙѕіэIPC */
        public const int MINOR_REMOTE_IPC_SET = 140;/* Ф¶іМЙиЦГIPC */
        public const int MINOR_REBOOT_VCA_LIB = 141;/*ЦШЖфЦЗДЬїв*/
        public const int MINOR_REMOTE_ADD_NAS = 142;/* Ф¶іММнјУnasЕМ*/
        public const int MINOR_REMOTE_DEL_NAS = 143;/* Ф¶іМЙѕіэnasЕМ*/
        public const int MINOR_REMOTE_SET_NAS = 144;/* Ф¶іМЙиЦГnasЕМ*/

        //2009-12-16 ФцјУКУЖµЧЫєПЖЅМЁИХЦѕАаРН
        public const int MINOR_SUBSYSTEMREBOOT = 160;/*КУЖµЧЫєПЖЅМЁЈєdm6467 ХэіЈЦШЖф*/
        public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;	/*КУЖµЧЫєПЖЅМЁЈєѕШХуЗР»»їЄКјґ«КдНјПс*/
        public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;	/*КУЖµЧЫєПЖЅМЁЈєѕШХуЗР»»НЈЦ№ґ«КдНјПс*/
        public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;	/*КУЖµЧЫєПЖЅМЁЈєЙиЦГЛщУР6467ЧУПµНіРЕПў*/
        public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;	/*КУЖµЧЫєПЖЅМЁЈє»сИЎЛщУР6467ЧУПµНіРЕПў*/
        public const int MINOR_REMOTE_SET_PLANARRAY = 165;	/*КУЖµЧЫєПЖЅМЁЈєЙиЦГјЖ»®ВЦСЇЧй*/
        public const int MINOR_REMOTE_GET_PLANARRAY = 166;	/*КУЖµЧЫєПЖЅМЁЈє»сИЎјЖ»®ВЦСЇЧй*/
        public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;	/*КУЖµЧЫєПЖЅМЁЈєѕШХуЗР»»їЄКјґ«КдТфЖµ*/
        public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;	/*КУЖµЧЫєПЖЅМЁЈєѕШХуЗР»»НЈЦ№ґ«КдТфЖµ*/
        public const int MINOR_LOGON_CODESPITTER = 169;	/*КУЖµЧЫєПЖЅМЁЈєµЗВЅВл·ЦЖч*/
        public const int MINOR_LOGOFF_CODESPITTER = 170;	/*КУЖµЧЫєПЖЅМЁЈєНЛіцВл·ЦЖч*/

        /*ИХЦѕёЅјУРЕПў*/
        //ЦчАаРН
        public const int MAJOR_INFORMATION = 4;/*ёЅјУРЕПў*/
        //ґОАаРН
        public const int MINOR_HDD_INFO = 161;/*УІЕМРЕПў*/
        public const int MINOR_SMART_INFO = 162;/*SMARTРЕПў*/
        public const int MINOR_REC_START = 163;/*їЄКјВјПс*/
        public const int MINOR_REC_STOP = 164;/*НЈЦ№ВјПс*/
        public const int MINOR_REC_OVERDUE = 165;/*№эЖЪВјПсЙѕіэ*/
        public const int MINOR_LINK_START = 166;//Б¬ЅУЗ°¶ЛЙи±ё
        public const int MINOR_LINK_STOP = 167;//¶ПїЄЗ°¶ЛЙи±ёЎЎ
        public const int MINOR_NET_DISK_INFO = 168;//НшВзУІЕМРЕПў

        //µ±ИХЦѕµДЦчАаРНОЄMAJOR_OPERATION=03Ј¬ґОАаРНОЄMINOR_LOCAL_CFG_PARM=0x52»тХЯMINOR_REMOTE_GET_PARM=0x76»тХЯMINOR_REMOTE_CFG_PARM=0x77К±Ј¬dwParaType:ІОКэАаРНУРР§Ј¬Ждє¬ТеИзПВЈє
        public const int PARA_VIDEOOUT = 1;
        public const int PARA_IMAGE = 2;
        public const int PARA_ENCODE = 4;
        public const int PARA_NETWORK = 8;
        public const int PARA_ALARM = 16;
        public const int PARA_EXCEPTION = 32;
        public const int PARA_DECODER = 64;/*ЅвВлЖч*/
        public const int PARA_RS232 = 128;
        public const int PARA_PREVIEW = 256;
        public const int PARA_SECURITY = 512;
        public const int PARA_DATETIME = 1024;
        public const int PARA_FRAMETYPE = 2048;/*ЦЎёсКЅ*/
        //vca
        public const int PARA_VCA_RULE = 4096;//РРОЄ№жФт
        /************************DVRИХЦѕ End***************************/


        /*******************ІйХТОДјюєНИХЦѕєЇКэ·µ»ШЦµ*************************/
        public const int NET_DVR_FILE_SUCCESS = 1000;//»сµГОДјюРЕПў
        public const int NET_DVR_FILE_NOFIND = 1001;//Г»УРОДјю
        public const int NET_DVR_ISFINDING = 1002;//ХэФЪІйХТОДјю
        public const int NET_DVR_NOMOREFILE = 1003;//ІйХТОДјюК±Г»УРёь¶аµДОДјю
        public const int NET_DVR_FILE_EXCEPTION = 1004;//ІйХТОДјюК±ТміЈ

        /*********************»ШµчєЇКэАаРН begin************************/
        public const int COMM_ALARM = 0x1100;//8000±ЁѕЇРЕПўЦч¶ЇЙПґ«Ј¬¶ФУ¦NET_DVR_ALARMINFO
        public const int COMM_ALARM_RULE = 0x1102;//РРОЄ·ЦОц±ЁѕЇРЕПўЈ¬¶ФУ¦NET_VCA_RULE_ALARM
        public const int COMM_ALARM_PDC = 0x1103;//ИЛБчБїНіјЖ±ЁѕЇЙПґ«Ј¬¶ФУ¦NET_DVR_PDC_ALRAM_INFO
        public const int COMM_ALARM_ALARMHOST = 0x1105;//НшВз±ЁѕЇЦч»ъ±ЁѕЇЙПґ«Ј¬¶ФУ¦NET_DVR_ALARMHOST_ALARMINFO
        public const int COMM_ALARM_FACE = 0x1106;//ИЛБіјмІвК¶±р±ЁѕЇРЕПўЈ¬¶ФУ¦NET_DVR_FACEDETECT_ALARM
        public const int COMM_RULE_INFO_UPLOAD = 0x1107;  // КВјюКэѕЭРЕПўЙПґ«
        public const int COMM_ALARM_AID = 0x1110;  //Ѕ»НЁКВјю±ЁѕЇРЕПў
        public const int COMM_ALARM_TPS = 0x1111;  //Ѕ»НЁІОКэНіјЖ±ЁѕЇРЕПў
        public const int COMM_UPLOAD_FACESNAP_RESULT = 0x1112;  //ИЛБіК¶±рЅб№ыЙПґ«
        public const int COMM_ALARM_TFS = 0x1113;  //Ѕ»НЁИЎЦ¤±ЁѕЇРЕПў
        public const int COMM_ALARM_TPS_V41 = 0x1114;  //Ѕ»НЁІОКэНіјЖ±ЁѕЇРЕПўА©Х№
        public const int COMM_ALARM_AID_V41 = 0x1115;  //Ѕ»НЁКВјю±ЁѕЇРЕПўА©Х№
        public const int COMM_ALARM_VQD_EX =  0x1116;	 //КУЖµЦКБїХп¶П±ЁѕЇ
        public const int COMM_SENSOR_VALUE_UPLOAD = 0x1120;  //ДЈДвБїКэѕЭКµК±ЙПґ«
        public const int COMM_SENSOR_ALARM  = 0x1121;  //ДЈДвБї±ЁѕЇЙПґ«
        public const int COMM_SWITCH_ALARM   = 0x1122;	 //їЄ№ШБї±ЁѕЇ
        public const int COMM_ALARMHOST_EXCEPTION   =  0x1123; //±ЁѕЇЦч»ъ№КХП±ЁѕЇ
        public const int COMM_ALARMHOST_OPERATEEVENT_ALARM  = 0x1124;  //ІЩЧчКВјю±ЁѕЇЙПґ«
        public const int COMM_ALARMHOST_SAFETYCABINSTATE = 0x1125;	 //·А»¤ІХЧґМ¬
        public const int COMM_ALARMHOST_ALARMOUTSTATUS  = 0x1126;	 //±ЁѕЇКдіцїЪ/ѕЇєЕЧґМ¬
        public const int COMM_ALARMHOST_CID_ALARM 	 = 0x1127;	 //±Ёёж±ЁѕЇЙПґ«
        public const int COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM = 0x1128;	 //±ЁѕЇЦч»ъНвЅУЙи±ё±ЁѕЇЙПґ«
        public const int COMM_ALARMHOST_DATA_UPLOAD    = 0x1129;	 //±ЁѕЇКэѕЭЙПґ«
        public const int COMM_ALARM_AUDIOEXCEPTION	 =  0x1150;	 //ЙщТф±ЁѕЇРЕПў
        public const int COMM_ALARM_DEFOCUS    =      0x1151;	 //РйЅ№±ЁѕЇРЕПў
        public const int COMM_ALARM_BUTTON_DOWN_EXCEPTION =  0x1152;	 //°ґЕҐ°ґПВ±ЁѕЇРЕПў
        public const int COMM_ALARM_ALARMGPS   =    0x1202; //GPS±ЁѕЇРЕПўЙПґ«
        public const int COMM_TRADEINFO      =  0x1500;  //ATMDVRЦч¶ЇЙПґ«Ѕ»ТЧРЕПў
        public const int COMM_UPLOAD_PLATE_RESULT  =   0x2800;	 //ЙПґ«іµЕЖРЕПў
        public const int COMM_ITC_STATUS_DETECT_RESULT  = 0x2810;  //КµК±ЧґМ¬јмІвЅб№ыЙПґ«(ЦЗДЬёЯЗеIPC)
        public const int COMM_IPC_AUXALARM_RESULT  = 0x2820;  //PIR±ЁѕЇЎўОЮПЯ±ЁѕЇЎўєфѕИ±ЁѕЇЙПґ«
        public const int COMM_UPLOAD_PICTUREINFO    = 0x2900;	 //ЙПґ«НјЖ¬РЕПў
        public const int COMM_SNAP_MATCH_ALARM   = 0x2902;  //єЪГыµҐ±И¶ФЅб№ыЙПґ«
        public const int COMM_ITS_PLATE_RESULT   =  0x3050;  //ЦХ¶ЛНјЖ¬ЙПґ«
        public const int COMM_ITS_TRAFFIC_COLLECT  = 0x3051;  //ЦХ¶ЛНіјЖКэѕЭЙПґ«
        public const int COMM_ITS_GATE_VEHICLE = 0x3052;  //іцИлїЪіµБѕЧҐЕДКэѕЭЙПґ«
        public const int COMM_ITS_GATE_FACE  = 0x3053 ; //іцИлїЪИЛБіЧҐЕДКэѕЭЙПґ«
        public const int COMM_ITS_GATE_COSTITEM = 0x3054;  //іцИлїЪ№эіµКХ·СГчПё 2013-11-19
        public const int COMM_ITS_GATE_HANDOVER = 0x3055 ; //іцИлїЪЅ»ЅУ°аКэѕЭ 2013-11-19
        public const int COMM_ITS_PARK_VEHICLE  = 0x3056;  //НЈіµіЎКэѕЭЙПґ«
        public const int COMM_ITS_BLACKLIST_ALARM  = 0x3057;  //єЪГыµҐ±ЁѕЇЙПґ«
        public const int COMM_ALARM_V30	 =  0x4000;	 //9000±ЁѕЇРЕПўЦч¶ЇЙПґ«
        public const int COMM_IPCCFG	 =  0x4001;	 //9000Йи±ёIPCЅУИлЕдЦГёД±д±ЁѕЇРЕПўЦч¶ЇЙПґ«
        public const int COMM_IPCCFG_V31 = 0x4002;	 //9000Йи±ёIPCЅУИлЕдЦГёД±д±ЁѕЇРЕПўЦч¶ЇЙПґ«А©Х№ 9000_1.1
        public const int COMM_IPCCFG_V40 =  0x4003; // IVMS 2000 ±аВл·юОсЖч NVR IPCЅУИлЕдЦГёД±дК±±ЁѕЇРЕПўЙПґ«
        public const int COMM_ALARM_DEVICE = 0x4004;  //Йи±ё±ЁѕЇДЪИЭЈ¬УЙУЪНЁµАЦµґуУЪ256¶шА©Х№
        public const int COMM_ALARM_CVR	 =  0x4005;  //CVR 2.0.XНвІї±ЁѕЇАаРН
        public const int COMM_ALARM_HOT_SPARE = 0x4006;  //ИИ±ёТміЈ±ЁѕЇЈЁN+1ДЈКЅТміЈ±ЁѕЇЈ©
        public const int COMM_ALARM_V40 = 0x4007;	//ТЖ¶ЇХмІвЈ¬КУЖµ¶ЄК§Ј¬ХЪµІЈ¬IOРЕєЕБїµИ±ЁѕЇРЕПўЦч¶ЇЙПґ«Ј¬±ЁѕЇКэѕЭОЄїЙ±ді¤

        public const int COMM_ITS_ROAD_EXCEPTION = 0x4500;	 //В·їЪЙи±ёТміЈ±ЁѕЇ
        public const int COMM_ITS_EXTERNAL_CONTROL_ALARM = 0x4520;  //НвїШ±ЁѕЇ
        public const int COMM_SCREEN_ALARM    =  0x5000;  //¶аЖБїШЦЖЖч±ЁѕЇАаРН
        public const int COMM_DVCS_STATE_ALARM = 0x5001;  //·ЦІјКЅґуЖБїШЦЖЖч±ЁѕЇЙПґ«
        public const int COMM_ALARM_VQD		 = 0x6000;  //VQDЦч¶Ї±ЁѕЇЙПґ« 
        public const int COMM_PUSH_UPDATE_RECORD_INFO  = 0x6001;  //НЖДЈКЅВјПсРЕПўЙПґ«
        public const int COMM_DIAGNOSIS_UPLOAD = 0x5100;  //Хп¶П·юОсЖчVQD±ЁѕЇЙПґ«

        /*************ІЩЧчТміЈАаРН(ПыПў·ЅКЅ, »Шµч·ЅКЅ(±ЈБф))****************/
        public const int EXCEPTION_EXCHANGE = 32768;//УГ»§Ѕ»»ҐК±ТміЈ
        public const int EXCEPTION_AUDIOEXCHANGE = 32769;//УпТф¶ФЅІТміЈ
        public const int EXCEPTION_ALARM = 32770;//±ЁѕЇТміЈ
        public const int EXCEPTION_PREVIEW = 32771;//НшВзФ¤ААТміЈ
        public const int EXCEPTION_SERIAL = 32772;//НёГчНЁµАТміЈ
        public const int EXCEPTION_RECONNECT = 32773;//Ф¤ААК±ЦШБ¬
        public const int EXCEPTION_ALARMRECONNECT = 32774;//±ЁѕЇК±ЦШБ¬
        public const int EXCEPTION_SERIALRECONNECT = 32775;//НёГчНЁµАЦШБ¬
        public const int EXCEPTION_PLAYBACK = 32784;//»Ш·ЕТміЈ
        public const int EXCEPTION_DISKFMT = 32785;//УІЕМёсКЅ»Ї

        /********************Ф¤АА»ШµчєЇКэ*********************/
        public const int NET_DVR_SYSHEAD = 1;//ПµНіН·КэѕЭ
        public const int NET_DVR_STREAMDATA = 2;//КУЖµБчКэѕЭЈЁ°ьАЁёґєПБчєНТфКУЖµ·ЦїЄµДКУЖµБчКэѕЭЈ©
        public const int NET_DVR_AUDIOSTREAMDATA = 3;//ТфЖµБчКэѕЭ
        public const int NET_DVR_STD_VIDEODATA = 4;//±кЧјКУЖµБчКэѕЭ
        public const int NET_DVR_STD_AUDIODATA = 5;//±кЧјТфЖµБчКэѕЭ

        //»ШµчФ¤ААЦРµДЧґМ¬єНПыПў
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//Ф¤ААТміЈ
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//Ф¤ААК±Б¬ЅУ¶ПїЄ
        public const int NET_DVR_REALPLAY5SNODATA = 113;//Ф¤АА5sГ»УРКХµЅКэѕЭ
        public const int NET_DVR_REALPLAYRECONNECT = 114;//Ф¤ААЦШБ¬

        /********************»Ш·Е»ШµчєЇКэ*********************/
        public const int NET_DVR_PLAYBACKOVER = 101;//»Ш·ЕКэѕЭІҐ·ЕНк±П
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//»Ш·ЕТміЈ
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//»Ш·ЕК±єтБ¬ЅУ¶ПїЄ
        public const int NET_DVR_PLAYBACK5SNODATA = 104;//»Ш·Е5sГ»УРКХµЅКэѕЭ

        /*********************»ШµчєЇКэАаРН end************************/
        //Йи±ёРНєЕ(DVRАаРН)
        /* Йи±ёАаРН */
        public const int DVR = 1;/*¶ФЙРОґ¶ЁТеµДdvrАаРН·µ»ШNETRET_DVR*/
        public const int ATMDVR = 2;/*atm dvr*/
        public const int DVS = 3;/*DVS*/
        public const int DEC = 4;/* 6001D */
        public const int ENC_DEC = 5;/* 6001F */
        public const int DVR_HC = 6;/*8000HC*/
        public const int DVR_HT = 7;/*8000HT*/
        public const int DVR_HF = 8;/*8000HF*/
        public const int DVR_HS = 9;/* 8000HS DVR(no audio) */
        public const int DVR_HTS = 10; /* 8016HTS DVR(no audio) */
        public const int DVR_HB = 11; /* HB DVR(SATA HD) */
        public const int DVR_HCS = 12; /* 8000HCS DVR */
        public const int DVS_A = 13; /* ґшATAУІЕМµДDVS */
        public const int DVR_HC_S = 14; /* 8000HC-S */
        public const int DVR_HT_S = 15;/* 8000HT-S */
        public const int DVR_HF_S = 16;/* 8000HF-S */
        public const int DVR_HS_S = 17; /* 8000HS-S */
        public const int ATMDVR_S = 18;/* ATM-S */
        public const int LOWCOST_DVR = 19;/*7000HПµБР*/
        public const int DEC_MAT = 20; /*¶аВ·ЅвВлЖч*/
        public const int DVR_MOBILE = 21;/* mobile DVR */
        public const int DVR_HD_S = 22;   /* 8000HD-S */
        public const int DVR_HD_SL = 23;/* 8000HD-SL */
        public const int DVR_HC_SL = 24;/* 8000HC-SL */
        public const int DVR_HS_ST = 25;/* 8000HS_ST */
        public const int DVS_HW = 26; /* 6000HW */
        public const int DS630X_D = 27; /* ¶аВ·ЅвВлЖч */
        public const int IPCAM = 30;/*IP ЙгПс»ъ*/
        public const int MEGA_IPCAM = 31;/*X52MFПµБР,752MF,852MF*/
        public const int IPCAM_X62MF = 32;/*X62MFПµБРїЙЅУИл9000Йи±ё,762MF,862MF*/
        public const int IPDOME = 40; /*IP ±кЗеЗт»ъ*/
        public const int IPDOME_MEGA200 = 41;/*IP 200НтёЯЗеЗт»ъ*/
        public const int IPDOME_MEGA130 = 42;/*IP 130НтёЯЗеЗт»ъ*/
        public const int IPMOD = 50;/*IP ДЈїй*/
        public const int DS71XX_H = 71;/* DS71XXH_S */
        public const int DS72XX_H_S = 72;/* DS72XXH_S */
        public const int DS73XX_H_S = 73;/* DS73XXH_S */
        public const int DS76XX_H_S = 76;/* DS76XX_H_S */
        public const int DS81XX_HS_S = 81;/* DS81XX_HS_S */
        public const int DS81XX_HL_S = 82;/* DS81XX_HL_S */
        public const int DS81XX_HC_S = 83;/* DS81XX_HC_S */
        public const int DS81XX_HD_S = 84;/* DS81XX_HD_S */
        public const int DS81XX_HE_S = 85;/* DS81XX_HE_S */
        public const int DS81XX_HF_S = 86;/* DS81XX_HF_S */
        public const int DS81XX_AH_S = 87;/* DS81XX_AH_S */
        public const int DS81XX_AHF_S = 88;/* DS81XX_AHF_S */
        public const int DS90XX_HF_S = 90;  /*DS90XX_HF_S*/
        public const int DS91XX_HF_S = 91;  /*DS91XX_HF_S*/
        public const int DS91XX_HD_S = 92; /*91XXHD-S(MD)*/
        /**********************Йи±ёАаРН end***********************/

        /*************************************************
        ІОКэЕдЦГЅб№№ЎўІОКэ(ЖдЦР_V30ОЄ9000РВФц)
        **************************************************/
        //РЈК±Ѕб№№ІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME
        {
            public uint dwYear;
            public uint dwMonth;
            public uint dwDay;
            public uint dwHour;
            public uint dwMinute;
            public uint dwSecond;
        }

        //К±јдІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_V30
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
            public ushort wMilliSec;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_EX
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
        }

        //К±јд¶О(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHEDTIME
        {
            public byte byStartHour;//їЄКјК±јд
            public byte byStartMin;//їЄКјК±јд
            public byte byStopHour;//ЅбКшК±јд
            public byte byStopMin;//ЅбКшК±јд
        }

        /*Йи±ё±ЁѕЇєНТміЈґ¦Ан·ЅКЅ*/
        public const int NOACTION = 0x0;/*ОЮПмУ¦*/
        public const int WARNONMONITOR = 0x1;/*јаКУЖчЙПѕЇёж*/
        public const int WARNONAUDIOOUT = 0x2;/*ЙщТфѕЇёж*/
        public const int UPTOCENTER = 0x4;/*ЙПґ«ЦРРД*/
        public const int TRIGGERALARMOUT = 0x8;/*ґҐ·ў±ЁѕЇКдіц*/
        public const int TRIGGERCATPIC = 0x10;/*ґҐ·ўЧҐНјІўЙПґ«E-mail*/
        public const int SEND_PIC_FTP = 0x200;  /*ЧҐНјІўЙПґ«ftp*/        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STRUCTHEAD
        {
            public ushort wLength;  //Ѕб№№і¤¶И
            public byte byVersion;	/*ёЯµН4О»·Ц±рґъ±нёЯµН°ж±ѕЈ¬єуРшёщѕЭ°ж±ѕєНі¤¶ИЅшРРА©Х№Ј¬І»Н¬µД°ж±ѕµДі¤¶ИЅшРРПЮЦЖ*/
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V41
        {
            public uint dwHandleType;/*ґ¦Ан·ЅКЅ,ґ¦Ан·ЅКЅµД"»т"Ѕб№ы*/
            /*0x00: ОЮПмУ¦*/
            /*0x01: јаКУЖчЙПѕЇёж*/
            /*0x02: ЙщТфѕЇёж*/
            /*0x04: ЙПґ«ЦРРД*/
            /*0x08: ґҐ·ў±ЁѕЇКдіц*/
            /*0x10: ґҐ·ўJPRGЧҐНјІўЙПґ«Email*/
            /*0x20: ОЮПЯЙщ№в±ЁѕЇЖчБЄ¶Ї*/
            /*0x40: БЄ¶ЇµзЧУµШНј(ДїЗ°Ц»УРPCNVRЦ§іЦ)*/
            /*0x200: ЧҐНјІўЙПґ«FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //ґҐ·ўµД±ЁѕЇКдіцНЁµАКэЈЁЦ»¶БЈ©ЧоґуЦ§іЦКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //ґҐ·ў±ЁѕЇНЁµА      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V40
        {
            public uint dwHandleType;/*ґ¦Ан·ЅКЅ,ґ¦Ан·ЅКЅµД"»т"Ѕб№ы*/
            /*0x00: ОЮПмУ¦*/
            /*0x01: јаКУЖчЙПѕЇёж*/
            /*0x02: ЙщТфѕЇёж*/
            /*0x04: ЙПґ«ЦРРД*/
            /*0x08: ґҐ·ў±ЁѕЇКдіц*/
            /*0x10: ґҐ·ўJPRGЧҐНјІўЙПґ«Email*/
            /*0x20: ОЮПЯЙщ№в±ЁѕЇЖчБЄ¶Ї*/
            /*0x40: БЄ¶ЇµзЧУµШНј(ДїЗ°Ц»УРPCNVRЦ§іЦ)*/
            /*0x200: ЧҐНјІўЙПґ«FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //ґҐ·ўµД±ЁѕЇКдіцНЁµАКэЈЁЦ»¶БЈ©ЧоґуЦ§іЦКэ
            public uint dwRelAlarmOutChanNum; //ґҐ·ўµД±ЁѕЇКдіцНЁµАКэ КµјКЦ§іЦКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //ґҐ·ў±ЁѕЇНЁµА      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±ЈБф
        }

        //±ЁѕЇєНТміЈґ¦АнЅб№№(ЧУЅб№№)(¶аґ¦К№УГ)(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            public uint dwHandleType;/*ґ¦Ан·ЅКЅ,ґ¦Ан·ЅКЅµД"»т"Ѕб№ы*/
            /*0x00: ОЮПмУ¦*/
            /*0x01: јаКУЖчЙПѕЇёж*/
            /*0x02: ЙщТфѕЇёж*/
            /*0x04: ЙПґ«ЦРРД*/
            /*0x08: ґҐ·ў±ЁѕЇКдіц*/
            /*0x10: ґҐ·ўJPRGЧҐНјІўЙПґ«Email*/
            /*0x20: ОЮПЯЙщ№в±ЁѕЇЖчБЄ¶Ї*/
            /*0x40: БЄ¶ЇµзЧУµШНј(ДїЗ°Ц»УРPCNVRЦ§іЦ)*/
            /*0x200: ЧҐНјІўЙПґ«FTP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±ЁѕЇґҐ·ўµДКдіцНЁµА,±ЁѕЇґҐ·ўµДКдіц,ОЄ1±нКѕґҐ·ўёГКдіц
        }

        //±ЁѕЇєНТміЈґ¦АнЅб№№(ЧУЅб№№)(¶аґ¦К№УГ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION
        {
            public uint dwHandleType;/*ґ¦Ан·ЅКЅ,ґ¦Ан·ЅКЅµД"»т"Ѕб№ы*/
            /*0x00: ОЮПмУ¦*/
            /*0x01: јаКУЖчЙПѕЇёж*/
            /*0x02: ЙщТфѕЇёж*/
            /*0x04: ЙПґ«ЦРРД*/
            /*0x08: ґҐ·ў±ЁѕЇКдіц*/
            /*0x10: JpegЧҐНјІўЙПґ«EMail*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//±ЁѕЇґҐ·ўµДКдіцНЁµА,±ЁѕЇґҐ·ўµДКдіц,ОЄ1±нКѕґҐ·ўёГКдіц
        }

        //DVRЙи±ёІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;//DVRГыіЖ
            public uint dwDVRID;//DVR ID,УГУЪТЈїШЖч //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;//КЗ·сС­»·ВјПс,0:І»КЗ; 1:КЗ
            //ТФПВІ»їЙёьёД
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//РтБРєЕ
            public uint dwSoftwareVersion;//Инјю°ж±ѕєЕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwSoftwareBuildDate;//ИнјюЙъіЙИХЖЪ,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;//DSPИнјю°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwDSPSoftwareBuildDate;// DSPИнјюЙъіЙИХЖЪ,0xYYYYMMDD
            public uint dwPanelVersion;// З°Гж°е°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwHardwareVersion;// УІјю°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public byte byAlarmInPortNum;//DVR±ЁѕЇКдИлёцКэ
            public byte byAlarmOutPortNum;//DVR±ЁѕЇКдіцёцКэ
            public byte byRS232Num;//DVR 232ґ®їЪёцКэ
            public byte byRS485Num;//DVR 485ґ®їЪёцКэ
            public byte byNetworkPortNum;//НшВзїЪёцКэ
            public byte byDiskCtrlNum;//DVR УІЕМїШЦЖЖчёцКэ
            public byte byDiskNum;//DVR УІЕМёцКэ
            public byte byDVRType;//DVRАаРН, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR НЁµАёцКэ
            public byte byStartChan;//ЖрКјНЁµАєЕ,АэИзDVS-1,DVR - 1
            public byte byDecordChans;//DVR ЅвВлВ·Кэ
            public byte byVGANum;//VGAїЪµДёцКэ
            public byte byUSBNum;//USBїЪµДёцКэ
            public byte byAuxoutNum;//ёЁїЪµДёцКэ
            public byte byAudioNum;//УпТфїЪµДёцКэ
            public byte byIPChanNum;//ЧоґуКэЧЦНЁµАКэ
        }

        /*IPµШЦ·*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IPADDR
        {

            /// char[16]
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpV4;

            /// BYTE[128]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[128];
            }
        }

        /*НшВзКэѕЭЅб№№(ЧУЅб№№)(9000А©Х№)*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_V30
        {
            public NET_DVR_IPADDR struDVRIP;//DVR IPµШЦ·
            public NET_DVR_IPADDR struDVRIPMask;//DVR IPµШЦ·СЪВл
            public uint dwNetInterface;//НшВзЅУїЪЈє1-10MBase-TЈ»2-10MBase-TИ«Л«№¤Ј»3-100MBase-TXЈ»4-100MИ«Л«№¤Ј»5-10M/100M/1000MЧФККУ¦Ј»6-1000MИ«Л«№¤
            public ushort wDVRPort;//¶ЛїЪєЕ
            public ushort wMTU;//ФцјУMTUЙиЦГЈ¬Д¬ИП1500ЎЈ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;// ОпАнµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*НшВзКэѕЭЅб№№(ЧУЅб№№)*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;//DVR IPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIPMask;//DVR IPµШЦ·СЪВл
            public uint dwNetInterface;//НшВзЅУїЪ 1-10MBase-T 2-10MBase-TИ«Л«№¤ 3-100MBase-TX 4-100MИ«Л«№¤ 5-10M/100MЧФККУ¦
            public ushort wDVRPort;//¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;//·юОсЖчµДОпАнµШЦ·
        }

        //pppoeЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPOECFG
        {
            public uint dwPPPOE;//0-І»ЖфУГ,1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEГЬВл
            public NET_DVR_IPADDR struPPPoEIP;//PPPoE IPµШЦ·
        }

        //НшВзЕдЦГЅб№№(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;//ТФМ«НшїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;/*±ЈБф*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;/* ±ЁѕЇЦч»ъIPµШЦ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public ushort wAlarmHostIpPort;
            public byte byUseDhcp;
            public byte byRes3;
            public NET_DVR_IPADDR struDnsServer1IpAddr;/* УтГы·юОсЖч1µДIPµШЦ· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;/* УтГы·юОсЖч2µДIPµШЦ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wHttpPortNo;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶аІҐЧйµШЦ· */
            public NET_DVR_IPADDR struGatewayIpAddr;/* Нш№ШµШЦ· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µҐёцНшїЁЕдЦГРЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_MULTI
        {
            public NET_DVR_IPADDR struDVRIP;
            public NET_DVR_IPADDR struDVRIPMask;
            public uint dwNetInterface;
            public byte byCardType;  //НшїЁАаРНЈ¬0-ЖХНЁНшїЁЈ¬1-ДЪНшНшїЁЈ¬2-НвНшНшїЁ
            public byte byRes1;
            public ushort wMTU;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public byte byUseDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_IPADDR struGatewayIpAddr;
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            public NET_DVR_IPADDR struDnsServer2IpAddr;
        }

        //¶аНшїЁНшВзЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_MULTI
        {
            public uint dwSize;
            public byte byDefaultRoute;
            public byte byNetworkCardNum;
            public byte byWorkMode;   //0-ЖХНЁ¶аНшїЁДЈКЅЈ¬1-ДЪНвНшёфАлДЈКЅ
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_MULTI[] struEtherNet;//ТФМ«НшїЪ
            public NET_DVR_IPADDR struManageHost1IpAddr;
            public NET_DVR_IPADDR struManageHost2IpAddr;
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            public ushort wManageHost1Port;
            public ushort wManageHost2Port;
            public ushort wAlarmHostIpPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wDvrPort;
            public ushort wHttpPortNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struMulticastIpAddr;/* ¶аІҐЧйµШЦ· */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //НшВзЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET[] struEtherNet;/* ТФМ«НшїЪ */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sManageHostIP;//Ф¶іМ№ЬАнЦч»ъµШЦ·
            public ushort wManageHostPort;//Ф¶іМ№ЬАнЦч»ъ¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIPServerIP;//IPServer·юОсЖчµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sMultiCastIP;//¶аІҐЧйµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIP;//Нш№ШµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNFSIP;//NFSЦч»ъIPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNFSDirectory;//NFSДїВј
            public uint dwPPPOE;//0-І»ЖфУГ,1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoEУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoEГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sPPPoEIP;//PPPoE IPµШЦ·(Ц»¶Б)
            public ushort wHttpPort;//HTTP¶ЛїЪєЕ
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SIP_CFG
        {
            public uint dwSize;
            public byte byEnableAutoLogin;    //К№ДЬЧФ¶ЇЧўІбЈ¬0-І»К№ДЬЈ¬1-К№ДЬ
            public byte byLoginStatus;  //ЧўІбЧґМ¬Ј¬0-ОґЧўІбЈ¬1-ТСЧўІбЈ¬ґЛІОКэЦ»ДЬ»сИЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR stuServerIP;  //SIP·юОсЖчIP
            public ushort wServerPort;    //SIP·юОсЖч¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;  //ЧўІбУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord; //ЧўІбГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispalyName; //Йи±ёПФКѕГыіЖ
            public ushort wLocalPort;     //±ѕµШ¶ЛїЪ
            public byte byLoginCycle;   //ЧўІбЦЬЖЪЈ¬1-99·ЦЦУ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPїЙКУ¶ФЅІ·Ц»ъЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_DEVCFG
        {
            public uint dwSize;
            public byte byDefaultRing; //Д¬ИПБеТфЈ¬·¶О§1-6
            public byte byRingVolume;  //БеТфТфБїЈ¬·¶О§0-9
            public byte byInputVolume; //КдИлТфБїЦµЈ¬·¶О§0-6
            public byte byOutputVolume; //КдіцТфБїЦµЈ¬·¶О§0-9	
            public ushort wRtpPort;  //Rtp¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPreviewDelayTime; //Ф¤ААСУК±ЕдЦГЈ¬0-30Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //IpїЙКУ¶ФЅІТфЖµПа№ШІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_AUDIO_CFG
        {
            public uint dwSize;	
            public byte byAudioEncPri1; //ТфЖµ±аВлУЕПИј¶1Ј¬0-OggVorbisЈ¬1-G711_UЈ¬2-G711_AЈ¬ 5-MPEG2,6-G726Ј¬7-AAC
            public byte byAudioEncPri2; //ТфЖµ±аВлУЕПИј¶2Ј¬µ±sip·юОсЖчІ»Ц§іЦТфЖµ±аВл1К±»бК№УГТфЖµ±аВл2Ј¬0-OggVorbisЈ¬1-G711_UЈ¬2-G711_AЈ¬ 5-MPEG2,6-G726Ј¬7-AAC
            public ushort wAudioPacketLen1; //ТфЖµ±аВл1КэѕЭ°ьі¤¶И
            public ushort wAudioPacketLen2; //ТфЖµ±аВл2КэѕЭ°ьі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //IP·Ц»ъєфЅР¶ФЅІІОКэЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_CALL_CFG
        {
            public uint dwSize ;
            public byte byEnableAutoResponse; //К№ДЬЧФ¶ЇУ¦ґр,0-І»К№ДЬЈ¬1-К№ДЬ
            public byte byAudoResponseTime; //ЧФ¶ЇУ¦ґрК±јдЈ¬0-30Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byEnableAlarmNumber1; //Жф¶Ї±ЁѕЇєЕВл1Ј¬0-І»Жф¶ЇЈ¬1-Жф¶Ї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber1; //єфЅРєЕВл1
            public byte byEnableAlarmNumber2; //Жф¶Ї±ЁѕЇєЕВл2Ј¬0-І»Жф¶ЇЈ¬1-Жф¶Ї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber2; //єфЅРєЕВл2Ј¬єфЅРєЕВл1К§°Ь»біўКФєфЅРєЕВл2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }
        
        //НЁµАНјПуЅб№№
        //ТЖ¶ЇХмІв(ЧУЅб№№)(°ґЧй·ЅКЅА©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDCHAN
        {    
            public uint dwMaxRecordChanNum;   //Йи±ёЦ§іЦµДЧоґу№ШБЄВјПсНЁµАКэ-Ц»¶Б
            public uint dwCurRecordChanNum;   //µ±З°КµјКТСЕдЦГµД№ШБЄВјПсНЁµАКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint dwRelRecordChan;	 /* КµјКґҐ·ўВјПсНЁµАЈ¬°ґЦµ±нКѕ,ІЙУГЅфґХРНЕЕБРЈ¬ґУПВ±к0 - MAX_CHANNUM_V30-1УРР§Ј¬Из№ыЦРјдУцµЅ0xffffffff,ФтєуРшОЮР§*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±ЈБф
        }             

        //НЁµАНјПуЅб№№
        //ТЖ¶ЇХмІв(ЧУЅб№№)(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOTION_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*ХмІвЗшУт,0-96О»,±нКѕ64РР,№ІУР96*64ёцРЎєкїй,ОЄ1±нКѕКЗТЖ¶ЇХмІвЗшУт,0-±нКѕІ»КЗ*/
            public byte byMotionSensitive;/*ТЖ¶ЇХмІвБйГф¶И, 0 - 5,ФЅёЯФЅБйГф,oxff№Ш±Х*/
            public byte byEnableHandleMotion;/* КЗ·сґ¦АнТЖ¶ЇХмІв 0Ј­·с 1Ј­КЗ*/
            public byte byEnableDisplay;/* ЖфУГТЖ¶ЇХмІвёЯББПФКѕЈє0- ·сЈ¬1- КЗ */
            public byte reservedData;
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;/*Іј·АК±јд*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;/* ±ЁѕЇґҐ·ўµДВјПуНЁµА*/
        }

        //ТЖ¶ЇХмІв(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*ХмІвЗшУт,№ІУР22*18ёцРЎєкїй,ОЄ1±нКѕёДєкїйКЗТЖ¶ЇХмІвЗшУт,0-±нКѕІ»КЗ*/
            public byte byMotionSensitive;/*ТЖ¶ЇХмІвБйГф¶И, 0 - 5,ФЅёЯФЅБйГф,0xff№Ш±Х*/
            public byte byEnableHandleMotion;/* КЗ·сґ¦АнТЖ¶ЇХмІв */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string reservedData;
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
        }

        //ХЪµІ±ЁѕЇ(ЧУЅб№№)(9000А©Х№)  ЗшУтґуРЎ704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM_V30
        {
            public uint dwEnableHideAlarm;/* КЗ·сЖф¶ЇХЪµІ±ЁѕЇ ,0-·с,1-µНБйГф¶И 2-ЦРБйГф¶И 3-ёЯБйГф¶И*/
            public ushort wHideAlarmAreaTopLeftX;/* ХЪµІЗшУтµДxЧш±к */
            public ushort wHideAlarmAreaTopLeftY;/* ХЪµІЗшУтµДyЧш±к */
            public ushort wHideAlarmAreaWidth;/* ХЪµІЗшУтµДїн */
            public ushort wHideAlarmAreaHeight;/*ХЪµІЗшУтµДёЯ*/
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;	/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
        }

        //ХЪµІ±ЁѕЇ(ЧУЅб№№)  ЗшУтґуРЎ704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM
        {
            public uint dwEnableHideAlarm;/* КЗ·сЖф¶ЇХЪµІ±ЁѕЇ ,0-·с,1-µНБйГф¶И 2-ЦРБйГф¶И 3-ёЯБйГф¶И*/
            public ushort wHideAlarmAreaTopLeftX;/* ХЪµІЗшУтµДxЧш±к */
            public ushort wHideAlarmAreaTopLeftY;/* ХЪµІЗшУтµДyЧш±к */
            public ushort wHideAlarmAreaWidth;/* ХЪµІЗшУтµДїн */
            public ushort wHideAlarmAreaHeight;/*ХЪµІЗшУтµДёЯ*/
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
        }

        //РЕєЕ¶ЄК§±ЁѕЇ(ЧУЅб№№)(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST_V30
        {
            public byte byEnableHandleVILost;/* КЗ·сґ¦АнРЕєЕ¶ЄК§±ЁѕЇ */
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
        }

        //РЕєЕ¶ЄК§±ЁѕЇ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST
        {
            public byte byEnableHandleVILost;/* КЗ·сґ¦АнРЕєЕ¶ЄК§±ЁѕЇ */
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
        }

        //ХЪµІЗшУт(ЧУЅб№№)
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct NET_DVR_SHELTER
        {
            public ushort wHideAreaTopLeftX;/* ХЪµІЗшУтµДxЧш±к */
            public ushort wHideAreaTopLeftY;/* ХЪµІЗшУтµДyЧш±к */
            public ushort wHideAreaWidth;/* ХЪµІЗшУтµДїн */
            public ushort wHideAreaHeight;/*ХЪµІЗшУтµДёЯ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COLOR
        {
            public byte byBrightness;/*ББ¶И,0-255*/
            public byte byContrast;/*¶Ф±И¶И,0-255*/
            public byte bySaturation;/*±ҐєН¶И,0-255*/
            public byte byHue;/*Й«µч,0-255*/
        }

        //НЁµАНјПуЅб№№(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ц»¶Б КУЖµЦЖКЅ 1-NTSC 2-PAL*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byReservedData;/*±ЈБф*/
            //ПФКѕНЁµАГы
            public uint dwShowChanName;// Ф¤ААµДНјПуЙПКЗ·сПФКѕНЁµАГыіЖ,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wShowNameTopLeftX;/* НЁµАГыіЖПФКѕО»ЦГµДxЧш±к */
            public ushort wShowNameTopLeftY;/* НЁµАГыіЖПФКѕО»ЦГµДyЧш±к */
            //КУЖµРЕєЕ¶ЄК§±ЁѕЇ
            public NET_DVR_VILOST_V30 struVILost;
            public NET_DVR_VILOST_V30 struRes;/*±ЈБф*/
            //ТЖ¶ЇХмІв
            public NET_DVR_MOTION_V30 struMotion;
            //ХЪµІ±ЁѕЇ
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            //ХЪµІ  ЗшУтґуРЎ704*576
            public uint dwEnableHide;/* КЗ·сЖф¶ЇХЪµІ ,0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ф¤ААµДНјПуЙПКЗ·сПФКѕOSD,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wOSDTopLeftX;/* OSDµДxЧш±к */
            public ushort wOSDTopLeftY;/* OSDµДyЧш±к */
            public byte byOSDType;/* OSDАаРН(ЦчТЄКЗДкФВИХёсКЅ) */
            /* 0: XXXX-XX-XX ДкФВИХ */
            /* 1: XX-XX-XXXX ФВИХДк */
            /* 2: XXXXДкXXФВXXИХ */
            /* 3: XXФВXXИХXXXXДк */
            /* 4: XX-XX-XXXX ИХФВДк*/
            /* 5: XXИХXXФВXXXXДк */
            public byte byDispWeek;/* КЗ·сПФКѕРЗЖЪ */
            public byte byOSDAttrib;/* OSDКфРФ:НёГчЈ¬ЙБЛё */
            /* 0: І»ПФКѕOSD */
            /* 1: НёГч,ЙБЛё */
            /* 2: НёГч,І»ЙБЛё */
            /* 3: ЙБЛё,І»НёГч */
            /* 4: І»НёГч,І»ЙБЛё */
            public byte byHourOSDType;/* OSDРЎК±ЦЖ:0-24РЎК±ЦЖ,1-12РЎК±ЦЖ */
            public byte byFontSize;//ЧЦМеґуРЎЈ¬16*16(ЦР)/8*16(Уў)Ј¬1-32*32(ЦР)/16*32(Уў)Ј¬2-64*64(ЦР)/32*64(Уў)  3-48*48(ЦР)/24*48(Уў) 0xff-ЧФККУ¦(adaptive)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //НЁµАНјПуЅб№№SDK_V14А©Х№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ц»¶Б КУЖµЦЖКЅ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ББ¶И,0-255*/
            public byte byContrast;/*¶Ф±И¶И,0-255*/
            public byte bySaturation;/*±ҐєН¶И,0-255 */
            public byte byHue;/*Й«µч,0-255*/
            //ПФКѕНЁµАГы
            public uint dwShowChanName;// Ф¤ААµДНјПуЙПКЗ·сПФКѕНЁµАГыіЖ,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wShowNameTopLeftX;/* НЁµАГыіЖПФКѕО»ЦГµДxЧш±к */
            public ushort wShowNameTopLeftY;/* НЁµАГыіЖПФКѕО»ЦГµДyЧш±к */
            //РЕєЕ¶ЄК§±ЁѕЇ
            public NET_DVR_VILOST struVILost;
            //ТЖ¶ЇХмІв
            public NET_DVR_MOTION struMotion;
            //ХЪµІ±ЁѕЇ
            public NET_DVR_HIDEALARM struHideAlarm;
            //ХЪµІ  ЗшУтґуРЎ704*576
            public uint dwEnableHide;/* КЗ·сЖф¶ЇХЪµІ ,0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ф¤ААµДНјПуЙПКЗ·сПФКѕOSD,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wOSDTopLeftX;/* OSDµДxЧш±к */
            public ushort wOSDTopLeftY;/* OSDµДyЧш±к */
            public byte byOSDType;/* OSDАаРН(ЦчТЄКЗДкФВИХёсКЅ) */
            /* 0: XXXX-XX-XX ДкФВИХ */
            /* 1: XX-XX-XXXX ФВИХДк */
            /* 2: XXXXДкXXФВXXИХ */
            /* 3: XXФВXXИХXXXXДк */
            /* 4: XX-XX-XXXX ИХФВДк*/
            /* 5: XXИХXXФВXXXXДк */
            public byte byDispWeek;/* КЗ·сПФКѕРЗЖЪ */
            public byte byOSDAttrib;/* OSDКфРФ:НёГчЈ¬ЙБЛё */
            /* 0: І»ПФКѕOSD */
            /* 1: НёГч,ЙБЛё */
            /* 2: НёГч,І»ЙБЛё */
            /* 3: ЙБЛё,І»НёГч */
            /* 4: І»НёГч,І»ЙБЛё */
            public byte byHourOsdType;/* OSDРЎК±ЦЖ:0-24РЎК±ЦЖ,1-12РЎК±ЦЖ */
        }

        //НЁµАНјПуЅб№№(SDK_V13ј°Ц®З°°ж±ѕ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* Ц»¶Б КУЖµЦЖКЅ 1-NTSC 2-PAL*/
            public byte byBrightness;/*ББ¶И,0-255*/
            public byte byContrast;/*¶Ф±И¶И,0-255*/
            public byte bySaturation;/*±ҐєН¶И,0-255 */
            public byte byHue;/*Й«µч,0-255*/
            //ПФКѕНЁµАГы
            public uint dwShowChanName;// Ф¤ААµДНјПуЙПКЗ·сПФКѕНЁµАГыіЖ,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wShowNameTopLeftX;/* НЁµАГыіЖПФКѕО»ЦГµДxЧш±к */
            public ushort wShowNameTopLeftY;/* НЁµАГыіЖПФКѕО»ЦГµДyЧш±к */
            //РЕєЕ¶ЄК§±ЁѕЇ
            public NET_DVR_VILOST struVILost;
            //ТЖ¶ЇХмІв
            public NET_DVR_MOTION struMotion;
            //ХЪµІ±ЁѕЇ
            public NET_DVR_HIDEALARM struHideAlarm;
            //ХЪµІ  ЗшУтґуРЎ704*576
            public uint dwEnableHide;/* КЗ·сЖф¶ЇХЪµІ ,0-·с,1-КЗ*/
            public ushort wHideAreaTopLeftX;/* ХЪµІЗшУтµДxЧш±к */
            public ushort wHideAreaTopLeftY;/* ХЪµІЗшУтµДyЧш±к */
            public ushort wHideAreaWidth;/* ХЪµІЗшУтµДїн */
            public ushort wHideAreaHeight;/*ХЪµІЗшУтµДёЯ*/
            //OSD
            public uint dwShowOsd;// Ф¤ААµДНјПуЙПКЗ·сПФКѕOSD,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576
            public ushort wOSDTopLeftX;/* OSDµДxЧш±к */
            public ushort wOSDTopLeftY;/* OSDµДyЧш±к */
            public byte byOSDType;/* OSDАаРН(ЦчТЄКЗДкФВИХёсКЅ) */
            /* 0: XXXX-XX-XX ДкФВИХ */
            /* 1: XX-XX-XXXX ФВИХДк */
            /* 2: XXXXДкXXФВXXИХ */
            /* 3: XXФВXXИХXXXXДк */
            /* 4: XX-XX-XXXX ИХФВДк*/
            /* 5: XXИХXXФВXXXXДк */
            public byte byDispWeek;/* КЗ·сПФКѕРЗЖЪ */
            public byte byOSDAttrib;/* OSDКфРФ:НёГчЈ¬ЙБЛё */
            /* 0: І»ПФКѕOSD */
            /* 1: НёГч,ЙБЛё */
            /* 2: НёГч,І»ЙБЛё */
            /* 3: ЙБЛё,І»НёГч */
            /* 4: І»НёГч,І»ЙБЛё */
            public byte reservedData2;
        }

        //ВлБчС№ЛхІОКэ(ЧУЅб№№)(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            public byte byStreamType;//ВлБчАаРН 0-КУЖµБч, 1-ёґєПБч, ±нКѕКВјюС№ЛхІОКэК±ЧоёЯО»±нКѕКЗ·сЖфУГС№ЛхІОКэ
            public byte byResolution;//·Ц±жВК0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5ЈЁ±ЈБфЈ©16-VGAЈЁ640*480Ј© 17-UXGAЈЁ1600*1200Ј© 18-SVGA ЈЁ800*600Ј©19-HD720pЈЁ1280*720Ј©20-XVGA  21-HD900p
            public byte byBitrateType;//ВлВКАаРН 0:±дВлВК, 1:¶ЁВлВК
            public byte byPicQuality;//НјПуЦКБї 0-ЧоєГ 1-ґОєГ 2-ЅПєГ 3-Т»°г 4-ЅПІо 5-Іо
            public uint dwVideoBitrate;//КУЖµВлВК 0-±ЈБф 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //ЧоёЯО»(31О»)ЦГіЙ1±нКѕКЗЧФ¶ЁТеВлБч, 0-30О»±нКѕВлБчЦµЎЈ
            public uint dwVideoFrameRate;//ЦЎВК 0-И«Ії; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0°ж±ѕЦРРВјУ14-15; 15-18; 16-22;
            public ushort wIntervalFrameI;//IЦЎјдёф
            //2006-08-11 ФцјУµҐPЦЎµДЕдЦГЅУїЪЈ¬їЙТФёДЙЖКµК±БчСУК±ОКМв
            public byte byIntervalBPFrame;//0-BBPЦЎ; 1-BPЦЎ; 2-µҐPЦЎ
            public byte byres1; //±ЈБф
            public byte byVideoEncType;//КУЖµ±аВлАаРН 0 hik264;1±кЧјh264; 2±кЧјmpeg4;
            public byte byAudioEncType; //ТфЖµ±аВлАаРН 0Ј­OggVorbis
            public byte byVideoEncComplexity; //КУЖµ±аВлёґФУ¶ИЈ¬0-µНЈ¬1-ЦРЈ¬2ёЯ,0xfe:ЧФ¶ЇЈ¬єНФґТ»ЦВ
            public byte byEnableSvc; //0 - І»ЖфУГSVC№¦ДЬЈ»1- ЖфУГSVC№¦ДЬ
            public byte byFormatType; //·вЧ°АаРНЈ¬1-ВгБчЈ¬2-RTP·вЧ°Ј¬3-PS·вЧ°Ј¬4-TS·вЧ°Ј¬5-ЛЅУРЈ¬6-FLVЈ¬7-ASFЈ¬8-3GP,9-RTP+PSЈЁ№ъ±кЈєGB28181Ј©Ј¬0xff-ОЮР§
            public byte byAudioBitRate; //ТфЖµВлВК0-Д¬ИПЈ¬1-8Kbps, 2- 16Kbps, 3-32KbpsЈ¬4-64KbpsЈ¬5-128KbpsЈ¬6-192KbpsЈ»(IPC5.1.0Д¬ИП4-64Kbps)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ
        }

        //НЁµАС№ЛхІОКэ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;//ВјПс ¶ФУ¦8000µДЖХНЁ
            public NET_DVR_COMPRESSION_INFO_V30 struRes;//±ЈБф char reserveData[28];
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;//КВјюґҐ·ўС№ЛхІОКэ
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;//Ншґ«(ЧУВлБч)
        }

        //ВлБчС№ЛхІОКэ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO
        {
            public byte byStreamType;//ВлБчАаРН0-КУЖµБч,1-ёґєПБч,±нКѕС№ЛхІОКэК±ЧоёЯО»±нКѕКЗ·сЖфУГС№ЛхІОКэ
            public byte byResolution;//·Ц±жВК0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(іµФШЧЁУГ)
            public byte byBitrateType;//ВлВКАаРН0:±дВлВКЈ¬1:¶ЁВлВК
            public byte byPicQuality;//НјПуЦКБї 0-ЧоєГ 1-ґОєГ 2-ЅПєГ 3-Т»°г 4-ЅПІо 5-Іо
            public uint dwVideoBitrate; //КУЖµВлВК 0-±ЈБф 1-16K(±ЈБф) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //ЧоёЯО»(31О»)ЦГіЙ1±нКѕКЗЧФ¶ЁТеВлБч, 0-30О»±нКѕВлБчЦµ(MIN-32K MAX-8192K)ЎЈ
            public uint dwVideoFrameRate;//ЦЎВК 0-И«Ії; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
        }

        //НЁµАС№ЛхІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO struRecordPara;//ВјПс/КВјюґҐ·ўВјПс
            public NET_DVR_COMPRESSION_INFO struNetPara;//Ншґ«/±ЈБф
        }

        //ВлБчС№ЛхІОКэ(ЧУЅб№№)(А©Х№) ФцјУIЦЎјдёф
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            public byte byStreamType;//ВлБчАаРН0-КУЖµБч, 1-ёґєПБч
            public byte byResolution;//·Ц±жВК0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(іµФШЧЁУГ)
            public byte byBitrateType;//ВлВКАаРН0:±дВлВКЈ¬1:¶ЁВлВК
            public byte byPicQuality;//НјПуЦКБї 0-ЧоєГ 1-ґОєГ 2-ЅПєГ 3-Т»°г 4-ЅПІо 5-Іо
            public uint dwVideoBitrate;//КУЖµВлВК 0-±ЈБф 1-16K(±ЈБф) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //ЧоёЯО»(31О»)ЦГіЙ1±нКѕКЗЧФ¶ЁТеВлБч, 0-30О»±нКѕВлБчЦµ(MIN-32K MAX-8192K)ЎЈ
            public uint dwVideoFrameRate;//ЦЎВК 0-И«Ії; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0ФцјУ14-15, 15-18, 16-22;
            public ushort wIntervalFrameI;//IЦЎјдёф
            //2006-08-11 ФцјУµҐPЦЎµДЕдЦГЅУїЪЈ¬їЙТФёДЙЖКµК±БчСУК±ОКМв
            public byte byIntervalBPFrame;//0-BBPЦЎ; 1-BPЦЎ; 2-µҐPЦЎ
            public byte byRes;
        }

        //НЁµАС№ЛхІОКэ(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;//ВјПс
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;//Ншґ«
        }

        //К±јд¶ОВјПсІОКэЕдЦГ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDSCHED
        {
            public NET_DVR_SCHEDTIME struRecordTime;
            public byte byRecordType;//0:¶ЁК±ВјПсЈ¬1:ТЖ¶ЇХмІвЈ¬2:±ЁѕЇВјПсЈ¬3:¶ЇІв|±ЁѕЇЈ¬4:¶ЇІв&±ЁѕЇ, 5:ГьБоґҐ·ў, 6: ЦЗДЬВјПс
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string reservedData;
        }

        //И«МмВјПсІОКэЕдЦГ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY
        {
            public ushort wAllDayRecord;/* КЗ·сИ«МмВјПс 0-·с 1-КЗ*/
            public byte byRecordType;/* ВјПуАаРН 0:¶ЁК±ВјПсЈ¬1:ТЖ¶ЇХмІвЈ¬2:±ЁѕЇВјПсЈ¬3:¶ЇІв|±ЁѕЇЈ¬4:¶ЇІв&±ЁѕЇ 5:ГьБоґҐ·ў, 6: ЦЗДЬВјПс*/
            public byte reservedData;
        }

        //НЁµАВјПсІОКэЕдЦГ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            public uint dwRecord;/*КЗ·сВјПс 0-·с 1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* ВјПуСУК±і¤¶И 0-5ГлЈ¬ 1-20ГлЈ¬ 2-30ГлЈ¬ 3-1·ЦЦУЈ¬ 4-2·ЦЦУЈ¬ 5-5·ЦЦУЈ¬ 6-10·ЦЦУ*/
            public uint dwPreRecordTime;/* Ф¤ВјК±јд 0-І»Ф¤Вј 1-5Гл 2-10Гл 3-15Гл 4-20Гл 5-25Гл 6-30Гл 7-0xffffffff(ѕЎїЙДЬФ¤Вј) */
            public uint dwRecorderDuration;/* ВјПс±ЈґжµДЧоі¤К±јд */
            public byte byRedundancyRec;/*КЗ·сИЯУаВјПс,ЦШТЄКэѕЭЛ«±ё·ЭЈє0/1*/
            public byte byAudioRec;/*ВјПсК±ёґєПБч±аВлК±КЗ·сјЗВјТфЖµКэѕЭЈє№ъНвУРґЛ·Ё№ж*/
            public byte byStreamType;  // 0:ЦчВлБч 1ЈєЧУВлБч
            public byte byPassbackRecord;  // 0:І»»Шґ«ВјПс 1Јє»Шґ«ВјПс
            public ushort wLockDuration;  // ВјПсЛш¶ЁК±і¤Ј¬µҐО»РЎК± 0±нКѕІ»Лш¶ЁЈ¬0xffff±нКѕУАѕГЛш¶ЁЈ¬ВјПс¶ОµДК±і¤ґуУЪЛш¶ЁµДіЦРшК±і¤µДВјПсЈ¬Ѕ«І»»бЛш¶Ё
            public byte byRecordBackup;  // 0:ВјПсІ»ґжµµ 1ЈєВјПсґжµµ
            public byte bySVCLevel;	//SVCійЦЎАаРНЈє0-І»ійЈ¬1-ій¶ю·ЦЦ®Т» 2-ійЛД·ЦЦ®Иэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;
        }

        //НЁµАВјПсІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            public uint dwRecord;/*КЗ·сВјПс 0-·с 1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* ВјПуК±јді¤¶И */
            public uint dwPreRecordTime;/* Ф¤ВјК±јд 0-І»Ф¤Вј 1-5Гл 2-10Гл 3-15Гл 4-20Гл 5-25Гл 6-30Гл 7-0xffffffff(ѕЎїЙДЬФ¤Вј) */
        }

        //ФЖМЁР­Тй±нЅб№№ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_PROTOCOL
        {
            public uint dwType;/*ЅвВлЖчАаРНЦµЈ¬ґУ1їЄКјБ¬РшµЭФц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe;/*ЅвВлЖчµДГиКц·ыЈ¬єН8000ЦРµДТ»ЦВ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PTZ_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZ_PROTOCOL[] struPtz;/*Чоґу200ЦРPTZР­Тй*/
            public uint dwPtzNum;/*УРР§µДptzР­ТйКэДїЈ¬ґУ0їЄКј(јґјЖЛгК±јУ1)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************ФЖМЁАаРН(end)******************************/

        //НЁµАЅвВлЖч(ФЖМЁ)ІОКэЕдЦГ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            public uint dwBaudRate;//ІЁМШВК(bps)Ј¬0Ј­50Ј¬1Ј­75Ј¬2Ј­110Ј¬3Ј­150Ј¬4Ј­300Ј¬5Ј­600Ј¬6Ј­1200Ј¬7Ј­2400Ј¬8Ј­4800Ј¬9Ј­9600Ј¬10Ј­19200Ј¬ 11Ј­38400Ј¬12Ј­57600Ј¬13Ј­76800Ј¬14Ј­115.2k;
            public byte byDataBit;// КэѕЭУРјёО» 0Ј­5О»Ј¬1Ј­6О»Ј¬2Ј­7О»Ј¬3Ј­8О»;
            public byte byStopBit;// НЈЦ№О» 0Ј­1О»Ј¬1Ј­2О»
            public byte byParity;// РЈСй 0Ј­ОЮРЈСйЈ¬1Ј­ЖжРЈСйЈ¬2Ј­ЕјРЈСй;
            public byte byFlowcontrol;// 0Ј­ОЮЈ¬1Ј­ИнБчїШ,2-УІБчїШ
            public ushort wDecoderType;//ЅвВлЖчАаРН, ґУ0їЄКјЈ¬¶ФУ¦ptzР­ТйБР±н
            public ushort wDecoderAddress;/*ЅвВлЖчµШЦ·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ф¤ЦГµгКЗ·сЙиЦГ,0-Г»УРЙиЦГ,1-ЙиЦГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* СІєЅКЗ·сЙиЦГ: 0-Г»УРЙиЦГ,1-ЙиЦГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* №мјЈКЗ·сЙиЦГ,0-Г»УРЙиЦГ,1-ЙиЦГ*/
        }

        //НЁµАЅвВлЖч(ФЖМЁ)ІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            public uint dwBaudRate; //ІЁМШВК(bps)Ј¬0Ј­50Ј¬1Ј­75Ј¬2Ј­110Ј¬3Ј­150Ј¬4Ј­300Ј¬5Ј­600Ј¬6Ј­1200Ј¬7Ј­2400Ј¬8Ј­4800Ј¬9Ј­9600Ј¬10Ј­19200Ј¬ 11Ј­38400Ј¬12Ј­57600Ј¬13Ј­76800Ј¬14Ј­115.2k;
            public byte byDataBit; // КэѕЭУРјёО» 0Ј­5О»Ј¬1Ј­6О»Ј¬2Ј­7О»Ј¬3Ј­8О»;
            public byte byStopBit;// НЈЦ№О» 0Ј­1О»Ј¬1Ј­2О»;
            public byte byParity; // РЈСй 0Ј­ОЮРЈСйЈ¬1Ј­ЖжРЈСйЈ¬2Ј­ЕјРЈСй;
            public byte byFlowcontrol;// 0Ј­ОЮЈ¬1Ј­ИнБчїШ,2-УІБчїШ
            public ushort wDecoderType;//ЅвВлЖчАаРН, 0Ј­YouLiЈ¬1Ј­LiLin-1016Ј¬2Ј­LiLin-820Ј¬3Ј­Pelco-pЈ¬4Ј­DM DynaColorЈ¬5Ј­HD600Ј¬6Ј­JC-4116Ј¬7Ј­Pelco-d WXЈ¬8Ј­Pelco-d PICO
            public ushort wDecoderAddress;/*ЅвВлЖчµШЦ·:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ф¤ЦГµгКЗ·сЙиЦГ,0-Г»УРЙиЦГ,1-ЙиЦГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* СІєЅКЗ·сЙиЦГ: 0-Г»УРЙиЦГ,1-ЙиЦГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* №мјЈКЗ·сЙиЦГ,0-Г»УРЙиЦГ,1-ЙиЦГ*/
        }

        //pppІОКэЕдЦГ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG_V30
        {
            public NET_DVR_IPADDR struRemoteIP;//Ф¶¶ЛIPµШЦ·
            public NET_DVR_IPADDR struLocalIP;//±ѕµШIPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±ѕµШIPµШЦ·СЪВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            public byte byPPPMode;//PPPДЈКЅ, 0Ј­Цч¶ЇЈ¬1Ј­±»¶Ї
            public byte byRedial;//КЗ·с»ШІ¦ Јє0-·с,1-КЗ
            public byte byRedialMode;//»ШІ¦ДЈКЅ,0-УЙІ¦ИлХЯЦё¶Ё,1-Ф¤ЦГ»ШІ¦єЕВл
            public byte byDataEncrypt;//КэѕЭјУГЬ,0-·с,1-КЗ
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µз»°єЕВл
        }

        //pppІОКэЕдЦГ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteIP;//Ф¶¶ЛIPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIP;//±ѕµШIPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//±ѕµШIPµШЦ·СЪВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            public byte byPPPMode;//PPPДЈКЅ, 0Ј­Цч¶ЇЈ¬1Ј­±»¶Ї
            public byte byRedial;//КЗ·с»ШІ¦ Јє0-·с,1-КЗ
            public byte byRedialMode;//»ШІ¦ДЈКЅ,0-УЙІ¦ИлХЯЦё¶Ё,1-Ф¤ЦГ»ШІ¦єЕВл
            public byte byDataEncrypt;//КэѕЭјУГЬ,0-·с,1-КЗ
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//µз»°єЕВл
        }

        //RS232ґ®їЪІОКэЕдЦГ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_RS232
        {
            public uint dwBaudRate;/*ІЁМШВК(bps)Ј¬0Ј­50Ј¬1Ј­75Ј¬2Ј­110Ј¬3Ј­150Ј¬4Ј­300Ј¬5Ј­600Ј¬6Ј­1200Ј¬7Ј­2400Ј¬8Ј­4800Ј¬9Ј­9600Ј¬10Ј­19200Ј¬ 11Ј­38400Ј¬12Ј­57600Ј¬13Ј­76800Ј¬14Ј­115.2k;*/
            public byte byDataBit;/* КэѕЭУРјёО» 0Ј­5О»Ј¬1Ј­6О»Ј¬2Ј­7О»Ј¬3Ј­8О» */
            public byte byStopBit;/* НЈЦ№О» 0Ј­1О»Ј¬1Ј­2О» */
            public byte byParity;/* РЈСй 0Ј­ОЮРЈСйЈ¬1Ј­ЖжРЈСйЈ¬2Ј­ЕјРЈСй */
            public byte byFlowcontrol;/* 0Ј­ОЮЈ¬1Ј­ИнБчїШ,2-УІБчїШ */
            public uint dwWorkMode; /* №¤ЧчДЈКЅЈ¬0Ј­232ґ®їЪУГУЪPPPІ¦єЕЈ¬1Ј­232ґ®їЪУГУЪІОКэїШЦЖЈ¬2Ј­НёГчНЁµА */
        }

        //RS232ґ®їЪІОКэЕдЦГ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG_V30
        {
            public uint dwSize;
            public NET_DVR_SINGLE_RS232 struRs232;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }

        //RS232ґ®їЪІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            public uint dwBaudRate;//ІЁМШВК(bps)Ј¬0Ј­50Ј¬1Ј­75Ј¬2Ј­110Ј¬3Ј­150Ј¬4Ј­300Ј¬5Ј­600Ј¬6Ј­1200Ј¬7Ј­2400Ј¬8Ј­4800Ј¬9Ј­9600Ј¬10Ј­19200Ј¬ 11Ј­38400Ј¬12Ј­57600Ј¬13Ј­76800Ј¬14Ј­115.2k;
            public byte byDataBit;// КэѕЭУРјёО» 0Ј­5О»Ј¬1Ј­6О»Ј¬2Ј­7О»Ј¬3Ј­8О»;
            public byte byStopBit;// НЈЦ№О» 0Ј­1О»Ј¬1Ј­2О»;
            public byte byParity;// РЈСй 0Ј­ОЮРЈСйЈ¬1Ј­ЖжРЈСйЈ¬2Ј­ЕјРЈСй;
            public byte byFlowcontrol;// 0Ј­ОЮЈ¬1Ј­ИнБчїШ,2-УІБчїШ
            public uint dwWorkMode;// №¤ЧчДЈКЅЈ¬0Ј­Х­ґшґ«Кд(232ґ®їЪУГУЪPPPІ¦єЕ)Ј¬1Ј­їШЦЖМЁ(232ґ®їЪУГУЪІОКэїШЦЖ)Ј¬2Ј­НёГчНЁµА
            public NET_DVR_PPPCFG struPPPConfig;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESETCHAN_INFO
        {
            public uint dwEnablePresetChan;	/*ЖфУГФ¤ЦГµгµДНЁµА*/
            public uint dwPresetPointNo;		/*µчУГФ¤ЦГµгНЁµА¶ФУ¦µДФ¤ЦГµгРтєЕ, 0xfffffff±нКѕІ»µчУГФ¤ЦГµгЎЈ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISECHAN_INFO
        {
            public uint dwEnableCruiseChan;	/*ЖфУГСІєЅµДНЁµА*/
            public uint dwCruiseNo;		/*СІєЅНЁµА¶ФУ¦µДСІєЅ±аєЕ, 0xfffffff±нКѕОЮР§*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZTRACKCHAN_INFO
        {
            public uint dwEnablePtzTrackChan;	/*ЖфУГФЖМЁ№мјЈµДНЁµА*/
            public uint dwPtzTrackNo;		/*ФЖМЁ№мјЈНЁµА¶ФУ¦µД±аєЕ, 0xfffffff±нКѕОЮР§*/
        }

        //±ЁѕЇКдИлІОКэЕдЦГ(256В·NVRА©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;	/* ГыіЖ */
            public byte byAlarmType;	            //±ЁѕЇЖчАаРН,0ЈєіЈїЄ,1ЈєіЈ±Х
            public byte byAlarmInHandle;	        /* КЗ·сґ¦Ан 0-І»ґ¦Ан 1-ґ¦Ан*/
            public byte byChannel;                 // ±ЁѕЇКдИлґҐ·ўЦЗДЬК¶±рНЁµА
            public byte byRes1;                    //±ЈБф			
            public uint dwHandleType;        //ТміЈґ¦Ан,ТміЈґ¦Ан·ЅКЅµД"»т"Ѕб№ы   
            /*0x00: ОЮПмУ¦*/
            /*0x01: јаКУЖчЙПѕЇёж*/
            /*0x02: ЙщТфѕЇёж*/
            /*0x04: ЙПґ«ЦРРД*/
            /*0x08: ґҐ·ў±ЁѕЇКдіц*/
            /*0x10: ґҐ·ўJPRGЧҐНјІўЙПґ«Email*/
            /*0x20: ОЮПЯЙщ№в±ЁѕЇЖчБЄ¶Ї*/
            /*0x40: БЄ¶ЇµзЧУµШНј(ДїЗ°Ц»УРPCNVRЦ§іЦ)*/
            /*0x200: ЧҐНјІўЙПґ«FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //ґҐ·ўµД±ЁѕЇКдіцНЁµАКэЈЁЦ»¶БЈ©ЧоґуЦ§іЦКэБї
            public uint dwRelAlarmOutChanNum; //ґҐ·ўµД±ЁѕЇКдіцНЁµАКэ КµјКЦ§іЦКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //ґҐ·ў±ЁѕЇНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            /*ґҐ·ўµДВјПсНЁµА*/
            public uint dwMaxRecordChanNum;   //Йи±ёЦ§іЦµДЧоґу№ШБЄВјПсНЁµАКэ-Ц»¶Б
            public uint dwCurRecordChanNum;    //µ±З°КµјКТСЕдЦГµД№ШБЄВјПсНЁµАКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;	 /* КµјКґҐ·ўВјПсНЁµАЈ¬°ґЦµ±нКѕ,ІЙУГЅфґХРНЕЕБРЈ¬ґУПВ±к0 - dwCurRecordChanNum -1УРР§Ј¬Из№ыЦРјдУцµЅ0xffffffff,ФтєуРшОЮР§*/ 
            public uint dwMaxEnablePtzCtrlNun; //ЧоґуїЙЖфУГµДФЖМЁїШЦЖЧЬКэ(Ц»¶Б)
            public uint dwEnablePresetChanNum;  //µ±З°ТСЖфУГФ¤ЦГµгµДКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo; //ЖфУГµДФ¤ЦГµгРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;					/*±ЈБф*/
            public uint dwEnableCruiseChanNum;  //µ±З°ТСЖфУГСІєЅµДНЁµАКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo; //ЖфУГСІєЅ№¦ДЬНЁµАµДРЕПў
            public uint dwEnablePtzTrackChanNum;  //µ±З°ТСЖфУГСІєЅµДНЁµАКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo; //µчУГФЖМЁ№мјЈµДНЁµАРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±ЁѕЇКдИлІОКэЕдЦГ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* ГыіЖ */
            public byte byAlarmType; //±ЁѕЇЖчАаРН,0ЈєіЈїЄ,1ЈєіЈ±Х
            public byte byAlarmInHandle; /* КЗ·сґ¦Ан 0-І»ґ¦Ан 1-ґ¦Ан*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* КЗ·сµчУГФ¤ЦГµг 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µчУГµДФЖМЁФ¤ЦГµгРтєЕ,Т»ёц±ЁѕЇКдИлїЙТФµчУГ¶аёцНЁµАµДФЖМЁФ¤ЦГµг, 0xff±нКѕІ»µчУГФ¤ЦГµгЎЈ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±ЈБф*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* КЗ·сµчУГСІєЅ 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* СІєЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* КЗ·сµчУГ№мјЈ 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µчУГµДФЖМЁµД№мјЈРтєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IO_ALARM
        {
            public uint	dwAlarmInputNo;		//·ўЙъ±ЁѕЇµД±ЁѕЇКдИлНЁµАєЕЈ¬Т»ґОЦ»УРТ»ёц
            public uint	dwTrigerAlarmOutNum;	/*ґҐ·ўµД±ЁѕЇКдіцёцКэЈ¬УГУЪєуГжјЖЛг±ді¤КэѕЭІї·ЦЦРЛщУРґҐ·ўµД±ЁѕЇКдіцНЁµАєЕЈ¬ЛДЧЦЅЪ±нКѕТ»ёц*/
            public uint	dwTrigerRecordChanNum;	/*ґҐ·ўµДВјПсНЁµАёцКэЈ¬УГУЪєуГжјЖЛг±ді¤КэѕЭІї·ЦЦРЛщУРґҐ·ўµДВјПсНЁµАєЕЈ¬ЛДЧЦЅЪ±нКѕТ»ёц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_CHANNEL
        {
            public uint	dwAlarmChanNum;	/*·ўЙъ±ЁѕЇНЁµАКэѕЭёцКэЈ¬УГУЪєуГжјЖЛг±ді¤КэѕЭІї·ЦЦРЛщУР·ўЙъµД±ЁѕЇНЁµАєЕЈ¬ЛДЧЦЅЪ±нКѕТ»ёц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_HD
        {
            public uint	dwAlarmHardDiskNum;	/*·ўЙъ±ЁѕЇµДУІЕМКэѕЭі¤¶ИЈ¬УГУЪєуГжјЖЛг±ді¤КэѕЭІї·ЦЦРЛщУР·ўЙъ±ЁѕЇµДУІЕМєЕЈ¬ЛДЅЪ±нКѕТ»ёц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ALARMINFO_FIXED
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;
            [FieldOffset(0)]
            public STRUCT_IO_ALARM struIOAlarm;// ±ЁѕЇАаРНdwAlarmTypeОЄ0К±УРР§
            [FieldOffset(0)]
            public STRUCT_ALARM_CHANNEL struAlarmChannel; // dwAlarmTypeОЄ2Ј¬3Ј¬6Ј¬9Ј¬10»т13К±УРР§
            [FieldOffset(0)]
            public STRUCT_ALARM_HD struAlarmHardDisk; // dwAlarmTypeОЄ1,4,5К±УРР§           
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALRAM_FIXED_HEADER
        {
            public uint dwAlarmType;              /*0-РЕєЕБї±ЁѕЇ,1-УІЕМВъ,2-РЕєЕ¶ЄК§Ј¬3Ј­ТЖ¶ЇХмІвЈ¬4Ј­УІЕМОґёсКЅ»Ї,5-РґУІЕМіцґн,6-ХЪµІ±ЁѕЇЈ¬7-ЦЖКЅІ»ЖҐЕд, 8-·З·Ё·ГОКЈ¬9-КУЖµРЕєЕТміЈЈ¬10-ВјПсТміЈЈ¬11-ЦЗДЬіЎѕ°±д»ЇЈ¬12-ХуБРТміЈЈ¬13-З°¶Л/ВјПс·Ц±жВКІ»ЖҐЕд*/
            public NET_DVR_TIME_EX struAlarmTime;	//·ўЙъ±ЁѕЇµДК±јд
            public UNION_ALARMINFO_FIXED uStruAlarm;
        }

       [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V40
       {
            public NET_DVR_ALRAM_FIXED_HEADER struAlarmFixedHeader;	//±ЁѕЇ№М¶ЁІї·Ц
            public IntPtr pAlarmData;	//±ЁѕЇїЙ±дІї·ЦДЪИЭ
       }

        //±ЁѕЇКдИлІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* ГыіЖ */
            public byte byAlarmType;//±ЁѕЇЖчАаРН,0ЈєіЈїЄ,1ЈєіЈ±Х
            public byte byAlarmInHandle;/* КЗ·сґ¦Ан 0-І»ґ¦Ан 1-ґ¦Ан*/
            public byte byChannel;     // ±ЁѕЇКдИлґҐ·ўЦЗДЬК¶±рНЁµА
            public byte byRes;                     
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;/* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* КЗ·сµчУГФ¤ЦГµг 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* µчУГµДФЖМЁФ¤ЦГµгРтєЕ,Т»ёц±ЁѕЇКдИлїЙТФµчУГ¶аёцНЁµАµДФЖМЁФ¤ЦГµг, 0xff±нКѕІ»µчУГФ¤ЦГµгЎЈ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* КЗ·сµчУГСІєЅ 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* СІєЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* КЗ·сµчУГ№мјЈ 0-·с,1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* µчУГµДФЖМЁµД№мјЈРтєЕ */
        }

        //ДЈДв±ЁѕЇКдИлІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOG_ALARMINCFG
        {
            public uint dwSize;
            public byte	byEnableAlarmHandle; //ґ¦Ан±ЁѕЇКдИл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInName; //ДЈДв±ЁѕЇКдИлГыіЖ
            public ushort wAlarmInUpper; //ДЈДвКдИлµзС№ЙППЮЈ¬КµјКЦµіЛ10Ј¬·¶О§0~360
            public ushort wAlarmInLower; //ДЈДвКдИлµзС№ПВПЮЈ¬КµјКЦµіЛ10Ј¬·¶О§0~360 
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;	/* ґ¦Ан·ЅКЅ */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±»ґҐ·ўµДВјПсНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ЙПґ«±ЁѕЇРЕПў(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V30
        {
            public uint dwAlarmType;/*0-РЕєЕБї±ЁѕЇ,1-УІЕМВъ,2-РЕєЕ¶ЄК§,3Ј­ТЖ¶ЇХмІв,4Ј­УІЕМОґёсКЅ»Ї,5-¶БРґУІЕМіцґн,6-ХЪµІ±ЁѕЇ,7-ЦЖКЅІ»ЖҐЕд, 8-·З·Ё·ГОК, 0xa-GPS¶ЁО»РЕПў(іµФШ¶ЁЦЖ)*/
            public uint dwAlarmInputNumber;/*±ЁѕЇКдИл¶ЛїЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutputNumber;/*ґҐ·ўµДКдіц¶ЛїЪЈ¬ОЄ1±нКѕ¶ФУ¦Кдіц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmRelateChannel;/*ґҐ·ўµДВјПсНЁµАЈ¬ОЄ1±нКѕ¶ФУ¦ВјПс, dwAlarmRelateChannel[0]¶ФУ¦µЪ1ёцНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*dwAlarmTypeОЄ2»т3,6К±Ј¬±нКѕДДёцНЁµАЈ¬dwChannel[0]¶ФУ¦µЪ1ёцНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskNumber;/*dwAlarmTypeОЄ1,4,5К±,±нКѕДДёцУІЕМ, dwDiskNumber[0]¶ФУ¦µЪ1ёцУІЕМ*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                byAlarmRelateChannel = new byte[MAX_CHANNUM_V30];
                byChannel = new byte[MAX_CHANNUM_V30];
                byAlarmOutputNumber = new byte[MAX_ALARMOUT_V30];
                byDiskNumber = new byte[MAX_DISKNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_HOT_SPARE
        {
            public uint dwSize;   //Ѕб№№Ме
            public uint dwExceptionCase;   //±ЁѕЇФ­Тт   0-НшВзТміЈ
            public NET_DVR_IPADDR  struDeviceIP;    //ІъЙъТміЈµДЙи±ёIPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO
        {
            public int dwAlarmType;/*0-РЕєЕБї±ЁѕЇ,1-УІЕМВъ,2-РЕєЕ¶ЄК§,3Ј­ТЖ¶ЇХмІв,4Ј­УІЕМОґёсКЅ»Ї,5-¶БРґУІЕМіцґн,6-ХЪµІ±ЁѕЇ,7-ЦЖКЅІ»ЖҐЕд, 8-·З·Ё·ГОК, 9-ґ®їЪЧґМ¬, 0xa-GPS¶ЁО»РЕПў(іµФШ¶ЁЦЖ)*/
            public int dwAlarmInputNumber;/*±ЁѕЇКдИл¶ЛїЪ, µ±±ЁѕЇАаРНОЄ9К±ёГ±дБї±нКѕґ®їЪЧґМ¬0±нКѕХэіЈЈ¬ -1±нКѕґнОу*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmOutputNumber;/*ґҐ·ўµДКдіц¶ЛїЪЈ¬ДДТ»О»ОЄ1±нКѕ¶ФУ¦ДДТ»ёцКдіц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmRelateChannel;/*ґҐ·ўµДВјПсНЁµАЈ¬ДДТ»О»ОЄ1±нКѕ¶ФУ¦ДДТ»В·ВјПс, dwAlarmRelateChannel[0]¶ФУ¦µЪ1ёцНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwChannel;/*dwAlarmTypeОЄ2»т3,6К±Ј¬±нКѕДДёцНЁµАЈ¬dwChannel[0]О»¶ФУ¦µЪ1ёцНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwDiskNumber;/*dwAlarmTypeОЄ1,4,5К±,±нКѕДДёцУІЕМ, dwDiskNumber[0]О»¶ФУ¦µЪ1ёцУІЕМ*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                dwAlarmOutputNumber = new int[MAX_ALARMOUT];
                dwAlarmRelateChannel = new int[MAX_CHANNUM];
                dwChannel = new int[MAX_CHANNUM];
                dwDiskNumber = new int[MAX_DISKNUM];
                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////
        //IPCЅУИлІОКэЕдЦГ
        /* IPЙи±ёЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO
        {
            public uint dwEnable;/* ёГIPЙи±ёКЗ·сЖфУГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /* ГЬВл */
            public NET_DVR_IPADDR struIP;/* IPµШЦ· */
            public ushort wDVRPort;/* ¶ЛїЪєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±ЈБф */

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byRes = new byte[34];
            }
        }

        //ipcЅУИлЙи±ёРЕПўА©Х№Ј¬Ц§іЦipЙи±ёµДУтГыМнјУ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO_V31
        {
            public byte byEnable;//ёГIPЙи±ёКЗ·сУРР§
            public byte byProType;
            public byte byEnableQuickAdd;
            public byte byRes1;//±ЈБфЧЦ¶ОЈ¬ЦГ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;//УГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;//ГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;//Йи±ёУтГы
            public NET_DVR_IPADDR struIP;//IPµШЦ·
            public ushort wDVRPort;// ¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБфЧЦ¶ОЈ¬ЦГ0

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byDomain = new byte[MAX_DOMAIN_NAME];
                byRes2 = new byte[34];
            }
        }

        /* IPНЁµАЖҐЕдІОКэ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO
        {
            public byte byEnable;/* ёГНЁµАКЗ·сФЪПЯ */
            public byte byIPID;/* IPЙи±ёID ИЎЦµ1- MAX_IP_DEVICE */
            public byte byChannel;/* НЁµАєЕ */
            public byte byIPIDHigh; // IPЙи±ёIDµДёЯ8О»
            public byte byTransProtocol;//ґ«КдР­ТйАаРН0-TCP/auto(ѕЯМеУРЙи±ёѕц¶Ё)Ј¬1-UDP 2-¶аІҐ 3-ЅцTCP 4-auto
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф,ЦГ0
            public void Init()
            {
                byRes = new byte[31];
            }
        }

        /* IPЅУИлЕдЦГЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG
        {
            public uint dwSize;/* Ѕб№№ґуРЎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo;/* IPЙи±ё */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ДЈДвНЁµАКЗ·сЖфУГЈ¬ґУµНµЅёЯ±нКѕ1-32НЁµАЈ¬0±нКѕОЮР§ 1УРР§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPНЁµА */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        /* А©Х№IPЅУИлЕдЦГЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V31
        {
            public uint dwSize;/* Ѕб№№ґуРЎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPЙи±ё */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ДЈДвНЁµАКЗ·сЖфУГЈ¬ґУµНµЅёЯ±нКѕ1-32НЁµАЈ¬0±нКѕОЮР§ 1УРР§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPНЁµА */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO_V31[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSERVER_STREAM
        {
            public byte  byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_IPADDR struIPServer;
            public ushort  wPort;
            public ushort  wDvrNameLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRName;
            public ushort  wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public ushort[]  byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byPassWord;
            public byte  byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDVRName = new byte[NAME_LEN];
                byRes1 = new ushort[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        /*БчГЅМе·юОсЖч»щ±ѕЕдЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
        {
            public byte byValid;/*КЗ·сЖфУГБчГЅМе·юОсЖчИЎБч,0±нКѕОЮР§Ј¬·З0±нКѕУРР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;
            public ushort wDevPort;/*БчГЅМе·юОсЖч¶ЛїЪ*/
            public byte byTransmitType;/*ґ«КдР­ТйАаРН 0-TCPЈ¬1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        //Йи±ёНЁµАРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO
        {
            public NET_DVR_IPADDR struIP;		    //DVR IPµШЦ·
            public ushort wDVRPort;			 	//¶ЛїЪєЕ
            public byte byChannel;				//НЁµАєЕ
            public byte byTransProtocol;		//ґ«КдР­ТйАаРН0-TCPЈ¬1-UDP
            public byte byTransMode;			//ґ«КдВлБчДЈКЅ 0Ј­ЦчВлБч 1Ј­ЧУВлБч
            public byte byFactoryType;			/*З°¶ЛЙи±ёі§јТАаРН,НЁ№эЅУїЪ»сИЎ*/
            public byte byDeviceType; //Йи±ёАаРН(КУЖµЧЫєПЖЅМЁЦЗДЬ°еК№УГ)Ј¬1-ЅвВлЖчЈЁґЛК±ёщѕЭКУЖµЧЫєПЖЅМЁДЬБ¦јЇЦРbyVcaSupportChanModeЧЦ¶ОАґѕц¶ЁКЗК№УГЅвВлНЁµА»№КЗПФКѕНЁµАЈ©Ј¬2-±аВлЖч
            public byte byDispChan;//ПФКѕНЁµАєЕ,ЦЗДЬЕдЦГК№УГ
            public byte bySubDispChan;//ПФКѕНЁµАЧУНЁµАєЕЈ¬ЦЗДЬЕдЦГК±К№УГ
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wґуЖБїШЦЖЖчК№УГЈ¬ґуЖБїШЦЖЖч»бёщѕЭёГІОКэ·ЦЕдЅвВлЧКФґ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;	//Йи±ёУтГы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//јаїШЦч»ъµЗВЅХКєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//јаїШЦч»ъГЬВл
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNS_STREAM_CFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struStreamServer;
            public ushort wStreamServerPort;
            public byte byStreamServerTransmitType;
            public byte byRes2;
            public NET_DVR_IPADDR struIPServer;
            public ushort wIPServerPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;
            public ushort wDVRNameLen;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassWord;
            public ushort wDVRPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
            public byte byChannel;
            public byte byTransProtocol;
            public byte byTransMode;
            public byte byFactoryType;
            public void Init()
            {
                byRes1 = new byte[3];
                byRes3 = new byte[2];
                sDVRName = new byte[NAME_LEN];
                sDVRSerialNumber = new byte[SERIALNO_LEN];
                sUserName = new byte[NAME_LEN];
                sPassWord = new byte[PASSWD_LEN];
                byRes4 = new byte[2];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_URL
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] strURL;
            public byte   byTransPortocol;
            public ushort wIPID;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                strURL = new byte[240];
                byRes = new byte[7];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HKDDNS_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byDDNSDomain;
            public ushort wPort;
            public ushort wAliasLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlias;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDDNSDomain = new byte[64];
                byAlias = new byte[NAME_LEN];
                byRes1 = new byte[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO_V40
        {
            public byte byEnable;				/* ёГНЁµАКЗ·сФЪПЯ */
            public byte byRes1;
            public ushort wIPID;                  //IPЙи±ёID
            public uint dwChannel;				//НЁµАєЕ
            public byte byTransProtocol;		//ґ«КдР­ТйАаРН0-TCPЈ¬1-UDP
            public byte byTransMode;			//ґ«КдВлБчДЈКЅ 0Ј­ЦчВлБч 1Ј­ЧУВлБч
            public byte byFactoryType;			/*З°¶ЛЙи±ёі§јТАаРН,НЁ№эЅУїЪ»сИЎ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_GET_STREAM_UNION
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnion;           
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MODE
        {
            public byte byGetStreamType;/*ИЎБч·ЅКЅЈє0- Ц±ЅУґУЙи±ёИЎБчЈ»1- ґУБчГЅМеИЎБчЈ»2- НЁ№эIPServer»сµГIPµШЦ·єуИЎБчЈ»
                                          * 3- НЁ№эIPServerХТµЅЙи±ёЈ¬ФЩНЁ№эБчГЅМеИЎЙи±ёµДБчЈ» 4- НЁ№эБчГЅМеУЙURLИҐИЎБчЈ»
                                          * 5- НЁ№эhiDDNSУтГыБ¬ЅУЙи±ёИ»єуґУЙи±ёИЎБч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_GET_STREAM_UNION uGetStream;
            public void Init()
            {
                byGetStreamType = 0;
                byRes = new byte[3];
                //uGetStream.Init();
            }
        }

        /* V40А©Х№IPЅУИлЕдЦГЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V40
        {
            public uint dwSize;/* Ѕб№№ґуРЎ */
            public uint dwGroupNum;
            public uint dwAChanNum;
            public uint dwDChanNum;
            public uint dwStartDChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ДЈДвНЁµАКЗ·сЖфУГЈ¬ґУµНµЅёЯ±нКѕ1-32НЁµАЈ¬0±нКѕОЮР§ 1УРР§ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPЙи±ё */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_STREAM_MODE[] struStreamMode;/* IPНЁµА */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; /* ДЈДвНЁµАКЗ·сЖфУГЈ¬ґУµНµЅёЯ±нКѕ1-32НЁµАЈ¬0±нКѕОЮР§ 1УРР§ */
        }

        //ОЄCVRА©Х№µД±ЁѕЇАаРН
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_DEV
        {
            public uint dwAlarmType;  //0-±аВлЖч(НЁµА)РЕєЕБї±ЁѕЇЈ»1-ЛЅУРѕн¶юЛр»µЈ»2- NVR·юОсНЛіцЈ»
	        //3-±аВлЖчЧґМ¬ТміЈЈ»4-ПµНіК±ЦУТміЈЈ»5-ВјПсѕнКЈУаИЭБї№эµНЈ»
	        //6-±аВлЖч(НЁµА)ТЖ¶ЇХмІв±ЁѕЇЈ»7-±аВлЖч(НЁµА)ХЪµІ±ЁѕЇЎЈ
            public NET_DVR_TIME   struTime;     //±ЁѕЇК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±ЈБф
            public uint dwNumber;     //КэДї
            public IntPtr pNO;  //dwNumberёцWORD; ГїёцWORD±нКѕТ»ёцНЁµАєЕЈ¬»тХЯґЕЕМєЕ, ОЮР§К±ОЄ0
        }

        /* ±ЁѕЇКдіцІОКэ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO
        {
            public byte byIPID;/* IPЙи±ёIDИЎЦµ1- MAX_IP_DEVICE */
            public byte byAlarmOut;/* ±ЁѕЇКдіцєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±ЈБф */

            public void Init()
            {
                byRes = new byte[18];
            }
        }

        /* IP±ЁѕЇКдіцЕдЦГЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG
        {
            public uint dwSize; /* Ѕб№№ґуРЎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±ЁѕЇКдіц */

            public void Init()
            {
                struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO[MAX_IP_ALARMOUT];
                for (int i = 0; i < MAX_IP_ALARMOUT; i++)
                {
                    struIPAlarmOutInfo[i].Init();
                }
            }
        }
        /* IP±ЁѕЇКдіцІОКэ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO_V40
        {
            public uint dwIPID;					/* IPЙи±ёID */
            public uint dwAlarmOut;				/* IPЙи±ёID¶ФУ¦µД±ЁѕЇКдіцєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±ЈБф */
        }

        /*IP±ЁѕЇКдіц*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG_V40
        {
            public uint dwSize;  //Ѕб№№Меі¤¶И
            public uint dwCurIPAlarmOutNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO_V40[] struIPAlarmOutInfo;/*IP±ЁѕЇКдіц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /* ±ЁѕЇКдИлІОКэ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO
        {
            public byte byIPID;/* IPЙи±ёIDИЎЦµ1- MAX_IP_DEVICE */
            public byte byAlarmIn;/* ±ЁѕЇКдИлєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ±ЈБф */
        }

        /* IP±ЁѕЇКдИлЕдЦГЅб№№ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG
        {
            public uint dwSize;/* Ѕб№№ґуРЎ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±ЁѕЇКдИл */
        }
        /* IP±ЁѕЇКдИлІОКэ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO_V40
        {
            public uint dwIPID;					/* IPЙи±ёID */
            public uint dwAlarmIn;				/* IPЙи±ёID¶ФУ¦µД±ЁѕЇКдИлєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±ЈБф */
        }
         /*IP±ЁѕЇКдИлЧКФґ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG_V40
        {
            public uint dwSize;  //Ѕб№№Меі¤¶И
            public uint dwCurIPAlarmInNum;  //µ±З°±ЁѕЇКдИлїЪКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN_V40, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_IPALARMININFO_V40[] struIPAlarmInInfo;/* IP±ЁѕЇКдИл*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ipc alarm info
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo; /* IPЙи±ё */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ДЈДвНЁµАКЗ·сЖфУГЈ¬0-ОґЖфУГ 1-ЖфУГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPНЁµА */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP±ЁѕЇКдИл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±ЁѕЇКдіц */
        }

        //ipcЕдЦГёД±д±ЁѕЇРЕПўА©Х№ 9000_1.1
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V31
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IPЙи±ё */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;/* ДЈДвНЁµАКЗ·сЖфУГЈ¬0-ОґЖфУГ 1-ЖфУГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPНЁµА */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo; /* IP±ЁѕЇКдИл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP±ЁѕЇКдіц */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo;           // IPЙи±ё
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;           /* ДЈДвНЁµАКЗ·сЖфУГЈ¬0-ОґЖфУГ 1-ЖфУГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;	        /* IPНЁµА */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;    /* IP±ЁѕЇКдИл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo; /* IP±ЁѕЇКдіц */   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                          // ±ЈБфЧЦЅЪ
        }

        public enum HD_STAT
        {
            HD_STAT_OK = 0,/* ХэіЈ */
            HD_STAT_UNFORMATTED = 1,/* ОґёсКЅ»Ї */
            HD_STAT_ERROR = 2,/* ґнОу */
            HD_STAT_SMART_FAILED = 3,/* SMARTЧґМ¬ */
            HD_STAT_MISMATCH = 4,/* І»ЖҐЕд */
            HD_STAT_IDLE = 5, /* РЭГЯ*/
            NET_HD_STAT_OFFLINE = 6,/*НшВзЕМґ¦УЪОґБ¬ЅУЧґМ¬ */
            HD_RIADVD_EXPAND = 7,    /* РйДвґЕЕМїЙА©ИЭ */
            HD_STAT_REPARING = 10,   /* УІЕМХэФЪРЮёґ(9000 2.0) */
            HD_STAT_FORMATING = 11,   /* УІЕМХэФЪёсКЅ»Ї(9000 2.0) */ 
        }

        //±ѕµШУІЕМРЕПўЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HD
        {
            public uint dwHDNo;/*УІЕМєЕ, ИЎЦµ0~MAX_DISKNUM_V30-1*/
            public uint dwCapacity;/*УІЕМИЭБї(І»їЙЙиЦГ)*/
            public uint dwFreeSpace;/*УІЕМКЈУаїХјд(І»їЙЙиЦГ)*/
            public uint dwHdStatus;/*УІЕМЧґМ¬(І»їЙЙиЦГ) HD_STAT*/
            public byte byHDAttr;/*0-Д¬ИП, 1-ИЯУа; 2-Ц»¶Б*/
            public byte byHDType;/*0-±ѕµШУІЕМ,1-ESATAУІЕМ,2-NASУІЕМ*/
            public byte byDiskDriver;   // Цµ ґъ±нЖдASCIIЧЦ·ы 
            public byte byRes1;
            public uint dwHdGroup; /*КфУЪДДёцЕМЧй 1-MAX_HD_GROUP*/
            public byte byRecycling;   // КЗ·сС­»·АыУГ 0ЈєІ»С­»·АыУГЈ¬1ЈєС­»·АыУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwStorageType;    //°ґО»±нКѕ 0-І»Ц§іЦ ·З0-Ц§іЦ
							// dwStorageType & 0x1 ±нКѕКЗ·сКЗЖХНЁВјПсЧЁУГґжґўЕМ     
							// dwStorageType & 0x2  ±нКѕКЗ·сКЗійЦЎВјПсЧЁУГґжґўЕМ
							// dwStorageType & 0x4 ±нКѕКЗ·сКЗНјЖ¬ВјПсЧЁУГґжґўЕМ

            public uint dwPictureCapacity; //УІЕМНјЖ¬ИЭБї(І»їЙЙиЦГ)Ј¬µҐО»:MB
            public uint dwFreePictureSpace; //КЈУаНјЖ¬їХјд(І»їЙЙиЦГ)Ј¬µҐО»:MB
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            public uint dwHDCount;/*УІЕМКэ(І»їЙЙиЦГ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HD[] struHDInfo;//УІЕМПа№ШІЩЧч¶јРиТЄЦШЖфІЕДЬЙъР§Ј»
        }

        //±ѕµШЕМЧйРЕПўЕдЦГА©Х№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP_V40
        {
            public uint dwHDGroupNo;       /*ЕМЧйєЕ(І»їЙЙиЦГ) 1-MAX_HD_GROUP*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;  //ґҐ·ўµДВјПсНЁµАЈ¬°ґЦµ±нКѕЈ¬УцµЅ0xffffffffК±єуРшКУОЄОЮР§    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ±ЈБф */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG_V40
        {
            public uint dwSize;                //Ѕб№№МеґуРЎ
            public uint dwMaxHDGroupNum; 		  //Йи±ёЦ§іЦµДЧоґуЕМЧйКэ-Ц»¶Б
            public uint dwCurHDGroupNum;       /*µ±З°ЕдЦГµДЕМЧйКэ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP_V40[] struHDGroupAttr; //УІЕМПа№ШІЩЧч¶јРиТЄЦШЖфІЕДЬЙъР§Ј»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        //±ѕµШЕМЧйРЕПўЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP
        {
            public uint dwHDGroupNo;/*ЕМЧйєЕ(І»їЙЙиЦГ) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDGroupChans;/*ЕМЧй¶ФУ¦µДВјПсНЁµА, 0-±нКѕёГНЁµАІ»ВјПуµЅёГЕМЧйЈ¬1-±нКѕВјПуµЅёГЕМЧй*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            public uint dwHDGroupCount;/*ЕМЧйЧЬКэ(І»їЙЙиЦГ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;//УІЕМПа№ШІЩЧч¶јРиТЄЦШЖфІЕДЬЙъР§
        }

        //ЕдЦГЛх·ЕІОКэµДЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            public uint dwMajorScale;/* ЦчПФКѕ 0-І»Лх·ЕЈ¬1-Лх·Е*/
            public uint dwMinorScale;/* ёЁПФКѕ 0-І»Лх·ЕЈ¬1-Лх·Е*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //DVR±ЁѕЇКдіц(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* ГыіЖ */
            public uint dwAlarmOutDelay;/* Кдіц±ЈіЦК±јд(-1ОЄОЮПЮЈ¬КЦ¶Ї№Ш±Х) */
            //0-5Гл,1-10Гл,2-30Гл,3-1·ЦЦУ,4-2·ЦЦУ,5-5·ЦЦУ,6-10·ЦЦУ,7-КЦ¶Ї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±ЁѕЇКдіцј¤»оК±јд¶О */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±ЁѕЇКдіц
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* ГыіЖ */
            public uint dwAlarmOutDelay;/* Кдіц±ЈіЦК±јд(-1ОЄОЮПЮЈ¬КЦ¶Ї№Ш±Х) */
            //0-5Гл,1-10Гл,2-30Гл,3-1·ЦЦУ,4-2·ЦЦУ,5-5·ЦЦУ,6-10·ЦЦУ,7-КЦ¶Ї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* ±ЁѕЇКдіцј¤»оК±јд¶О */
        }

        //DVR±ѕµШФ¤ААІОКэ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ф¤ААКэДї,0-1»­Гж,1-4»­Гж,2-9»­Гж,3-16»­Гж,0xff:Чоґу»­Гж
            public byte byEnableAudio;//КЗ·сЙщТфФ¤АА,0-І»Ф¤АА,1-Ф¤АА
            public ushort wSwitchTime;//ЗР»»К±јд,0-І»ЗР»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PREVIEW_MODE * MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//ЗР»»ЛіРт,Из№ыlSwitchSeq[i]ОЄ 0xff±нКѕІ»УГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR±ѕµШФ¤ААІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ф¤ААКэДї,0-1»­Гж,1-4»­Гж,2-9»­Гж,3-16»­Гж,0xff:Чоґу»­Гж
            public byte byEnableAudio;//КЗ·сЙщТфФ¤АА,0-І»Ф¤АА,1-Ф¤АА
            public ushort wSwitchTime;//ЗР»»К±јд,0-І»ЗР»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//ЗР»»ЛіРт,Из№ыlSwitchSeq[i]ОЄ 0xff±нКѕІ»УГ
        }

        //DVRКУЖµКдіц
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGAPARA
        {
            public ushort wResolution;/* ·Ц±жВК */
            public ushort wFreq;/* ЛўРВЖµВК */
            public uint dwBrightness;/* ББ¶И */
        }

        //MATRIXКдіцІОКэЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOrder;/* Ф¤ААЛіРт, 0xff±нКѕПаУ¦µДґ°їЪІ»Ф¤АА */
            public ushort wSwitchTime;// Ф¤ААЗР»»К±јд 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA
        {
            public ushort wDisplayLogo;/* ПФКѕКУЖµНЁµАєЕ */
            public ushort wDisplayOsd;/* ПФКѕК±јд */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOOUT
        {
            public byte byVideoFormat;/* КдіцЦЖКЅ,0-PAL,1-NTSC */
            public byte byMenuAlphaValue;/* ІЛµҐУл±іѕ°НјПу¶Ф±И¶И */
            public ushort wScreenSaveTime;/* ЖБД»±Ј»¤К±јд 0-ґУІ»,1-1·ЦЦУ,2-2·ЦЦУ,3-5·ЦЦУ,4-10·ЦЦУ,5-20·ЦЦУ,6-30·ЦЦУ */
            public ushort wVOffset;/* КУЖµКдіцЖ«ТЖ */
            public ushort wBrightness;/* КУЖµКдіцББ¶И */
            public byte byStartMode;/* Жф¶ЇєуКУЖµКдіцДЈКЅ(0:ІЛµҐ,1:Ф¤АА)*/
            public byte byEnableScaler;/* КЗ·сЖф¶ЇЛх·Е (0-І»Жф¶Ї, 1-Жф¶Ї)*/
        }

        //DVRКУЖµКдіц(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;/* VGAІОКэ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MATRIXOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;/* MATRIXІОКэ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRКУЖµКдіц
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;	/* VGAІОКэ */
            public NET_DVR_MATRIXPARA struMatrixPara;/* MATRIXІОКэ */
        }

        //µҐУГ»§ІОКэ(ЧУЅб№№)(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;			/* УГ»§ГыЦ»ДЬУГ16ЧЦЅЪ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;			/* ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;	/* ±ѕµШИЁПЮ */
            /*КэЧй0: ±ѕµШїШЦЖФЖМЁ*/
            /*КэЧй1: ±ѕµШКЦ¶ЇВјПу*/
            /*КэЧй2: ±ѕµШ»Ш·Е*/
            /*КэЧй3: ±ѕµШЙиЦГІОКэ*/
            /*КэЧй4: ±ѕµШІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: ±ѕµШёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: ±ѕµШІйїґІОКэ */
            /*КэЧй7: ±ѕµШ№ЬАнДЈДвєНIP camera */
            /*КэЧй8: ±ѕµШ±ё·Э */
            /*КэЧй9: ±ѕµШ№Ш»ъ/ЦШЖф */    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Ф¶іМИЁПЮ */	
            /*КэЧй0: Ф¶іМїШЦЖФЖМЁ*/
            /*КэЧй1: Ф¶іМКЦ¶ЇВјПу*/
            /*КэЧй2: Ф¶іМ»Ш·Е */
            /*КэЧй3: Ф¶іМЙиЦГІОКэ*/
            /*КэЧй4: Ф¶іМІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: Ф¶іМёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: Ф¶іМ·ўЖрУпТф¶ФЅІ*/
            /*КэЧй7: Ф¶іМФ¤АА*/
            /*КэЧй8: Ф¶іМЗлЗу±ЁѕЇЙПґ«Ўў±ЁѕЇКдіц*/
            /*КэЧй9: Ф¶іМїШЦЖЈ¬±ѕµШКдіц*/
            /*КэЧй10: Ф¶іМїШЦЖґ®їЪ*/
            /*КэЧй11: Ф¶іМІйїґІОКэ */
            /*КэЧй12: Ф¶іМ№ЬАнДЈДвєНIP camera */
            /*КэЧй13: Ф¶іМ№Ш»ъ/ЦШЖф */	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;			/* Ф¶іМїЙТФФ¤ААµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;			/* ±ѕµШїЙТФВјПсµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;			/* Ф¶іМїЙТФВјПсµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;			/* ±ѕµШїЙТФ»Ш·ЕµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;			/* Ф¶іМїЙТФ»Ш·ЕµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;				/* ±ѕµШїЙТФPTZµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;				/* Ф¶іМїЙТФPTZµДНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;			/* ±ѕµШ±ё·ЭИЁПЮНЁµАЈ¬ґУЗ°НщєуЛіРтЕЕБРЈ¬УцµЅ0xffffffffєуРшѕщОЄОЮР§*/
            public NET_DVR_IPADDR	struUserIP;				/* УГ»§IPµШЦ·(ОЄ0К±±нКѕФКРнИОєОµШЦ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;	/* ОпАнµШЦ· */
            public byte byPriority;				/* УЕПИј¶Ј¬0xff-ОЮЈ¬0--µНЈ¬1--ЦРЈ¬2--ёЯ */
                                    /* ОЮЎ­Ў­±нКѕІ»Ц§іЦУЕПИј¶µДЙиЦГ
                                    µНЎ­Ў­Д¬ИПИЁПЮ:°ьАЁ±ѕµШєНФ¶іМ»Ш·Е,±ѕµШєНФ¶іМІйїґИХЦѕєНЧґМ¬,±ѕµШєНФ¶іМ№Ш»ъ/ЦШЖф
                                    ЦРЎ­Ў­°ьАЁ±ѕµШєНФ¶іМїШЦЖФЖМЁ,±ѕµШєНФ¶іМКЦ¶ЇВјПс,±ѕµШєНФ¶іМ»Ш·Е,УпТф¶ФЅІєНФ¶іМФ¤ААЎў±ѕµШ±ё·Э,±ѕµШ/Ф¶іМ№Ш»ъ/ЦШЖф
                                    ёЯЎ­Ў­№ЬАнФ± */
            public byte byAlarmOnRight;         // ±ЁѕЇКдИлїЪІј·АИЁПЮ 1-УРИЁПЮЈ¬0-ОЮИЁПЮ
            public byte byAlarmOffRight;         // ±ЁѕЇКдИлїЪі··АИЁПЮ 1-УРИЁПЮЈ¬0-ОЮИЁПЮ
            public byte byBypassRight;           // ±ЁѕЇКдИлїЪЕФВ·ИЁПЮ 1-УРИЁПЮЈ¬0-ОЮИЁПЮ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        //µҐУГ»§ІОКэ(ЧУЅб№№)(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;/* ±ѕµШИЁПЮ */
            /*КэЧй0: ±ѕµШїШЦЖФЖМЁ*/
            /*КэЧй1: ±ѕµШКЦ¶ЇВјПу*/
            /*КэЧй2: ±ѕµШ»Ш·Е*/
            /*КэЧй3: ±ѕµШЙиЦГІОКэ*/
            /*КэЧй4: ±ѕµШІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: ±ѕµШёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: ±ѕµШІйїґІОКэ */
            /*КэЧй7: ±ѕµШ№ЬАнДЈДвєНIP camera */
            /*КэЧй8: ±ѕµШ±ё·Э */
            /*КэЧй9: ±ѕµШ№Ш»ъ/ЦШЖф */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Ф¶іМИЁПЮ */
            /*КэЧй0: Ф¶іМїШЦЖФЖМЁ*/
            /*КэЧй1: Ф¶іМКЦ¶ЇВјПу*/
            /*КэЧй2: Ф¶іМ»Ш·Е */
            /*КэЧй3: Ф¶іМЙиЦГІОКэ*/
            /*КэЧй4: Ф¶іМІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: Ф¶іМёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: Ф¶іМ·ўЖрУпТф¶ФЅІ*/
            /*КэЧй7: Ф¶іМФ¤АА*/
            /*КэЧй8: Ф¶іМЗлЗу±ЁѕЇЙПґ«Ўў±ЁѕЇКдіц*/
            /*КэЧй9: Ф¶іМїШЦЖЈ¬±ѕµШКдіц*/
            /*КэЧй10: Ф¶іМїШЦЖґ®їЪ*/
            /*КэЧй11: Ф¶іМІйїґІОКэ */
            /*КэЧй12: Ф¶іМ№ЬАнДЈДвєНIP camera */
            /*КэЧй13: Ф¶іМ№Ш»ъ/ЦШЖф */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPreviewRight;/* Ф¶іМїЙТФФ¤ААµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPlaybackRight;/* ±ѕµШїЙТФ»Ш·ЕµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPlaybackRight;/* Ф¶іМїЙТФ»Ш·ЕµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRecordRight;/* ±ѕµШїЙТФВјПсµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetRecordRight;/* Ф¶іМїЙТФВјПсµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPTZRight;/* ±ѕµШїЙТФPTZµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPTZRight;/* Ф¶іМїЙТФPTZµДНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalBackupRight;/* ±ѕµШ±ё·ЭИЁПЮНЁµА 0-УРИЁПЮЈ¬1-ОЮИЁПЮ*/
            public NET_DVR_IPADDR struUserIP;/* УГ»§IPµШЦ·(ОЄ0К±±нКѕФКРнИОєОµШЦ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ОпАнµШЦ· */
            public byte byPriority;/* УЕПИј¶Ј¬0xff-ОЮЈ¬0--µНЈ¬1--ЦРЈ¬2--ёЯ */
            /*
            ОЮЎ­Ў­±нКѕІ»Ц§іЦУЕПИј¶µДЙиЦГ
            µНЎ­Ў­Д¬ИПИЁПЮ:°ьАЁ±ѕµШєНФ¶іМ»Ш·Е,±ѕµШєНФ¶іМІйїґИХЦѕєНЧґМ¬,±ѕµШєНФ¶іМ№Ш»ъ/ЦШЖф
            ЦРЎ­Ў­°ьАЁ±ѕµШєНФ¶іМїШЦЖФЖМЁ,±ѕµШєНФ¶іМКЦ¶ЇВјПс,±ѕµШєНФ¶іМ»Ш·Е,УпТф¶ФЅІєНФ¶іМФ¤АА
                  ±ѕµШ±ё·Э,±ѕµШ/Ф¶іМ№Ш»ъ/ЦШЖф
            ёЯЎ­Ў­№ЬАнФ±
            */
            public byte byAlarmOnRight;         // ±ЁѕЇКдИлїЪІј·АИЁПЮ
            public byte byAlarmOffRight;        // ±ЁѕЇКдИлїЪі··АИЁПЮ
            public byte byBypassRight;          // ±ЁѕЇКдИлїЪЕФВ·ИЁПЮ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µҐУГ»§ІОКэ(SDK_V15А©Х№)(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* ИЁПЮ */
            /*КэЧй0: ±ѕµШїШЦЖФЖМЁ*/
            /*КэЧй1: ±ѕµШКЦ¶ЇВјПу*/
            /*КэЧй2: ±ѕµШ»Ш·Е*/
            /*КэЧй3: ±ѕµШЙиЦГІОКэ*/
            /*КэЧй4: ±ѕµШІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: ±ѕµШёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            public uint dwLocalPlaybackRight;/* ±ѕµШїЙТФ»Ш·ЕµДНЁµА bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* ИЁПЮ */
            /*КэЧй0: Ф¶іМїШЦЖФЖМЁ*/
            /*КэЧй1: Ф¶іМКЦ¶ЇВјПу*/
            /*КэЧй2: Ф¶іМ»Ш·Е */
            /*КэЧй3: Ф¶іМЙиЦГІОКэ*/
            /*КэЧй4: Ф¶іМІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: Ф¶іМёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: Ф¶іМ·ўЖрУпТф¶ФЅІ*/
            /*КэЧй7: Ф¶іМФ¤АА*/
            /*КэЧй8: Ф¶іМЗлЗу±ЁѕЇЙПґ«Ўў±ЁѕЇКдіц*/
            /*КэЧй9: Ф¶іМїШЦЖЈ¬±ѕµШКдіц*/
            /*КэЧй10: Ф¶іМїШЦЖґ®їЪ*/
            public uint dwNetPreviewRight;/* Ф¶іМїЙТФФ¤ААµДНЁµА bit0 -- channel 1*/
            public uint dwNetPlaybackRight;/* Ф¶іМїЙТФ»Ш·ЕµДНЁµА bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* УГ»§IPµШЦ·(ОЄ0К±±нКѕФКРнИОєОµШЦ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ОпАнµШЦ· */
        }

        //µҐУГ»§ІОКэ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* ИЁПЮ */
            /*КэЧй0: ±ѕµШїШЦЖФЖМЁ*/
            /*КэЧй1: ±ѕµШКЦ¶ЇВјПу*/
            /*КэЧй2: ±ѕµШ»Ш·Е*/
            /*КэЧй3: ±ѕµШЙиЦГІОКэ*/
            /*КэЧй4: ±ѕµШІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: ±ѕµШёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* ИЁПЮ */
            /*КэЧй0: Ф¶іМїШЦЖФЖМЁ*/
            /*КэЧй1: Ф¶іМКЦ¶ЇВјПу*/
            /*КэЧй2: Ф¶іМ»Ш·Е */
            /*КэЧй3: Ф¶іМЙиЦГІОКэ*/
            /*КэЧй4: Ф¶іМІйїґЧґМ¬ЎўИХЦѕ*/
            /*КэЧй5: Ф¶іМёЯј¶ІЩЧч(Йэј¶Ј¬ёсКЅ»ЇЈ¬ЦШЖфЈ¬№Ш»ъ)*/
            /*КэЧй6: Ф¶іМ·ўЖрУпТф¶ФЅІ*/
            /*КэЧй7: Ф¶іМФ¤АА*/
            /*КэЧй8: Ф¶іМЗлЗу±ЁѕЇЙПґ«Ўў±ЁѕЇКдіц*/
            /*КэЧй9: Ф¶іМїШЦЖЈ¬±ѕµШКдіц*/
            /*КэЧй10: Ф¶іМїШЦЖґ®їЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* УГ»§IPµШЦ·(ОЄ0К±±нКѕФКРнИОєОµШЦ·) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* ОпАнµШЦ· */
        }

        //DVRУГ»§ІОКэ(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V40
        {
            public uint dwSize;  //Ѕб№№МеґуРЎ
            public uint dwMaxUserNum; //Йи±ёЦ§іЦµДЧоґуУГ»§Кэ-Ц»¶Б
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V40[] struUser;  /* УГ»§ІОКэ */
        }

        //DVRУГ»§ІОКэ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V30[] struUser;
        }

        //DVRУГ»§ІОКэ(SDK_V15А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_EX[] struUser;
        }

        //DVRУГ»§ІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO[] struUser;
        }

        //ТміЈІОКэЕдЦГА©Х№Ѕб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V40
        {
            public uint dwSize ;             //Ѕб№№МеґуРЎ
            public uint dwMaxGroupNum ;    //Йи±ёЦ§іЦµДЧоґуЧйКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V41[] struExceptionHandle;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±ЈБф
        } 

        //DVRТміЈІОКэ(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
            /*КэЧй0-ЕМВъ,1- УІЕМіцґн,2-НшПЯ¶П,3-ѕЦУтНшДЪIP µШЦ·іеН», 4-·З·Ё·ГОК, 5-КдИл/КдіцКУЖµЦЖКЅІ»ЖҐЕд, 6-КУЖµРЕєЕТміЈ, 7-ВјПсТміЈ*/
        }

        //DVRТміЈІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
            /*КэЧй0-ЕМВъ,1- УІЕМіцґн,2-НшПЯ¶П,3-ѕЦУтНшДЪIP µШЦ·іеН»,4-·З·Ё·ГОК, 5-КдИл/КдіцКУЖµЦЖКЅІ»ЖҐЕд, 6-КУЖµРЕєЕТміЈ*/
        }

        //НЁµАЧґМ¬(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE_V30
        {
            public byte byRecordStatic;//НЁµАКЗ·сФЪВјПс,0-І»ВјПс,1-ВјПс
            public byte bySignalStatic;//Б¬ЅУµДРЕєЕЧґМ¬,0-ХэіЈ,1-РЕєЕ¶ЄК§
            public byte byHardwareStatic;//НЁµАУІјюЧґМ¬,0-ХэіЈ,1-ТміЈ,АэИзDSPЛАµф
            public byte byRes1;//±ЈБф
            public uint dwBitRate;//КµјКВлВК
            public uint dwLinkNum;//їН»§¶ЛБ¬ЅУµДёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struClientIP;//їН»§¶ЛµДIPµШЦ·
            public uint dwIPLinkNum;//Из№ыёГНЁµАОЄIPЅУИлЈ¬ДЗГґ±нКѕIPЅУИлµ±З°µДБ¬ЅУКэ
            public byte byExceedMaxLink;		// КЗ·сі¬іцБЛµҐВ·6В·Б¬ЅУКэ 0 - Оґі¬іц, 1-і¬іц
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwChannelNo;    //µ±З°µДНЁµАєЕЈ¬0xffffffff±нКѕОЮР§

            public void Init()
            {
                struClientIP = new NET_DVR_IPADDR[MAX_LINK];

                for (int i = 0; i < MAX_LINK; i++)
                {
                    struClientIP[i].Init();
                }
                byRes = new byte[12];
            }
        }

        //НЁµАЧґМ¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE
        {
            public byte byRecordStatic;//НЁµАКЗ·сФЪВјПс,0-І»ВјПс,1-ВјПс
            public byte bySignalStatic;//Б¬ЅУµДРЕєЕЧґМ¬,0-ХэіЈ,1-РЕєЕ¶ЄК§
            public byte byHardwareStatic;//НЁµАУІјюЧґМ¬,0-ХэіЈ,1-ТміЈ,АэИзDSPЛАµф
            public byte reservedData;//±ЈБф
            public uint dwBitRate;//КµјКВлВК
            public uint dwLinkNum;//їН»§¶ЛБ¬ЅУµДёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.U4)]
            public uint[] dwClientIP;//їН»§¶ЛµДIPµШЦ·
        }

        //УІЕМЧґМ¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKSTATE
        {
            public uint dwVolume;//УІЕМµДИЭБї
            public uint dwFreeSpace;//УІЕМµДКЈУаїХјд
            public uint dwHardDiskStatic;//УІЕМµДЧґМ¬,0-»о¶Ї,1-РЭГЯ,2-І»ХэіЈ
        }

        //Йи±ё№¤ЧчЧґМ¬А©Х№Ѕб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V40
        { 
            public uint dwSize ;            //Ѕб№№МеґуРЎ
            public uint dwDeviceStatic; 	 //Йи±ёµДЧґМ¬,0-ХэіЈ,1-CPUХјУГВКМ«ёЯ,і¬№э85%,2-УІјюґнОу,АэИзґ®їЪЛАµф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[]  struHardDiskStatic;   //УІЕМЧґМ¬,Т»ґОЧо¶аЦ»ДЬ»сИЎ33ёцУІЕМРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//НЁµАµДЧґМ¬Ј¬ґУЗ°НщєуЛіРтЕЕБР
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmInStatic; //УР±ЁѕЇµД±ЁѕЇКдИлїЪЈ¬°ґЦµ±нКѕЈ¬°ґПВ±кЦµЛіРтЕЕБРЈ¬ЦµОЄ0xffffffffК±µ±З°ј°єуРшЦµОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmOutStatic; //УР±ЁѕЇКдіцµД±ЁѕЇКдіцїЪЈ¬°ґЦµ±нКѕЈ¬°ґПВ±кЦµЛіРтЕЕБРЈ¬ЦµОЄ0xffffffffК±µ±З°ј°єуРшЦµОЮР§
            public uint dwLocalDisplay;			//±ѕµШПФКѕЧґМ¬,0-ХэіЈ,1-І»ХэіЈ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioInChanStatus;		//°ґО»±нКѕУпТфНЁµАµДЧґМ¬ 0-ОґК№УГЈ¬1-К№УГЦРЈ¬µЪ0О»±нКѕµЪ1ёцУпТфНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 				//±ЈБф
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GETWORKSTATE_COND
        {
            public uint dwSize ;  //Ѕб№№Меі¤¶И
            public byte byFindHardByCond; /*0-ІйХТИ«ІїґЕЕМ(µ«Т»ґОЧо¶аЦ»ДЬІйХТ33ёц)Ј¬ґЛК±dwFindHardStatusNumОЮР§*/
            public byte byFindChanByCond ;  /*0-ІйХТИ«ІїНЁµАЈ¬ґЛК±dwFindChanNumОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindHardStatus ; /*ТЄІйХТµДУІЕМєЕЈ¬°ґЦµ±нКѕЈ¬ёГЦµІЙУГЛіРтЕЕБРЈ¬ УцµЅ0xffffffffФтИПОЄєуРшОЮР§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindChanNo; /*ТЄІйХТµДНЁµАєЕЈ¬°ґЦµ±нКѕЈ¬ёГЦµІЙУГЛіРтЕЕБРЈ¬ УцµЅ0xffffffffФтИПОЄєуРшОЮР§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        //DVR№¤ЧчЧґМ¬(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V30
        {
            public uint dwDeviceStatic;//Йи±ёµДЧґМ¬,0-ХэіЈ,1-CPUХјУГВКМ«ёЯ,і¬№э85%,2-УІјюґнОу,АэИзґ®їЪЛАµф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//НЁµАµДЧґМ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±ЁѕЇ¶ЛїЪµДЧґМ¬,0-Г»УР±ЁѕЇ,1-УР±ЁѕЇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±ЁѕЇКдіц¶ЛїЪµДЧґМ¬,0-Г»УРКдіц,1-УР±ЁѕЇКдіц
            public uint dwLocalDisplay;//±ѕµШПФКѕЧґМ¬,0-ХэіЈ,1-І»ХэіЈ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioChanStatus;//±нКѕУпТфНЁµАµДЧґМ¬ 0-ОґК№УГЈ¬1-К№УГЦР, 0xffОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM_V30];
                struChanStatic = new NET_DVR_CHANNELSTATE_V30[MAX_CHANNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    struChanStatic[i].Init();
                }
                byAlarmInStatic = new byte[MAX_ALARMOUT_V30];
                byAlarmOutStatic = new byte[MAX_ALARMOUT_V30];
                byAudioChanStatus = new byte[MAX_AUDIO_V30];
                byRes = new byte[10];
            }
        }

        //DVR№¤ЧчЧґМ¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE
        {
            public uint dwDeviceStatic;//Йи±ёµДЧґМ¬,0-ХэіЈ,1-CPUХјУГВКМ«ёЯ,і¬№э85%,2-УІјюґнОу,АэИзґ®їЪЛАµф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE[] struChanStatic;//НЁµАµДЧґМ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//±ЁѕЇ¶ЛїЪµДЧґМ¬,0-Г»УР±ЁѕЇ,1-УР±ЁѕЇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//±ЁѕЇКдіц¶ЛїЪµДЧґМ¬,0-Г»УРКдіц,1-УР±ЁѕЇКдіц
            public uint dwLocalDisplay;//±ѕµШПФКѕЧґМ¬,0-ХэіЈ,1-І»ХэіЈ

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM];
                struChanStatic = new NET_DVR_CHANNELSTATE[MAX_CHANNUM];
                byAlarmInStatic = new byte[MAX_ALARMIN];
                byAlarmOutStatic = new byte[MAX_ALARMOUT];
            }
        }        

        //ИХЦѕРЕПў(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//ЦчАаРН 1-±ЁѕЇ; 2-ТміЈ; 3-ІЩЧч; 0xff-И«Ії
            public uint dwMinorType;//ґОАаРН 0-И«Ії;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//ІЩЧчГж°еµДУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//НшВзІЩЧчµДУГ»§Гы
            public NET_DVR_IPADDR struRemoteHostAddr;//Ф¶іМЦч»ъµШЦ·
            public uint dwParaType;//ІОКэАаРН
            public uint dwChannel;//НЁµАєЕ
            public uint dwDiskNumber;//УІЕМєЕ
            public uint dwAlarmInPort;//±ЁѕЇКдИл¶ЛїЪ
            public uint dwAlarmOutPort;//±ЁѕЇКдіц¶ЛїЪ
            public uint dwInfoLen;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;
        }

        //ИХЦѕРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//ЦчАаРН 1-±ЁѕЇ; 2-ТміЈ; 3-ІЩЧч; 0xff-И«Ії
            public uint dwMinorType;//ґОАаРН 0-И«Ії;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//ІЩЧчГж°еµДУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//НшВзІЩЧчµДУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteHostAddr;//Ф¶іМЦч»ъµШЦ·
            public uint dwParaType;//ІОКэАаРН
            public uint dwChannel;//НЁµАєЕ
            public uint dwDiskNumber;//УІЕМєЕ
            public uint dwAlarmInPort;//±ЁѕЇКдИл¶ЛїЪ
            public uint dwAlarmOutPort;//±ЁѕЇКдіц¶ЛїЪ
        }

        /************************¶Ї»·±ЁѕЇ№ЬАнЦч»ъИХЦѕІйХТ begin************************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
        {
            public ushort wMajorType;		// ЦчАаРН
            public ushort wMinorType;		// ґОАаРН 
            public NET_DVR_TIME    struStartTime;	// їЄКјК±јд 
            public NET_DVR_TIME    struEndTime;	// ЅбКшК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_LOG_RET
        {
            public NET_DVR_TIME	struLogTime;                //  ИХЦѕК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;     // ІЩЧчУГ»§
            public NET_DVR_IPADDR	struIPAddr;                 // ІЩЧчIPµШЦ·
            public ushort wMajorType;                 // ЦчАаРН 
            public ushort wMinorType;                 // ґОАаРН
            public ushort wParam;	                    // ІЩЧчІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwInfoLen;	                // ГиКцРЕПўі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;       // ГиКцРЕПў
        }
        /*************************¶Ї»·±ЁѕЇ№ЬАнЦч»ъИХЦѕІйХТ end***********************************************/

        //±ЁѕЇКдіцЧґМ¬(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;

            public void Init()
            {
                Output = new byte[MAX_ALARMOUT_V30];
            }
        }

        //±ЁѕЇКдіцЧґМ¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;
        }        

        //ATMЧЁУГ
        /****************************ATM(begin)***************************/
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;

        //Ѕ»ТЧРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_TRADEINFO
        {
            public ushort m_Year;
            public ushort m_Month;
            public ushort m_Day;
            public ushort m_Hour;
            public ushort m_Minute;
            public ushort m_Second;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] DeviceName;//Йи±ёГыіЖ
            public uint dwChannelNumer;//НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] CardNumber;//їЁєЕ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string cTradeType;//Ѕ»ТЧАаРН
            public uint dwCash;//Ѕ»ТЧЅр¶о
        }

        /*ЦЎёсКЅ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FRAMETYPECODE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] code;/* ґъВл */
        }
        
        //ATMІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sATMIP;/* ATM IPµШЦ· */
            public uint dwATMType;/* ATMАаРН */
            public uint dwInputMode;/* КдИл·ЅКЅ	0-НшВзХмМэ 1-НшВзЅУКХ 2-ґ®їЪЦ±ЅУКдИл 3-ґ®їЪATMГьБоКдИл*/
            public uint dwFrameSignBeginPos;/* ±ЁОД±кЦѕО»µДЖрКјО»ЦГ*/
            public uint dwFrameSignLength;/* ±ЁОД±кЦѕО»µДі¤¶И */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byFrameSignContent;/* ±ЁОД±кЦѕО»µДДЪИЭ */
            public uint dwCardLengthInfoBeginPos;/* їЁєЕі¤¶ИРЕПўµДЖрКјО»ЦГ */
            public uint dwCardLengthInfoLength;/* їЁєЕі¤¶ИРЕПўµДі¤¶И */
            public uint dwCardNumberInfoBeginPos;/* їЁєЕРЕПўµДЖрКјО»ЦГ */
            public uint dwCardNumberInfoLength;/* їЁєЕРЕПўµДі¤¶И */
            public uint dwBusinessTypeBeginPos;/* Ѕ»ТЧАаРНµДЖрКјО»ЦГ */
            public uint dwBusinessTypeLength;/* Ѕ»ТЧАаРНµДі¤¶И */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;/* АаРН */
        }

        //SDK_V31 ATM
        /*№эВЛЙиЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILTER
        {
            public byte byEnable;/*0,І»ЖфУГ;1,ЖфУГ*/
            public byte byMode;/*0,ASCII;1,HEX*/
            public byte byFrameBeginPos;// ±ЁОД±кЦѕО»µДЖрКјО»ЦГ     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byFilterText;/*№эВЛЧЦ·ыґ®*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*ЖрКј±кК¶ЙиЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICAT
        {
            public byte byStartMode;/*0,ASCII;1,HEX*/
            public byte byEndMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_FRAMETYPECODE struStartCode;/*ЖрКјЧЦ·ы*/
            public NET_DVR_FRAMETYPECODE struEndCode;/*ЅбКшЧЦ·ы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        /*±ЁОДРЕПўО»ЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LOCATION
        {
            public byte byOffsetMode;/*0,token;1,fix*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwOffsetPos;/*modeОЄ1µДК±єтК№УГ*/
            public NET_DVR_FRAMETYPECODE struTokenCode;/*±кЦѕО»*/
            public byte byMultiplierValue;/*±кЦѕО»¶аЙЩґОіцПЦ*/
            public byte byEternOffset;/*ёЅјУµДЖ«ТЖБї*/
            public byte byCodeMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*±ЁОДРЕПўі¤¶И*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LENGTH
        {
            public byte byLengthMode;/*і¤¶ИАаРНЈ¬0,variable;1,fix;2,get from package(ЙиЦГїЁєЕі¤¶ИК№УГ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFixLength;/*modeОЄ1µДК±єтК№УГ*/
            public uint dwMaxLength;
            public uint dwMinLength;
            public byte byEndMode;/*ЦХЅб·ы0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_FRAMETYPECODE struEndCode;/*ЦХЅб·ы*/
            public uint dwLengthPos;/*lengthModeОЄ2µДК±єтК№УГЈ¬їЁєЕі¤¶ИФЪ±ЁОДЦРµДО»ЦГ*/
            public uint dwLengthLen;/*lengthModeОЄ2µДК±єтК№УГЈ¬їЁєЕі¤¶ИµДі¤¶И*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*OSD µюјУµДО»ЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSD_POSITION
        {
            public byte byPositionMode;/*µюјУ·зёсЈ¬№І2ЦЦЈ»0Ј¬І»ПФКѕЈ»1Ј¬Custom*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPos_x;/*xЧш±кЈ¬positionmodeОЄCustomК±К№УГ*/
            public uint dwPos_y;/*yЧш±кЈ¬positionmodeОЄCustomК±К№УГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*ИХЖЪПФКѕёсКЅ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DATE_FORMAT
        {
            public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
            public byte byItem2;/*Day,0.dd;*/
            public byte byItem3;/*Year,0.yy;1.yyyy*/
            public byte byDateForm;/*0~5Ј¬3ёцitemµДЕЕБРЧйєП*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*·Цёф·ы*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*ПФКѕ·Цёф·ы*/
            public byte byDisplayForm;/*0~5Ј¬3ёцitemµДЕЕБРЧйєП*///lili mode by lili
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        /*К±јдПФКѕёсКЅ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVRT_TIME_FORMAT
        {
            public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*±ЁОД·Цёф·ыЈ¬ФЭК±Г»УГ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*ПФКѕ·Цёф·ы*/
            public byte byDisplayForm;/*0~5Ј¬3ёцitemµДЕЕБРЧйєП*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OVERLAY_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*µюјУµДНЁµА*/
            public uint dwDelayTime;/*µюјУСУК±К±јд*/
            public byte byEnableDelayTime;/*КЗ·сЖфУГµюјУСУК±Ј¬ФЪОЮНЛїЁГьБоК±ЖфУГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_ACTION
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struActionCode;/*Ѕ»ТЧАаРНµИ¶ФУ¦µДВл*/
            public NET_DVR_FRAMETYPECODE struPreCode;/*µюјУЧЦ·ыЗ°µДЧЦ·ы*/
            public byte byActionCodeMode;/*Ѕ»ТЧАаРНµИ¶ФУ¦µДВл0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_DATE
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_DATE_FORMAT struDateForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_TIME
        {
            public NET_DVR_PACKAGE_LOCATION location;
            public NET_DVRT_TIME_FORMAT struTimeForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_OTHERS
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_PACKAGE_LENGTH struPackageLength;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struPreCode;/*µюјУЧЦ·ыЗ°µДЧЦ·ы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //УГ»§ЧФ¶ЁТеР­Тй
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_USER_DEFINE_PROTOCOL
        {
            public NET_DVR_IDENTIFICAT        struIdentification;  //±ЁОД±кЦѕ
            public NET_DVR_FILTER             struFilter; //КэѕЭ°ь№эВЛЙиЦГ
            public NET_DVR_ATM_PACKAGE_OTHERS struCardNoPara; //µюјУїЁєЕЙиЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ACTION_TYPE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara; //µюјУЅ»ТЧРРОЄЙиЦГ 0-9 ТАґО¶ФУ¦InCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
            public NET_DVR_ATM_PACKAGE_OTHERS struAmountPara; //µюјУЅ»ТЧЅр¶оЙиЦГ
            public NET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara; //µюјУЅ»ТЧРтєЕЙиЦГ
            public NET_DVR_OVERLAY_CHANNEL    struOverlayChan; //µюјУНЁµАЙиЦГ
            public NET_DVR_ATM_PACKAGE_DATE   struRes1; //µюјУИХЖЪЈ¬±ЈБф
            public NET_DVR_ATM_PACKAGE_TIME   struRes2; //µюјУК±јдЈ¬±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;        //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_FRAMEFORMAT_V30
        {		
            public uint dwSize;                 //Ѕб№№ґуРЎ
            public byte byEnable;				/*КЗ·сЖфУГ0,І»ЖфУГ;1,ЖфУГ*/
            public byte byInputMode;			/**КдИл·ЅКЅ:0-НшВзјаМэЎў1НшВзР­ТйЎў2-ґ®їЪјаМэЎў3-ґ®їЪР­Тй*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±ЈБфЧЦЅЪ 
            public NET_DVR_IPADDR struAtmIp;				/*ATM »ъIP НшВзјаМэК±К№УГ */
            public ushort wAtmPort;				/* НшВзР­Тй·ЅКЅК±КЗК№УГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // ±ЈБфЧЦЅЪ
            public uint dwAtmType;				/*ATMР­ТйАаРНЈ¬ґУNET_DVR_ATM_PROTOCOLЅб№№ЦР»сИЎЈ¬Из№ыАаРНОЄЧФ¶ЁТеК±К№УГУГ»§ЧФ¶ЁТеР­Тй*/
            public NET_DVR_ATM_USER_DEFINE_PROTOCOL  struAtmUserDefineProtocol; //УГ»§ЧФ¶ЁТеР­ТйЈ¬µ±ATMАаРНОЄЧФ¶ЁК±РиТЄК№УГёГ¶ЁТе
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //Р­ТйРЕПўКэѕЭЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTO_TYPE
        {
            public uint dwAtmType; //ATMР­ТйАаРНЈ¬Н¬К±ЧчОЄЛчТэРтєЕ ATM ЕдЦГЦРµДdwAtmType ЧФ¶ЁТеК±ОЄ1025
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = ATM_DESC_LEN)]
            public string chDesc; //ATMР­ТйјтµҐГиКц
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ATM_PROTO_LIST
        {
            public uint dwAtmProtoNum;/*Р­ТйБР±нµДёцКэ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ATM_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PROTO_TYPE[] struAtmProtoType;/*Р­ТйБР±нРЕПў*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTOCOL
        {
            public uint dwSize;
            public NET_DVR_ATM_PROTO_LIST struNetListenList;     // НшВзјаМэР­ТйГиКц
            public NET_DVR_ATM_PROTO_LIST struSerialListenList; //ґ®їЪјаМэР­ТйГиКц
            public NET_DVR_ATM_PROTO_LIST struNetProtoList;     //НшВзР­ТйГиКц
            public NET_DVR_ATM_PROTO_LIST struSerialProtoList;   //ґ®їЪР­ТйГиКц
            public NET_DVR_ATM_PROTO_TYPE struCustomProto;      //ЧФ¶ЁТеР­Тй            
        }

        /*****************************DS-6001D/F(begin)***************************/
        //DS-6001D Decoder
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчIP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДГЬВл
            public byte bySendMode;//ЅвВлЙи±ёБ¬ЅУ·юОсЖчµДБ¬ЅУДЈКЅ
            public byte byEncoderChannel;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДНЁµАєЕ
            public ushort wEncoderPort;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµД¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERSTATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчIP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДГЬВл
            public byte byEncoderChannel;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДНЁµАєЕ
            public byte bySendMode;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµДБ¬ЅУДЈКЅ
            public ushort wEncoderPort;//ЅвВлЙи±ёБ¬ЅУµД·юОсЖчµД¶ЛїЪєЕ
            public uint dwConnectState;//ЅвВлЙи±ёБ¬ЅУ·юОсЖчµДЧґМ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//±ЈБф
        }

        /*ЅвВлЙи±ёїШЦЖВл¶ЁТе*/
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;

        /*Б¬ЅУµДНЁµАЕдЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµШЦ· */
            public ushort wDVRPort;/* ¶ЛїЪєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            public byte byChannel;/* НЁµАєЕ */
            public byte byLinkMode;/* Б¬ЅУДЈКЅ */
            public byte byLinkType;/* Б¬ЅУАаРН 0Ј­ЦчВлБч 1Ј­ЧУВлБч */
        }

        /*ГїёцЅвВлНЁµАµДЕдЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECINFO
        {
            public byte byPoolChans;/*ГїВ·ЅвВлНЁµАЙПµДС­»·НЁµАКэБї, Чо¶а4НЁµА 0±нКѕГ»УРЅвВл*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECPOOLNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            public byte byEnablePoll;/*КЗ·сВЦСІ 0-·с 1-КЗ*/
            public byte byPoolTime;/*ВЦСІК±јд 0-±ЈБф 1-10Гл 2-15Гл 3-20Гл 4-30Гл 5-45Гл 6-1·ЦЦУ 7-2·ЦЦУ 8-5·ЦЦУ */
        }

        /*ХыёцЙи±ёЅвВлЕдЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            public uint dwDecChanNum;/*ЅвВлНЁµАµДКэБї*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECINFO[] struDecInfo;
        }

        //2005-08-01
        /* ЅвВлЙи±ёНёГчНЁµАЙиЦГ */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PORTINFO
        {
            public uint dwEnableTransPort;/* КЗ·сЖф¶ЇНёГчНЁµА 0Ј­І»ЖфУГ 1Ј­ЖфУГ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµШЦ· */
            public ushort wDecoderPort;/* ¶ЛїЪєЕ */
            public ushort wDVRTransPort;/* ЕдЦГЗ°¶ЛDVRКЗґУ485/232КдіцЈ¬1±нКѕ232ґ®їЪ,2±нКѕ485ґ®їЪ */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cReserve;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRANSPARENTNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PORTINFO[] struTransPortInfo;/* КэЧй0±нКѕ232 КэЧй1±нКѕ485 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]               
        public struct bytime
        {
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/*ЗлЗуКУЖµУГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            public NET_DVR_TIME struStartTime;/* °ґК±јд»Ш·ЕµДїЄКјК±јд */
            public NET_DVR_TIME struStopTime;/* °ґК±јд»Ш·ЕµДЅбКшК±јд */
        }

        /* їШЦЖНшВзОДјю»Ш·Е */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IPµШЦ· */
            public ushort wDecoderPort;/* ¶ЛїЪєЕ */
            public ushort wLoadMode;/* »Ш·ЕПВФШДЈКЅ 1Ј­°ґГыЧЦ 2Ј­°ґК±јд */

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct mode_size
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
                public byte[] byFile;/* »Ш·ЕµДОДјюГы */
                [FieldOffsetAttribute(0)]
                public bytime bytime;
            }
        }



        /*µ±З°Йи±ёЅвВлБ¬ЅУЧґМ¬*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANSTATUS
        {
            public uint dwWorkType;/*№¤Чч·ЅКЅЈє1ЈєВЦСІЎў2Јє¶ЇМ¬Б¬ЅУЅвВлЎў3ЈєОДјю»Ш·ЕПВФШ 4Јє°ґК±јд»Ш·ЕПВФШ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/*Б¬ЅУµДЙи±ёip*/
            public ushort wDVRPort;/*Б¬ЅУ¶ЛїЪєЕ*/
            public byte byChannel;/* НЁµАєЕ */
            public byte byLinkMode;/* Б¬ЅУДЈКЅ */
            public uint dwLinkType;/*Б¬ЅУАаРН 0Ј­ЦчВлБч 1Ј­ЧУВлБч*/

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct objectInfo
            {
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct userInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*ЗлЗуКУЖµУГ»§Гы*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* ГЬВл */
                    [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 52)]
                    public string cReserve;
                }

                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct fileInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                    public byte[] fileName;
                }
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct timeInfo
                {
                    public uint dwChannel;
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*ЗлЗуКУЖµУГ»§Гы*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* ГЬВл */
                    public NET_DVR_TIME struStartTime;/* °ґК±јд»Ш·ЕµДїЄКјК±јд */
                    public NET_DVR_TIME struStopTime;/* °ґК±јд»Ш·ЕµДЅбКшК±јд */
                }
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANSTATUS[] struTransPortInfo;
        }
        /*****************************DS-6001D/F(end)***************************/

        //µҐЧЦ·ыІОКэ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SHOWSTRINGINFO
        {
            public ushort wShowString;// Ф¤ААµДНјПуЙПКЗ·сПФКѕЧЦ·ы,0-І»ПФКѕ,1-ПФКѕ ЗшУтґуРЎ704*576,µҐёцЧЦ·ыµДґуРЎОЄ32*32
            public ushort wStringSize;/* ёГРРЧЦ·ыµДі¤¶ИЈ¬І»ДЬґуУЪ44ёцЧЦ·ы */
            public ushort wShowStringTopLeftX;/* ЧЦ·ыПФКѕО»ЦГµДxЧш±к */
            public ushort wShowStringTopLeftY;/* ЧЦ·ыГыіЖПФКѕО»ЦГµДyЧш±к */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 44)]
            public string sString;/* ТЄПФКѕµДЧЦ·ыДЪИЭ */
        }

        //µюјУЧЦ·ы(9000А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ТЄПФКѕµДЧЦ·ыДЪИЭ */
        }

        //µюјУЧЦ·ыА©Х№(8МхЧЦ·ы)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ТЄПФКѕµДЧЦ·ыДЪИЭ */
        }

        //µюјУЧЦ·ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* ТЄПФКѕµДЧЦ·ыДЪИЭ */
        }

        /****************************DS9000РВФцЅб№№(begin)******************************/
        /*EMAILІОКэЅб№№*/
        //УлФ­Ѕб№№МеУРІоТм
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struReceiver
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sName;/* КХјюИЛРХГы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAddress;/* КХјюИЛµШЦ· */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAccount;/* ХЛєЕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_PWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*ГЬВл */

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct struSender
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sName;/* ·ўјюИЛРХГы */
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sAddress;/* ·ўјюИЛµШЦ· */
            }

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;/* smtp·юОсЖч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;/* pop3·юОсЖч */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
            public struReceiver[] struStringInfo;/* Чо¶аїЙТФЙиЦГ3ёцКХјюИЛ */

            public byte byAttachment;/* КЗ·сґшёЅјю */
            public byte bySmtpServerVerify;/* ·ўЛН·юОсЖчТЄЗуЙн·ЭСйЦ¤ */
            public byte byMailInterval;/* mail interval */
            public byte byEnableSSL;//sslКЗ·сЖфУГ9000_1.1
            public ushort wSmtpPort;//gmailµД465Ј¬ЖХНЁµДОЄ25  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        /*DVRКµПЦСІєЅКэѕЭЅб№№*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* Ф¤ЦГµгєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseSpeed;/* СІєЅЛЩ¶И */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.U2)]
            public ushort[] wDwellTime;/* НЈБфК±јд */
            public byte byEnableThisCruise;/* КЗ·сЖфУГ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }
        /****************************DS9000РВФцЅб№№(end)******************************/     
        //К±јдµг
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMEPOINT
        {
            public uint dwMonth;//ФВ 0-11±нКѕ1-12ёцФВ
            public uint dwWeekNo;//µЪјёЦЬ 0Ј­µЪ1ЦЬ 1Ј­µЪ2ЦЬ 2Ј­µЪ3ЦЬ 3Ј­µЪ4ЦЬ 4Ј­ЧоєуТ»ЦЬ
            public uint dwWeekDate;//РЗЖЪјё 0Ј­РЗЖЪИХ 1Ј­РЗЖЪТ» 2Ј­РЗЖЪ¶ю 3Ј­РЗЖЪИэ 4Ј­РЗЖЪЛД 5Ј­РЗЖЪОе 6Ј­РЗЖЪБщ
            public uint dwHour;//РЎК±	їЄКјК±јд0Ј­23 ЅбКшК±јд1Ј­23
            public uint dwMin;//·Ц	0Ј­59
        }

        //ПДБоК±ІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            public uint dwEnableDST;//КЗ·сЖфУГПДК±ЦЖ 0Ј­І»ЖфУГ 1Ј­ЖфУГ
            public byte byDSTBias;//ПДБоК±Ж«ТЖЦµЈ¬30min, 60min, 90min, 120min, ТФ·ЦЦУјЖЈ¬ґ«µЭФ­КјКэЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_TIMEPOINT struBeginPoint;//ПДК±ЦЖїЄКјК±јд
            public NET_DVR_TIMEPOINT struEndPoint;//ПДК±ЦЖНЈЦ№К±јд
        }

        //НјЖ¬ЦКБї
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGPARA
        {
            /*ЧўТвЈєµ±НјПсС№Лх·Ц±жВКОЄVGAК±Ј¬Ц§іЦ0=CIF, 1=QCIF, 2=D1ЧҐНјЈ¬
	        µ±·Ц±жВКОЄ3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
	        ЅцЦ§іЦµ±З°·Ц±жВКµДЧҐНј*/
            public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
            public ushort wPicQuality;/* НјЖ¬ЦКБїПµКэ 0-ЧоєГ 1-ЅПєГ 2-Т»°г */
        }

        /* aux video out parameter */
        //ёЁЦъКдіцІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            public uint dwAlarmOutChan;/* СЎФс±ЁѕЇµЇіцґу±ЁѕЇНЁµАЗР»»К±јдЈє1»­ГжµДКдіцНЁµА: 0:ЦчКдіц/1:ёЁ1/2:ёЁ2/3:ёЁ3/4:ёЁ4 */
            public uint dwAlarmChanSwitchTime;/* :1Гл - 10:10Гл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAuxSwitchTime;/* ёЁЦъКдіцЗР»»К±јд: 0-І»ЗР»»,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT * MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuxOrder;/* ёЁЦъКдіцФ¤ААЛіРт, 0xff±нКѕПаУ¦µДґ°їЪІ»Ф¤АА */
        }

        //ntp
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NTPPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
            public ushort wInterval;/* adjust time interval(hours) */
            public byte byEnableNTP;/* enable NPT client 0-noЈ¬1-yes*/
            public byte cTimeDifferenceH;/* Ул№ъјК±кЧјК±јдµД РЎК±Ж«ТЖ-12 ... +13 */
            public byte cTimeDifferenceM;/* Ул№ъјК±кЧјК±јдµД ·ЦЦУЖ«ТЖ0, 30, 45*/
            public byte res1;
            public ushort wNtpPort; /* ntp server port 9000РВФц Йи±ёД¬ИПОЄ123*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;
        }

        //ddns
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSХЛєЕУГ»§Гы/ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName; /* УтГы */
            public byte byEnableDDNS;/*КЗ·сУ¦УГ 0-·сЈ¬1-КЗ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_EX
        {
            public byte byHostIndex;/* 0-Hikvision DNS 1Ј­Dyndns 2Ј­PeanutHull(»ЁЙъїЗ)*/
            public byte byEnableDDNS;/*КЗ·сУ¦УГDDNS 0-·сЈ¬1-КЗ*/
            public ushort wDDNSPort;/* DDNS¶ЛїЪєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSУГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* DDNSГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* Йи±ёЕд±ёµДУтГыµШЦ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS ¶ФУ¦µД·юОсЖчµШЦ·Ј¬їЙТФКЗIPµШЦ·»тУтГы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //9000А©Х№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDDNS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNSХЛєЕУГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* Йи±ёЕд±ёµДУтГыµШЦ· */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNSР­Тй¶ФУ¦µД·юОсЖчµШЦ·Ј¬їЙТФКЗIPµШЦ·»тУтГы */
            public ushort wDDNSPort;/* ¶ЛїЪєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_V30
        {
            public byte byEnableDDNS;
            public byte byHostIndex;/* 0-Hikvision DNS(±ЈБф) 1Ј­Dyndns 2Ј­PeanutHull(»ЁЙъїЗ)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DDNS_NUMS, ArraySubType = UnmanagedType.Struct)]
            public struDDNS[] struDDNS;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //email
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* УКјюХЛєЕ/ГЬВл */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sMailAddr;/* email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr1;/* ЙПґ«±ЁѕЇ/ТміЈµИµДemail */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //НшВзІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDNSIp; /* DNS·юОсЖчµШЦ· */
            public NET_DVR_NTPPARA struNtpClientParam;/* NTPІОКэ */
            public NET_DVR_DDNSPARA struDDNSClientParam;/* DDNSІОКэ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±ЈБф */
        }

        //nfsЅб№№ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SINGLE_NFS
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNfsHostIPAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNfsDirectory;

            public void Init()
            {
                this.sNfsDirectory = new byte[PATHNAME_LEN];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NFS_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

            public void Init()
            {
                this.struNfsDiskParam = new NET_DVR_SINGLE_NFS[MAX_NFS_DISK];

                for (int i = 0; i < MAX_NFS_DISK; i++)
                {
                    struNfsDiskParam[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ISCSI_CFG
        {   
            public uint dwSize;                   // Ѕб№№ґуРЎ
            public ushort wVrmPort;                  // VRM јаМэ¶ЛїЪ
            public byte byEnable;                  // КЗ·сЖфУГ ISCSIґжґў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                 // ±ЈБфЧЦЅЪ
            public NET_DVR_IPADDR struVrmAddr;          // VRM ipµШЦ· 16О»
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chNvtIndexCode;        //nvt index Code 
        }

        //СІєЅµгЕдЦГ(HIK IPїмЗтЧЁУГ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_POINT
        {
            public byte PresetNum;//Ф¤ЦГµг
            public byte Dwell;//НЈБфК±јд
            public byte Speed;//ЛЩ¶И
            public byte Reserve;//±ЈБф

            public void Init()
            {
                PresetNum = 0;
                Dwell = 0;
                Speed = 0;
                Reserve = 0;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISE_POINT[] struCruisePoint;//ЧоґуЦ§іЦ32ёцСІєЅµг

            public void Init()
            {
                struCruisePoint = new NET_DVR_CRUISE_POINT[32];
                for (int i = 0; i < 32; i++)
                {
                    struCruisePoint[i].Init();
                }
            }
        }

        /************************************¶аВ·ЅвВлЖч(begin)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DECINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµШЦ· */
            public ushort wDVRPort;/* ¶ЛїЪєЕ */
            public byte byChannel;/* НЁµАєЕ */
            public byte byTransProtocol;/* ґ«КдР­ТйАаРН 0-TCP, 1-UDP */
            public byte byTransMode;/* ґ«КдВлБчДЈКЅ 0Ј­ЦчВлБч 1Ј­ЧУВлБч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* јаїШЦч»ъµЗВЅХКєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* јаїШЦч»ъГЬВл */
        }

        //Жф¶Ї/НЈЦ№¶ЇМ¬ЅвВл
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ¶ЇМ¬ЅвВлНЁµАРЕПў */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            public uint dwIsLinked;/* ЅвВлНЁµАЧґМ¬ 0Ј­РЭГЯ 1Ј­ХэФЪБ¬ЅУ 2Ј­ТСБ¬ЅУ 3-ХэФЪЅвВл */
            public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string cRes;/* ±ЈБф */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ЅвВлНЁµАРЕПў */
            public uint dwDecState;/* 0-¶ЇМ¬ЅвВл 1Ј­С­»·ЅвВл 2Ј­°ґК±јд»Ш·Е 3Ј­°ґОДјю»Ш·Е */
            public NET_DVR_TIME StartTime;/* °ґК±јд»Ш·ЕїЄКјК±јд */
            public NET_DVR_TIME StopTime;/* °ґК±јд»Ш·ЕНЈЦ№К±јд */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °ґОДјю»Ш·ЕОДјюГы */
        }

        //Б¬ЅУµДНЁµАЕдЦГ 2007-11-05
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            public uint dwEnable;/* КЗ·сЖфУГ 0Ј­·с 1Ј­ЖфУГ*/
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ВЦС­ЅвВлНЁµАРЕПў */
        }

        //2007-11-05 РВФцГїёцЅвВлНЁµАµДЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            public uint dwPoolTime;/*ВЦСІК±јд */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }

        //2007-12-22
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct TTY_CONFIG
        {
            public byte baudrate;/* ІЁМШВК */
            public byte databits;/* КэѕЭО» */
            public byte stopbits;/* НЈЦ№О» */
            public byte parity;/* ЖжЕјРЈСйО» */
            public byte flowcontrol;/* БчїШ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            public byte byTranChanEnable;/* µ±З°НёГчНЁµАКЗ·сґтїЄ 0Јє№Ш±Х 1ЈєґтїЄ */
            /*
             *	¶аВ·ЅвВлЖч±ѕµШУР1ёц485ґ®їЪЈ¬1ёц232ґ®їЪ¶јїЙТФЧчОЄНёГчНЁµА,Йи±ёєЕ·ЦЕдИзПВЈє
             *	0 RS485
             *	1 RS232 Console
             */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Ф¶іМґ®їЪКдіц»№КЗБЅёц,Т»ёцRS232Ј¬Т»ёцRS485
	         *	1±нКѕ232ґ®їЪ
	         *	2±нКѕ485ґ®їЪ
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte res1;/* ±ЈБф */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;/* ±ЈБф */
            public TTY_CONFIG RemoteSerialDevCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ЙиЦГДДВ·232НёГчНЁµАКЗИ«Л«№¤µД ИЎЦµ1µЅMAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ЙиЦГДДВ·485НёГчНЁµАКЗИ«Л«№¤µД ИЎЦµ1µЅMAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ±ЈБф */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*Н¬К±Ц§іЦЅЁБўMAX_SERIAL_NUMёцНёГчНЁµА*/
        }

        //2007-12-24 Merry Christmas Eve...
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IPµШЦ· */
            public ushort wDVRPort;/* ¶ЛїЪєЕ */
            public byte byChannel;/* НЁµАєЕ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ГЬВл */
            public uint dwPlayMode;/* 0Ј­°ґОДјю 1Ј­°ґК±јд*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;/* ІҐ·ЕГьБо јыОДјюІҐ·ЕГьБо*/
            public uint dwCmdParam;/* ІҐ·ЕГьБоІОКэ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            public uint dwCurMediaFileLen;/* µ±З°ІҐ·ЕµДГЅМеОДјюі¤¶И */
            public uint dwCurMediaFilePosition;/* µ±З°ІҐ·ЕОДјюµДІҐ·ЕО»ЦГ */
            public uint dwCurMediaFileDuration;/* µ±З°ІҐ·ЕОДјюµДЧЬК±јд */
            public uint dwCurPlayTime;/* µ±З°ТСѕ­ІҐ·ЕµДК±јд */
            public uint dwCurMediaFIleFrames;/* µ±З°ІҐ·ЕОДјюµДЧЬЦЎКэ */
            public uint dwCurDataType;/* µ±З°ґ«КдµДКэѕЭАаРНЈ¬19-ОДјюН·Ј¬20-БчКэѕЭЈ¬ 21-ІҐ·ЕЅбКш±кЦѕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //2009-4-11 added by likui ¶аВ·ЅвВлЖчnew
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_PASSIVEMODE
        {
            public ushort wTransProtol;//ґ«КдР­ТйЈ¬0-TCP, 1-UDP, 2-MCAST
            public ushort wPassivePort;//UDP¶ЛїЪ, TCPК±Д¬ИП
            // char	sMcastIP[16];		//TCP,UDPК±ОЮР§, MCASTК±ОЄ¶аІҐµШЦ·
            public NET_DVR_IPADDR struMcastIP;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
        {
            public byte byTranChanEnable;/* µ±З°НёГчНЁµАКЗ·сґтїЄ 0Јє№Ш±Х 1ЈєґтїЄ */
            /*
	         *	¶аВ·ЅвВлЖч±ѕµШУР1ёц485ґ®їЪЈ¬1ёц232ґ®їЪ¶јїЙТФЧчОЄНёГчНЁµА,Йи±ёєЕ·ЦЕдИзПВЈє
	         *	0 RS485
	         *	1 RS232 Console
	         */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Ф¶іМґ®їЪКдіц»№КЗБЅёц,Т»ёцRS232Ј¬Т»ёцRS485
	         *	1±нКѕ232ґ®їЪ
	         *	2±нКѕ485ґ®їЪ
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte byRes1;/* ±ЈБф */
            public NET_DVR_IPADDR struRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            public byte byIsEstablished;/* НёГчНЁµАЅЁБўіЙ№¦±кЦѕЈ¬0-Г»УРіЙ№¦Ј¬1-ЅЁБўіЙ№¦ */
            public byte byRes2;/* ±ЈБф */
            public TTY_CONFIG RemoteSerialDevCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUsername;/* 32BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;/* 16BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ЙиЦГДДВ·232НёГчНЁµАКЗИ«Л«№¤µД ИЎЦµ1µЅMAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ЙиЦГДДВ·485НёГчНЁµАКЗИ«Л«№¤µД ИЎЦµ1µЅMAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] vyRes;/* ±ЈБф */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*Н¬К±Ц§іЦЅЁБўMAX_SERIAL_NUMёцНёГчНЁµА*/
        }        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_INFO_V30
        {
            public uint dwEnable;/* КЗ·сЖфУГ 0Ј­·с 1Ј­ЖфУГ*/
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ВЦС­ЅвВлНЁµАРЕПў */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_V30
        {
            public uint dwSize;
            public uint dwPoolTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V30
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;/*БчГЅМе·юОсЖчЕдЦГ*/
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ЅвВлНЁµАРЕПў */
            public uint dwDecState;/* 0-¶ЇМ¬ЅвВл 1Ј­С­»·ЅвВл 2Ј­°ґК±јд»Ш·Е 3Ј­°ґОДјю»Ш·Е */
            public NET_DVR_TIME StartTime;/* °ґК±јд»Ш·ЕїЄКјК±јд */
            public NET_DVR_TIME StopTime;/* °ґК±јд»Ш·ЕНЈЦ№К±јд */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* °ґОДјю»Ш·ЕОДјюГы */
            public uint dwGetStreamMode;/*ИЎБчДЈКЅ:1-Цч¶ЇЈ¬2-±»¶Ї*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_RESOLUTIONNUM = 64; //Ц§іЦµДЧоґу·Ц±жВККэДї

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY
        {
            public uint dwSize;
            public byte byDecNums;
            public byte byStartChan;
            public byte byVGANums;
            public byte byBNCNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
            public byte[] byVGAWindowMode;/*VGAЦ§іЦµДґ°їЪДЈКЅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byBNCWindowMode;/*BNCЦ§іЦµДґ°їЪДЈКЅ*/
            public byte byDspNums;   
            public byte byHDMINums;//HDMIПФКѕНЁµАёцКэЈЁґУ25їЄКјЈ©
            public byte byDVINums;//DVIПФКѕНЁµАёцКэЈЁґУ29їЄКјЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESOLUTIONNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] bySupportResolution;//°ґХХЙПГжµДГ¶ѕЩ¶ЁТе,Т»ёцЧЦЅЪґъ±нТ»ёц·Ц±жВККЗ//·сЦ§іЦЈ¬1ЈєЦ§іЦЈ¬0ЈєІ»Ц§іЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDMIWindowMode;//HDMIЦ§іЦµДґ°їЪДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVIWindowMode;//DVIЦ§іЦµДґ°їЪДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ЙПґ«logoЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_LOGOCFG
        {
            public uint dwCorordinateX;//НјЖ¬ПФКѕЗшУтXЧш±к
            public uint dwCorordinateY;//НјЖ¬ПФКѕЗшУтYЧш±к
            public ushort wPicWidth; //НјЖ¬їн
            public ushort wPicHeight; //НјЖ¬ёЯ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byFlash;//КЗ·сЙБЛё1-ЙБЛёЈ¬0-І»ЙБЛё
            public byte byTranslucent;//КЗ·с°лНёГч1-°лНёГчЈ¬0-І»°лНёГч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБф
            public uint dwLogoSize;//LOGOґуРЎЈ¬°ьАЁBMPµДОДјюН·
        }

        /*±аВлАаРН*/
        public const int NET_DVR_ENCODER_UNKOWN = 0;/*ОґЦЄ±аВлёсКЅ*/
        public const int NET_DVR_ENCODER_H264 = 1;/*HIK 264*/
        public const int NET_DVR_ENCODER_S264 = 2;/*Standard H264*/
        public const int NET_DVR_ENCODER_MPEG4 = 3;/*MPEG4*/
        public const int NET_DVR_ORIGINALSTREAM = 4;/*Original Stream*/
        public const int NET_DVR_PICTURE = 5;//*Picture*/
        public const int NET_DVR_ENCODER_MJPEG = 6;
        public const int NET_DVR_ECONDER_MPEG2 = 7;
        /* ґт°ьёсКЅ */
        public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;/*ОґЦЄґт°ьёсКЅ*/
        public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1; /*єЈїµЧФ¶ЁТеґт°ьёсКЅ*/
        public const int NET_DVR_STREAM_TYPE_TS = 7;/* TSґт°ь */
        public const int NET_DVR_STREAM_TYPE_PS = 8;/* PSґт°ь */
        public const int NET_DVR_STREAM_TYPE_RTP = 9;/* RTPґт°ь */

        /*ЅвВлНЁµАЧґМ¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_STATUS
        {
            public byte byDecodeStatus;/*µ±З°ЧґМ¬:0:ОґЖф¶ЇЈ¬1ЈєЖф¶ЇЅвВл*/
            public byte byStreamType;/*ВлБчАаРН*/
            public byte byPacketType;/*ґт°ь·ЅКЅ*/
            public byte byRecvBufUsage;/*ЅУКХ»єіеК№УГВК*/
            public byte byDecBufUsage;/*ЅвВл»єіеК№УГВК*/
            public byte byFpsDecV;/*КУЖµЅвВлЦЎВК*/
            public byte byFpsDecA;/*ТфЖµЅвВлЦЎВК*/
            public byte byCpuLoad;/*DSP CPUК№УГВК*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDecodedV;/*ЅвВлµДКУЖµЦЎ*/
            public uint dwDecodedA;/*ЅвВлµДТфЖµЦЎ*/
            public ushort wImgW;/*ЅвВлЖчµ±З°µДНјПсґуРЎ,їн*/
            public ushort wImgH; //ёЯ
            public byte byVideoFormat;/*КУЖµЦЖКЅ:0-NON,NTSC--1,PAL--2*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwDecChan; /*»сИЎИ«ІїЅвВлНЁµАЧґМ¬К±УРР§Ј¬ЙиЦГК±їЙМо0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*ПФКѕНЁµАЧґМ¬*/
        public const int NET_DVR_MAX_DISPREGION = 16;         /*ГїёцПФКѕНЁµАЧо¶аїЙТФПФКѕµДґ°їЪ*/
        //VGA·Ц±жВКЈ¬ДїЗ°ДЬУГµДКЗЈєVGA_THS8200_MODE_XGA_60HZЎўVGA_THS8200_MODE_SXGA_60HZЎў
        //
        public enum VGA_MODE
        {
            /*VGA*/
            VGA_NOT_AVALIABLE,
            VGA_THS8200_MODE_SVGA_60HZ,    //(800*600)
            VGA_THS8200_MODE_SVGA_75HZ,    //(800*600)
            VGA_THS8200_MODE_XGA_60HZ,     //(1024*768)
            VGA_THS8200_MODE_XGA_75HZ,     //(1024*768)
            VGA_THS8200_MODE_SXGA_60HZ,    //(1280*1024)
            VGA_THS8200_MODE_720P_60HZ,    //(1280*720)
            VGA_THS8200_MODE_1080I_60HZ,   //(1920*1080)
            VGA_THS8200_MODE_1080P_30HZ,   //(1920*1080)
            VGA_THS8200_MODE_UXGA_30HZ,    //(1600*1200)
            /*HDMI*/
            HDMI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            HDMI_SII9134_MODE_SXGA_60HZ,   //(1280*1024)
            HDMI_SII9134_MODE_SXGA2_60HZ,  //(1280*960)
            HDMI_SII9134_MODE_720P_60HZ,   //(1280*720)	
            HDMI_SII9134_MODE_720P_50HZ,   //(1280*720)		
            HDMI_SII9134_MODE_1080I_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080I_50HZ,  //(1920*1080)	
            HDMI_SII9134_MODE_1080P_25HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_30HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_50HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_UXGA_60HZ,   //(1600*1200)
            /*DVI*/
            DVI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            DVI_SII9134_MODE_SXGA_60HZ,	   //(1280*1024)
            DVI_SII9134_MODE_SXGA2_60HZ,   //(1280*960)
            DVI_SII9134_MODE_720P_60HZ,	   //(1280*720)	
            DVI_SII9134_MODE_720P_50HZ,    //(1280*720)		
            DVI_SII9134_MODE_1080I_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080I_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_25HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_30HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_UXGA_60HZ,     //(1600*1200)
            VGA_DECSVR_MODE_SXGA2_60HZ,
            HDMI_DECSVR_MODE_1080P_24HZ,
            DVI_DECSVR_MODE_1080P_24HZ,
            YPbPr_DECSVR_MODE_720P_60HZ,
            YPbPr_DECSVR_MODE_1080I_60HZ
        }

        //µНЦЎВК¶ЁТе
        public const int LOW_DEC_FPS_1_2 = 51;
        public const int LOW_DEC_FPS_1_4 = 52;
        public const int LOW_DEC_FPS_1_8 = 53;
        public const int LOW_DEC_FPS_1_16 = 54;

        /*КУЖµЦЖКЅ±кЧј*/
        public enum VIDEO_STANDARD
        {
            VS_NON = 0,
            VS_NTSC = 1,
            VS_PAL = 2,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM
        {
            /*ёчёцЧУґ°їЪ¶ФУ¦ЅвВлНЁµАЛщ¶ФУ¦µДЅвВлЧУПµНіµДІЫО»єЕ(¶ФУЪКУЖµЧЫєПЖЅМЁЦРЅвВлЧУПµНіУРР§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG
        {
            public uint dwSize;
            public byte byAudio;/*ТфЖµКЗ·сїЄЖф,0-·сЈ¬1-КЗ*/
            public byte byAudioWindowIdx;/*ТфЖµїЄЖфЧУґ°їЪ*/
            public byte byVgaResolution;/*VGAµД·Ц±жВК*/
            public byte byVedioFormat;/*КУЖµЦЖКЅЈ¬1:NTSC,2:PAL,0-NON*/
            public uint dwWindowMode;/*»­ГжДЈКЅЈ¬ґУДЬБ¦јЇАп»сИЎЈ¬ДїЗ°Ц§іЦ1,2,4,9,16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*ёчёцЧУґ°їЪ№ШБЄµДЅвВлНЁµА*/
            public byte byEnlargeStatus;          /*КЗ·сґ¦УЪ·ЕґуЧґМ¬Ј¬0ЈєІ»·ЕґуЈ¬1Јє·Еґу*/
            public byte byEnlargeSubWindowIndex;//·ЕґуµДЧУґ°їЪєЕ
	        [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                 public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM struNotVideoPlatform;
            }
            public byte byUnionType;/*Зш·Ц№ІУГМеЈ¬0-КУЖµЧЫєПЖЅМЁДЪІїЅвВлЖчПФКѕНЁµАЕдЦГЈ¬1-ЖдЛыЅвВлЖчПФКѕНЁµАЕдЦГ*/
            public byte byScale; /*ПФКѕДЈКЅЈ¬0---ХжКµПФКѕЈ¬1---Лх·ЕПФКѕ( Хл¶ФBNC )*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS
        {
            public byte byDispStatus;/*ПФКѕЧґМ¬Јє0ЈєОґПФКѕЈ¬1ЈєЖф¶ЇПФКѕ*/
            public byte byBVGA; /*VGA/BNC*/
            public byte byVideoFormat;/*КУЖµЦЖКЅ:1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;/*µ±З°»­ГжДЈКЅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*ёчёцЧУґ°їЪ№ШБЄµДЅвВлНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_MAX_DISPREGION, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;/*ГїёцЧУ»­ГжµДПФКѕЦЎВК*/
            public byte byScreenMode;			//ЖБД»ДЈКЅ0-ЖХНЁ 1-ґуЖБ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_DECODECHANNUM = 32;//¶аВ·ЅвВлЖчЧоґуЅвВлНЁµАКэ
        public const int MAX_DISPCHANNUM = 24;//¶аВ·ЅвВлЖчЧоґуПФКѕНЁµАКэ

        /*ЅвВлЖчЙи±ёЧґМ¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECODECHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;/*ЅвВлНЁµАЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPCHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;/*ПФКѕНЁµАЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;/*±ЁѕЇКдИлЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAalarmOutStatus;/*±ЁѕЇКдіцЧґМ¬*/
            public byte byAudioInChanStatus;/*УпТф¶ФЅІЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2009-12-1 ФцјУ±»¶ЇЅвВлІҐ·ЕїШЦЖ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PASSIVEDECODE_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;		/* ІҐ·ЕГьБо јыОДјюІҐ·ЕГьБо*/
            public uint dwCmdParam;		/* ІҐ·ЕГьБоІОКэ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//Reverse
        }

        public const int PASSIVE_DEC_PAUSE = 1;	/*±»¶ЇЅвВлФЭНЈ(ЅцОДјюБчУРР§)*/
        public const int PASSIVE_DEC_RESUME = 2;	/*»Цёґ±»¶ЇЅвВл(ЅцОДјюБчУРР§)*/
        public const int PASSIVE_DEC_FAST = 3;   /*їмЛЩ±»¶ЇЅвВл(ЅцОДјюБчУРР§)*/
        public const int PASSIVE_DEC_SLOW = 4;   /*ВэЛЩ±»¶ЇЅвВл(ЅцОДјюБчУРР§)*/
        public const int PASSIVE_DEC_NORMAL = 5;   /*ХэіЈ±»¶ЇЅвВл(ЅцОДјюБчУРР§)*/
        public const int PASSIVE_DEC_ONEBYONE =	6;  /*±»¶ЇЅвВлµҐЦЎІҐ·Е(±ЈБф)*/
        public const int PASSIVE_DEC_AUDIO_ON = 7;   /*ТфЖµїЄЖф*/
        public const int PASSIVE_DEC_AUDIO_OFF = 8; 	 /*ТфЖµ№Ш±Х*/
        public const int PASSIVE_DEC_RESETBUFFER = 9;    /*ЗеїХ»єіеЗш*/

        //2009-12-16 ФцјУїШЦЖЅвВлЖчЅвВлНЁµАЛх·Е
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHAN_CONTROL
        {        
            public uint dwSize;
            public byte byDecChanScaleStatus;/*ЅвВлНЁµАПФКѕЛх·ЕїШЦЖ,1±нКѕЛх·ЕПФКѕЈ¬0±нКѕХжКµПФКѕ*/
            public byte byDecodeDelay;//ЅвВлСУК±Ј¬0-Д¬ИПЈ¬1-КµК±РФєГЈ¬2-КµК±РФЅПєГЈ¬3-КµК±РФЦРЈ¬Бчі©РФЦРЈ¬4-Бчі©РФЅПєГЈ¬5-Бчі©РФєГЈ¬0xff-ЧФ¶ЇµчХы   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }
        /************************************¶аВ·ЅвВлЖч(end)***************************************/

        /************************************КУЖµЧЫєПЖЅМЁ(begin)***************************************/
        public const int MAX_SUBSYSTEM_NUM = 80;   //Т»ёцѕШХуПµНіЦРЧо¶аЧУПµНіКэБї
        public const int MAX_SUBSYSTEM_NUM_V40 = 120;   //Т»ёцѕШХуПµНіЦРЧо¶аЧУПµНіКэБї
        public const int MAX_SERIALLEN = 36;  //ЧоґуРтБРєЕі¤¶И
        public const int MAX_LOOPPLANNUM = 16;  //ЧоґујЖ»®ЗР»»Чй
        public const int DECODE_TIMESEGMENT = 4;     //јЖ»®ЅвВлГїМмК±јд¶ОКэ

        public const int MAX_DOMAIN_NAME = 64;  /* ЧоґуУтГыі¤¶И */
        public const int MAX_DISKNUM_V30 = 33; //9000Йи±ёЧоґуУІЕМКэ/* Чо¶а33ёцУІЕМ(°ьАЁ16ёцДЪЦГSATAУІЕМЎў1ёцeSATAУІЕМєН16ёцNFSЕМ) */
        public const int MAX_DAYS = 7;       //ГїЦЬМмКэ
        public const int MAX_DISPNUM_V41 = 32;
        public const int MAX_WINDOWS_NUM = 12;
        public const int MAX_VOUTNUM = 32;
        public const int MAX_SUPPORT_RES = 32;
        public const int MAX_BIGSCREENNUM = 100;

        public const int VIDEOPLATFORM_ABILITY = 0x210; //КУЖµЧЫєПЖЅМЁДЬБ¦јЇ
        public const int MATRIXDECODER_ABILITY_V41 = 0x260; //ЅвВлЖчДЬБ¦јЇ

        public const int NET_DVR_MATRIX_BIGSCREENCFG_GET = 1140;//»сИЎґуЖБЖґЅУІОКэ        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEMINFO
        {
            public byte bySubSystemType;//ЧУПµНіАаРНЈ¬1-ЅвВлУГЧУПµНіЈ¬2-±аВлУГЧУПµНіЈ¬0-NULLЈЁґЛІОКэЦ»ДЬ»сИЎЈ©
            public byte byChan;//ЧУПµНіНЁµАКэЈЁґЛІОКэЦ»ДЬ»сИЎЈ©
            public byte byLoginType;//ЧўІбАаРНЈ¬1-Ц±Б¬Ј¬2-DNSЈ¬3-»ЁЙъїЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struSubSystemIP;/*IPµШЦ·ЈЁїЙРЮёДЈ©*/
            public ushort wSubSystemPort;//ЧУПµНі¶ЛїЪєЕЈЁїЙРЮёДЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struSubSystemIPMask;//ЧУНшСЪВл
            public NET_DVR_IPADDR struGatewayIpAddr;	/* Нш№ШµШЦ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* УГ»§Гы ЈЁґЛІОКэЦ»ДЬ»сИЎЈ©*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*ГЬВлЈЁґЛІОКэЦ»ДЬ»сИЎЈ©*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDomainName;//УтГы(їЙРЮёД)
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDnsAddress;/*DNSУтГы»тIPµШЦ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//РтБРєЕЈЁґЛІОКэЦ»ДЬ»сИЎЈ©
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLSUBSYSTEMINFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOOPPLAN_SUBCFG
        {
            public uint dwSize;
            public uint dwPoolTime; /*ВЦСЇјдёфЈ¬µҐО»ЈєГл*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]            
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMMODECFG
        {
            public uint dwSize;
            public byte byAlarmMode;//±ЁѕЇґҐ·ўАаРНЈ¬1-ВЦСЇЈ¬2-±ЈіЦ 
            public ushort wLoopTime;//ВЦСЇК±јд, µҐО»ЈєГл 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CODESPLITTERINFO
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;/*Вл·ЦЖчIPµШЦ·*/
            public ushort wPort;//Вл·ЦЖч¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]             
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sUserName;/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sPassword;/*ГЬВл */
            public byte byChan;//Вл·ЦЖч485єЕ
            public byte by485Port;//485їЪµШЦ·      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ASSOCIATECFG
        {
            public byte byAssociateType;//№ШБЄАаРНЈ¬1-±ЁѕЇ
            public ushort wAlarmDelay;//±ЁѕЇСУК±Ј¬0Ј­5ГлЈ»1Ј­10ГлЈ»2Ј­30ГлЈ»3Ј­1·ЦЦУЈ»4Ј­2·ЦЦУЈ»5Ј­5·ЦЦУЈ»6Ј­10·ЦЦУЈ»
            public byte byAlarmNum;//±ЁѕЇєЕЈ¬ѕЯМеµДЦµУЙУ¦УГёіЈ¬ПаН¬µД±ЁѕЇёіПаН¬µДЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DYNAMICDECODE
        {
            public uint dwSize;
            public NET_DVR_ASSOCIATECFG struAssociateCfg;//ґҐ·ў¶ЇМ¬ЅвВл№ШБЄЅб№№
            public NET_DVR_PU_STREAM_CFG struPuStreamCfg;//¶ЇМ¬ЅвВлЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODESCHED
        {
            public NET_DVR_SCHEDTIME struSchedTime;
            public byte byDecodeType;/*0-ОЮЈ¬1-ВЦСЇЅвВлЈ¬2-¶ЇМ¬ЅвВл*/
            public byte byLoopGroup;//ВЦСЇЧйєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
            public NET_DVR_PU_STREAM_CFG struDynamicDec;//¶ЇМ¬ЅвВл
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLANDECODE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * DECODE_TIMESEGMENT, ArraySubType = UnmanagedType.I1)] 
            public NET_DVR_DECODESCHED[] struDecodeSched;//ЦЬТ»ЧчОЄїЄКјЈ¬єН9000Т»ЦВ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byres;
        }
        /************************************КУЖµЧЫєПЖЅМЁ(end)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;//±аВлЧУПµНіКэБї
            public byte byDecodeSubSystemNums;//ЅвВлЧУПµНіКэБї
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byWindowMode; /*ПФКѕНЁµАЦ§іЦµДґ°їЪДЈКЅ*/
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;
        }

        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEM_ABILITY
        {
            /*ЧУПµНіАаРНЈ¬1-ЅвВлУГЧУПµНіЈ¬2-±аВлУГЧУПµНіЈ¬3-ј¶БЄКдіцЧУПµНіЈ¬4-ј¶БЄКдИлЧУПµНіЈ¬5-Вл·ЦЖчЧУПµНіЈ¬6-±ЁѕЇЦч»ъЧУПµНіЈ¬7-ЦЗДЬЧУПµНіЈ¬8-V6ЅвВлЧУПµНіЈ¬9-V6ЧУПµНіЈ¬0-NULLЈЁґЛІОКэЦ»ДЬ»сИЎЈ©*/
            public byte bySubSystemType;
            public byte byChanNum;//ЧУПµНіНЁµАКэ
            public byte byStartChan;//ЧУПµНіЖрКјНЁµАКэ
            public byte bySlotNum;//ІЫО»єЕ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public struDecoderSystemAbility _struAbility;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDecoderSystemAbility
        {
            public byte byVGANums;//VGAПФКѕНЁµАёцКэЈЁґУ1їЄКјЈ©
            public byte byBNCNums;//BNCПФКѕНЁµАёцКэЈЁґУ9їЄКјЈ©
            public byte byHDMINums;//HDMIПФКѕНЁµАёцКэЈЁґУ25їЄКјЈ©
            public byte byDVINums;//DVIПФКѕНЁµАёцКэЈЁґУ29їЄКјЈ©

            public byte byLayerNums;//ґуЖБЖґЅУЦРЈ¬ЧцЦчЖБК±ЛщЦ§іЦНјІгКэ
            public byte bySpartan;//і©ПФ№¦ДЬЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            public byte byDecType; //ЅвВлЧУПµНіАаРНЈ¬0-ЖХНЁРН,1-ФцЗїРН(ЖХНЁРН·ЦЖБК±З°4ґ°їЪРиК№УГЧФЙнЧКФґЈ¬ФцЗїРНОЮґЛПЮЦЖЈ¬ФцЗїРНЧо¶аїЙ±»ЖдЛыЧУПµНіЅи16В·D1ЅвВлЧКФґ
            //ФцЗїРН±»ґуЖБ№ШБЄОЄЧУЖБєуЧКФґїЙ±»ЅиУГЈ¬ЖХНЁРНФтІ»ДЬ±»ЅиУГ)
            public byte byOutputSwitch;//КЗ·сЦ§іЦHDMI/DVI»ҐПаЗР»»Ј¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDecoderType; //ЅвВл°еАаРН  0-ЖХНЁЅвВл°е 1-НтДЬЅвВл°е
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struAbility
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            //  [FieldOffsetAttribute(0)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY_V40
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;
            public byte byDecodeSubSystemNums;//ЅвВлЧУПµНіКэБї
            public byte bySupportNat;//КЗ·сЦ§іЦNATЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            public byte byInputSubSystemNums;//ј¶БЄКдИлЧУПµНіКэБї
            public byte byOutputSubSystemNums;//ј¶БЄКдіцЧУПµНіКэБї
            public byte byCodeSpitterSubSystemNums;//Вл·ЦЧУПµНіКэБї
            public byte byAlarmHostSubSystemNums;//±ЁѕЇЧУПµНіКэБї
            public byte bySupportBigScreenNum;//ЛщЦ§іЦЧо¶аЧйіЙґуЖБµДёцКэ
            public byte byVCASubSystemNums;//ЦЗДЬЧУПµНіКэБї
            public byte byV6SubSystemNums;//V6ЧУПµНіКэБї
            public byte byV6DecoderSubSystemNums;//V6ЅвВлЧУПµНіКэБї
            public byte bySupportBigScreenX;/*ґуЖБЖґЅУµДДЈКЅЈєmЎБn*/
            public byte bySupportBigScreenY;
            public byte bySupportSceneNums;//Ц§іЦіЎѕ°ДЈКЅµДёцКэ
            public byte byVcaSupportChanMode;//ЦЗДЬЦ§іЦµДНЁµАК№УГДЈКЅЈ¬0-К№УГЅвВлНЁµАЈ¬1-К№УГПФКѕНЁµАј°ЧУНЁµАєЕ
            public byte bySupportScreenNums;//ЛщЦ§іЦµДґуЖБµДЖБД»ЧоґуёцКэ
            public byte bySupportLayerNums;//ЛщЦ§іЦµДНјІгКэЈ¬0xff-ОЮР§
            public byte byNotSupportPreview;//КЗ·сЦ§іЦФ¤АА,1-І»Ц§іЦЈ¬0-Ц§іЦ
            public byte byNotSupportStorage;//КЗ·сЦ§іЦґжґў,1-І»Ц§іЦЈ¬0-Ц§іЦ
            public byte byUploadLogoMode;//ЙПґ«logoДЈКЅЈ¬0-ЙПґ«ёшЅвВлНЁµАЈ¬1-ЙПґ«ёшПФКѕНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEM_ABILITY[] struSubSystemAbility;
            public byte by485Nums;//485ґ®їЪёцКэ
            public byte by232Nums;//232ґ®їЪёцКэ
            public byte bySerieStartChan;//ЖрКјНЁµА
            public byte byScreenMode;//ґуЖБДЈКЅЈ¬0-ЦчЖБУЙїН»§¶Л·ЦЕдЈ¬1-ЦчЖБУЙЙи±ё¶Л·ЦЕд
            public byte byDevVersion;//Йи±ё°ж±ѕЈ¬0-B10/B11/B12Ј¬1-B20
            public byte bySupportBaseMapNums;//ЛщЦ§іЦµДµЧНјКэЈ¬µЧНјєЕґУ1їЄКј
            public ushort wBaseLengthX;//ГїёцЖБґуРЎµД»щЧјЦµЈ¬B20К№УГ
            public ushort wBaseLengthY;
            public byte bySupportPictureTrans;  //КЗ·сЦ§іЦНјЖ¬»ШПФЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ	
            public byte bySupportPreAllocDec;   //КЗ·сЦ§іЦЦЗДЬЅвВлЧКФґФ¤·ЦЕдЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLESCREENCFG
        {
            public byte byScreenSeq;//ЖБД»РтєЕЈ¬0xff±нКѕІ»УГґЛЖБ,64-TЅвВлЖчµЪТ»ёц±нКѕЦчЖБ
            public byte bySubSystemNum;//ЅвВлЧУПµНіІЫО»єЕ,ЅвВлЖчґЛЦµГ»УРУГ
            public byte byDispNum;//ЅвВлЧУПµНіЙП¶ФУ¦ПФКѕНЁµАєЕЈ¬64-TЅвВлЖчЦРёГЦµ±нКѕЅвВлЖчµДПФКѕНЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG
        {
            public uint dwSize;
            public byte byEnable;//ґуЖБЖґЅУК№ДЬЈ¬0-І»К№ДЬЈ¬1-К№ДЬ
            public byte byModeX;/*ґуЖБЖґЅУДЈКЅ*/
            public byte byModeY;
            public byte byMainDecodeSystem;//ЧЫєПЖЅМЁµДЅвВл°еЦРёГЦµ±нКѕЦчЖБІЫО»єЕЈ¬64-TЅвВлЖчЦРёГЦµ±нКѕЅвВлНЁµАєЕ
            public byte byMainDecoderDispChan;//ЦчЖБЛщУГПФКѕНЁµАєЕЈ¬1.1netra°ж±ѕРВФцЈ¬netraЅвВлЖчУРБЅёцПФКѕНЁµАЈ¬¶јДЬ№»ЧчОЄЦчЖБЎЈ64-TЦРёГЦµОЮР§
            public byte byVideoStandard;      //ґуЖБГїёцЧУЖБЦЖКЅПаН¬ 1:NTSC,2:PAL
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;         //ґуЖБГїёцЧУЖБ·Ц±жВКПаН¬
            //ґуЖБЖґЅУґУЖБД»РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BIGSCREENNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLESCREENCFG[] struFollowSingleScreen;
            //ЖрКјЧш±к±ШРлОЄ»щЧјЧш±кµДХыКэ±¶
            public ushort wBigScreenX; //ґуЖБФЪµзКУЗЅЦРЖрКјXЧш±к
            public ushort wBigScreenY; //ґуЖБФЪµзКУЗЅЦРЖрКјYЧш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byRes1 = new byte[2];
                struFollowSingleScreen = new NET_DVR_SINGLESCREENCFG[MAX_BIGSCREENNUM];
                byRes2 = new byte[12];
            }
        }       

        /************************************КУЖµЧЫєПЖЅМЁ(end)***************************************/
        
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_EMAILCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPassWord;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sFromName;/* Sender *///ЧЦ·ыґ®ЦРµДµЪТ»ёцЧЦ·ыєНЧоєуТ»ёцЧЦ·ыІ»ДЬКЗ"@",ІўЗТЧЦ·ыґ®ЦРТЄУР"@"ЧЦ·ы
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sFromAddr;/* Sender address */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName1;/* Receiver1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName2;/* Receiver2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr1;/* Receiver address1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr2;/* Receiver address2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sEmailServer;/* Email server address */
            public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTPЎ­*/
            public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
            public byte byAttachment;/* enable attachment */
            public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;//¶ЁК±ВјПс
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;//КВјюґҐ·ўВјПс
        }

        //Зт»ъО»ЦГРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS
        {
            public ushort wAction;//»сИЎК±ёГЧЦ¶ООЮР§
            public ushort wPanPos;//Л®ЖЅІОКэ
            public ushort wTiltPos;//ґ№Ц±ІОКэ
            public ushort wZoomPos;//±д±¶ІОКэ
        }

        //Зт»ъ·¶О§РЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZSCOPE
        {
            public ushort wPanPosMin;//Л®ЖЅІОКэmin
            public ushort wPanPosMax;//Л®ЖЅІОКэmax
            public ushort wTiltPosMin;//ґ№Ц±ІОКэmin
            public ushort wTiltPosMax;//ґ№Ц±ІОКэmax
            public ushort wZoomPosMin;//±д±¶ІОКэmin
            public ushort wZoomPosMax;//±д±¶ІОКэmax
        }

        //rtspЕдЦГ ipcameraЧЁУГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RTSPCFG
        {
            public uint dwSize;//і¤¶И
            public ushort wPort;//rtsp·юОсЖчХмМэ¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;//Ф¤Бф
        }

        /********************************ЅУїЪІОКэЅб№№(begin)*********************************/

        //NET_DVR_Login()ІОКэЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//РтБРєЕ
            public byte byAlarmInPortNum;//DVR±ЁѕЇКдИлёцКэ
            public byte byAlarmOutPortNum;//DVR±ЁѕЇКдіцёцКэ
            public byte byDiskNum;//DVRУІЕМёцКэ
            public byte byDVRType;//DVRАаРН, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR НЁµАёцКэ
            public byte byStartChan;//ЖрКјНЁµАєЕ,АэИзDVS-1,DVR - 1
        }

        //NET_DVR_Login_V30()ІОКэЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;  //РтБРєЕ
            public byte byAlarmInPortNum;		        //±ЁѕЇКдИлёцКэ
            public byte byAlarmOutPortNum;		        //±ЁѕЇКдіцёцКэ
            public byte byDiskNum;				    //УІЕМёцКэ
            public byte byDVRType;				    //Йи±ёАаРН, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				    //ДЈДвНЁµАёцКэ
            public byte byStartChan;			        //ЖрКјНЁµАєЕ,АэИзDVS-1,DVR - 1
            public byte byAudioChanNum;                //УпТфНЁµАКэ
            public byte byIPChanNum;					//ЧоґуКэЧЦНЁµАёцКэЈ¬µНО»  
            public byte byZeroChanNum;			//БгНЁµА±аВлёцКэ //2010-01-16
            public byte byMainProto;			//ЦчВлБчґ«КдР­ТйАаРН 0-private, 1-rtsp,2-Н¬К±Ц§іЦprivateєНrtsp
            public byte bySubProto;				//ЧУВлБчґ«КдР­ТйАаРН0-private, 1-rtsp,2-Н¬К±Ц§іЦprivateєНrtsp
            public byte bySupport;        //ДЬБ¦Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦЈ¬
            //bySupport & 0x1, ±нКѕКЗ·сЦ§іЦЦЗДЬЛСЛч
            //bySupport & 0x2, ±нКѕКЗ·сЦ§іЦ±ё·Э
            //bySupport & 0x4, ±нКѕКЗ·сЦ§іЦС№ЛхІОКэДЬБ¦»сИЎ
            //bySupport & 0x8, ±нКѕКЗ·сЦ§іЦ¶аНшїЁ
            //bySupport & 0x10, ±нКѕЦ§іЦФ¶іМSADP
            //bySupport & 0x20, ±нКѕЦ§іЦRaidїЁ№¦ДЬ
            //bySupport & 0x40, ±нКѕЦ§іЦIPSAN ДїВјІйХТ
	        //bySupport & 0x80, ±нКѕЦ§іЦrtp over rtsp
            public byte bySupport1;        // ДЬБ¦јЇА©ідЈ¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦ
	        //bySupport1 & 0x1, ±нКѕКЗ·сЦ§іЦsnmp v30
	        //bySupport1 & 0x2, Ц§іЦЗш·Ц»Ш·ЕєНПВФШ
	        //bySupport1 & 0x4, КЗ·сЦ§іЦІј·АУЕПИј¶	
	        //bySupport1 & 0x8, ЦЗДЬЙи±ёКЗ·сЦ§іЦІј·АК±јд¶ОА©Х№
	        //bySupport1 & 0x10, ±нКѕКЗ·сЦ§іЦ¶аґЕЕМКэЈЁі¬№э33ёцЈ©
	        //bySupport1 & 0x20, ±нКѕКЗ·сЦ§іЦrtsp over http	
	        //bySupport1 & 0x80, ±нКѕКЗ·сЦ§іЦіµЕЖРВ±ЁѕЇРЕПў2012-9-28, ЗТ»№±нКѕКЗ·сЦ§іЦNET_DVR_IPPARACFG_V40Ѕб№№Ме
            public byte bySupport2; /*ДЬБ¦Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬·З0±нКѕЦ§іЦ							
							bySupport2 & 0x1, ±нКѕЅвВлЖчКЗ·сЦ§іЦНЁ№эURLИЎБчЅвВл
							bySupport2 & 0x2,  ±нКѕЦ§іЦFTPV40
							bySupport2 & 0x4,  ±нКѕЦ§іЦANR
							bySupport2 & 0x8,  ±нКѕЦ§іЦCCDµДНЁµАІОКэЕдЦГ
							bySupport2 & 0x10,  ±нКѕЦ§іЦІј·А±ЁѕЇ»Шґ«РЕПўЈЁЅцЦ§іЦЧҐЕД»ъ±ЁѕЇ РВАП±ЁѕЇЅб№№Ј©
							bySupport2 & 0x20,  ±нКѕКЗ·сЦ§іЦµҐ¶А»сИЎЙи±ёЧґМ¬ЧУПо
							bySupport2 & 0x40,  ±нКѕКЗ·сКЗВлБчјУГЬЙи±ё*/
            public ushort wDevType;              //Йи±ёРНєЕ
            public byte bySupport3; //ДЬБ¦јЇА©Х№Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦ
							//bySupport3 & 0x1, ±нКѕКЗ·с¶аВлБч
							// bySupport3 & 0x4 ±нКѕЦ§іЦ°ґЧйЕдЦГЈ¬ ѕЯМе°ьє¬ НЁµАНјПсІОКэЎў±ЁѕЇКдИлІОКэЎўIP±ЁѕЇКдИлЎўКдіцЅУИлІОКэЎў
                            // УГ»§ІОКэЎўЙи±ё№¤ЧчЧґМ¬ЎўJPEGЧҐНјЎў¶ЁК±єНК±јдЧҐНјЎўУІЕМЕМЧй№ЬАн 
							//bySupport3 & 0x8ОЄ1 ±нКѕЦ§іЦК№УГTCPФ¤ААЎўUDPФ¤ААЎў¶аІҐФ¤ААЦРµД"СУК±Ф¤АА"ЧЦ¶ОАґЗлЗуСУК±Ф¤ААЈЁєуРш¶јЅ«К№УГХвЦЦ·ЅКЅЗлЗуСУК±Ф¤ААЈ©ЎЈ¶шµ±bySupport3 & 0x8ОЄ0К±Ј¬Ѕ«К№УГ "ЛЅУРСУК±Ф¤АА"Р­ТйЎЈ
							//bySupport3 & 0x10 ±нКѕЦ§іЦ"»сИЎ±ЁѕЇЦч»ъЦчТЄЧґМ¬ЈЁV40Ј©"ЎЈ
							//bySupport3 & 0x20 ±нКѕКЗ·сЦ§іЦНЁ№эDDNSУтГыЅвОцИЎБч

            public byte byMultiStreamProto;//КЗ·сЦ§іЦ¶аВлБч,°ґО»±нКѕ,0-І»Ц§іЦ,1-Ц§іЦ,bit1-ВлБч3,bit2-ВлБч4,bit7-ЦчВлБчЈ¬bit-8ЧУВлБч
            public byte byStartDChan;		//ЖрКјКэЧЦНЁµАєЕ,0±нКѕОЮР§
            public byte byStartDTalkChan;	//ЖрКјКэЧЦ¶ФЅІНЁµАєЕЈ¬Зш±рУЪДЈДв¶ФЅІНЁµАєЕЈ¬0±нКѕОЮР§
            public byte byHighDChanNum;		//КэЧЦНЁµАёцКэЈ¬ёЯО»
            public byte bySupport4;
            public byte byLanguageType;// Ц§іЦУпЦЦДЬБ¦,°ґО»±нКѕ,ГїТ»О»0-І»Ц§іЦ,1-Ц§іЦ  
						//  byLanguageType µИУЪ0 ±нКѕ АПЙи±ё
						//  byLanguageType & 0x1±нКѕЦ§іЦЦРОД
						//  byLanguageType & 0x2±нКѕЦ§іЦУўОД
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		//±ЈБф
        }

        //sdkНшВз»·ѕіГ¶ѕЩ±дБїЈ¬УГУЪФ¶іМЙэј¶
        public enum SDK_NETWORK_ENVIRONMENT
        {
            LOCAL_AREA_NETWORK = 0,
            WIDE_AREA_NETWORK,
        }

        //ПФКѕДЈКЅ
        public enum DISPLAY_MODE
        {
            NORMALMODE = 0,
            OVERLAYMODE
        }

        //·ўЛНДЈКЅ
        public enum SEND_MODE
        {
            PTOPTCPMODE = 0,
            PTOPUDPMODE,
            MULTIMODE,
            RTPMODE,
            RESERVEDMODE
        }

        //ЧҐНјДЈКЅ
        public enum CAPTURE_MODE
        {
            BMP_MODE = 0,		//BMPДЈКЅ
            JPEG_MODE = 1		//JPEGДЈКЅ 
        }

        //КµК±ЙщТфДЈКЅ
        public enum REALSOUND_MODE
        {
            MONOPOLIZE_MODE = 1,//¶АХјДЈКЅ
            SHARE_MODE = 2		//№ІПнДЈКЅ
        }

        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//НЁµАєЕ
            public Int32 lLinkMode;//ЧоёЯО»(31)ОЄ0±нКѕЦчВлБчЈ¬ОЄ1±нКѕЧУВлБчЈ¬0Ј­30О»±нКѕВлБчБ¬ЅУ·ЅКЅ: 0ЈєTCP·ЅКЅ,1ЈєUDP·ЅКЅ,2Јє¶аІҐ·ЅКЅ,3 - RTP·ЅКЅЈ¬4-ТфКУЖµ·ЦїЄ(TCP)
            public IntPtr hPlayWnd;//ІҐ·Еґ°їЪµДѕд±ъ,ОЄNULL±нКѕІ»ІҐ·ЕНјПу
            public string sMultiCastIP;//¶аІҐЧйµШЦ·
        }

        //SDKЧґМ¬РЕПў(9000РВФц)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKSTATE
        {
            public uint dwTotalLoginNum;//µ±З°loginУГ»§Кэ
            public uint dwTotalRealPlayNum;//µ±З°realplayВ·Кэ
            public uint dwTotalPlayBackNum;//µ±З°»Ш·Е»тПВФШВ·Кэ
            public uint dwTotalAlarmChanNum;//µ±З°ЅЁБў±ЁѕЇНЁµАВ·Кэ
            public uint dwTotalFormatNum;//µ±З°УІЕМёсКЅ»ЇВ·Кэ
            public uint dwTotalFileSearchNum;//µ±З°ИХЦѕ»тОДјюЛСЛчВ·Кэ
            public uint dwTotalLogSearchNum;//µ±З°ИХЦѕ»тОДјюЛСЛчВ·Кэ
            public uint dwTotalSerialNum;//µ±З°НёГчНЁµАВ·Кэ
            public uint dwTotalUpgradeNum;//µ±З°Йэј¶В·Кэ
            public uint dwTotalVoiceComNum;//µ±З°УпТфЧЄ·ўВ·Кэ
            public uint dwTotalBroadCastNum;//µ±З°УпТф№гІҐВ·Кэ
            public uint dwTotalListenNum;	    //µ±З°НшВзјаМэВ·Кэ
            public uint dwEmailTestNum;       //µ±З°УКјюјЖКэВ·Кэ
            public uint dwBackupNum;          // µ±З°ОДјю±ё·ЭВ·Кэ
            public uint dwTotalInquestUploadNum; //µ±З°ЙуС¶ЙПґ«В·Кэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //SDK№¦ДЬЦ§іЦРЕПў(9000РВФц)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKABL
        {
            public uint dwMaxLoginNum;//ЧоґуloginУГ»§Кэ MAX_LOGIN_USERS
            public uint dwMaxRealPlayNum;//ЧоґуrealplayВ·Кэ WATCH_NUM
            public uint dwMaxPlayBackNum;//Чоґу»Ш·Е»тПВФШВ·Кэ WATCH_NUM
            public uint dwMaxAlarmChanNum;//ЧоґуЅЁБў±ЁѕЇНЁµАВ·Кэ ALARM_NUM
            public uint dwMaxFormatNum;//ЧоґуУІЕМёсКЅ»ЇВ·Кэ SERVER_NUM
            public uint dwMaxFileSearchNum;//ЧоґуОДјюЛСЛчВ·Кэ SERVER_NUM
            public uint dwMaxLogSearchNum;//ЧоґуИХЦѕЛСЛчВ·Кэ SERVER_NUM
            public uint dwMaxSerialNum;//ЧоґуНёГчНЁµАВ·Кэ SERVER_NUM
            public uint dwMaxUpgradeNum;//ЧоґуЙэј¶В·Кэ SERVER_NUM
            public uint dwMaxVoiceComNum;//ЧоґуУпТфЧЄ·ўВ·Кэ SERVER_NUM
            public uint dwMaxBroadCastNum;//ЧоґуУпТф№гІҐВ·Кэ MAX_CASTNUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //±ЁѕЇЙи±ёРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ALARMER
        {
            public byte byUserIDValid;/* useridКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte bySerialValid;/* РтБРєЕКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte byVersionValid;/* °ж±ѕєЕКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte byDeviceNameValid;/* Йи±ёГыЧЦКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte byMacAddrValid; /* MACµШЦ·КЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte byLinkPortValid;/* login¶ЛїЪКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte byDeviceIPValid;/* Йи±ёIPКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public byte bySocketIPValid;/* socket ipКЗ·сУРР§ 0-ОЮР§Ј¬1-УРР§ */
            public int lUserID; /* NET_DVR_Login()·µ»ШЦµ, Іј·АК±УРР§ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;/* РтБРєЕ */
            public uint dwDeviceVersion;/* °ж±ѕРЕПў ёЯ16О»±нКѕЦч°ж±ѕЈ¬µН16О»±нКѕґО°ж±ѕ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sDeviceName;/* Йи±ёГыЧЦ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;/* MACµШЦ· */
            public ushort wLinkPort; /* link port */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sDeviceIP;/* IPµШЦ· */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sSocketIP;/* ±ЁѕЇЦч¶ЇЙПґ«К±µДsocket IPµШЦ· */
            public byte byIpProtocol; /* IpР­Тй 0-IPV4, 1-IPV6 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //УІЅвВлПФКѕЗшУтІОКэ(ЧУЅб№№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_PARA
        {
            public int bToScreen;
            public int bToVideoOut;
            public int nLeft;
            public int nTop;
            public int nWidth;
            public int nHeight;
            public int nReserved;
        }

        //УІЅвВлФ¤ААІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARDINFO
        {
            public int lChannel;//НЁµАєЕ
            public int lLinkMode;//ЧоёЯО»(31)ОЄ0±нКѕЦчВлБчЈ¬ОЄ1±нКѕЧУЈ¬0Ј­30О»±нКѕВлБчБ¬ЅУ·ЅКЅ:0ЈєTCP·ЅКЅ,1ЈєUDP·ЅКЅ,2Јє¶аІҐ·ЅКЅ,3 - RTP·ЅКЅЈ¬4-µз»°ПЯЈ¬5Ј­128kїнґшЈ¬6Ј­256kїнґшЈ¬7Ј­384kїнґшЈ¬8Ј­512kїнґшЈ»
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string sMultiCastIP;
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }

        //ВјПуОДјюІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ОДјюГы
            public NET_DVR_TIME struStartTime;//ОДјюµДїЄКјК±јд
            public NET_DVR_TIME struStopTime;//ОДјюµДЅбКшК±јд
            public uint dwFileSize;//ОДјюµДґуРЎ
        }

        //ВјПуОДјюІОКэ(9000)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ОДјюГы
            public NET_DVR_TIME struStartTime;//ОДјюµДїЄКјК±јд
            public NET_DVR_TIME struStopTime;//ОДјюµДЅбКшК±јд
            public uint dwFileSize;//ОДјюµДґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000Йи±ёЦ§іЦ,1±нКѕґЛОДјюТСѕ­±»Лш¶Ё,0±нКѕХэіЈµДОДјю
            public byte byFileType;  //ОДјюАаРН:0Ј­¶ЁК±ВјПс,1-ТЖ¶ЇХмІв Ј¬2Ј­±ЁѕЇґҐ·ўЈ¬
            //3-±ЁѕЇ|ТЖ¶ЇХмІв 4-±ЁѕЇ&ТЖ¶ЇХмІв 5-ГьБоґҐ·ў 6-КЦ¶ЇВјПс,7Ј­Хр¶Ї±ЁѕЇЈ¬8-»·ѕі±ЁѕЇЈ¬9-ЦЗДЬ±ЁѕЇЈ¬10-PIR±ЁѕЇЈ¬11-ОЮПЯ±ЁѕЇЈ¬12-єфѕИ±ЁѕЇ,14-ЦЗДЬЅ»НЁКВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ВјПуОДјюІОКэ(cvr)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ОДјюГы
            public NET_DVR_TIME struStartTime;//ОДјюµДїЄКјК±јд
            public NET_DVR_TIME struStopTime;//ОДјюµДЅбКшК±јд
            public uint dwFileSize;//ОДјюµДґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000Йи±ёЦ§іЦ,1±нКѕґЛОДјюТСѕ­±»Лш¶Ё,0±нКѕХэіЈµДОДјю
            public byte byFileType;  //ОДјюАаРН:0Ј­¶ЁК±ВјПс,1-ТЖ¶ЇХмІв Ј¬2Ј­±ЁѕЇґҐ·ўЈ¬
	        //3-±ЁѕЇ|ТЖ¶ЇХмІв 4-±ЁѕЇ&ТЖ¶ЇХмІв 5-ГьБоґҐ·ў 6-КЦ¶ЇВјПс,7Ј­Хр¶Ї±ЁѕЇЈ¬8-»·ѕі±ЁѕЇЈ¬9-ЦЗДЬ±ЁѕЇЈ¬10-PIR±ЁѕЇЈ¬11-ОЮПЯ±ЁѕЇЈ¬12-єфѕИ±ЁѕЇ,14-ЦЗДЬЅ»НЁКВјю
            public byte byQuickSearch; //0:ЖХНЁІйСЇЅб№ыЈ¬1ЈєїмЛЩЈЁИХАъЈ©ІйСЇЅб№ы
            public byte byRes;
            public uint dwFileIndex; //ОДјюЛчТэєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	
        }

        //ВјПуОДјюІОКэ(ґшїЁєЕ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_CARD
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//ОДјюГы
            public NET_DVR_TIME struStartTime;//ОДјюµДїЄКјК±јд
            public NET_DVR_TIME struStopTime;//ОДјюµДЅбКшК±јд
            public uint dwFileSize;//ОДјюµДґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
        }

        //ВјПуОДјюІйХТМхјюЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//НЁµАєЕ
            public uint dwFileType;//ВјПуОДјюАаРН0xffЈ­И«ІїЈ¬0Ј­¶ЁК±ВјПс,1-ТЖ¶ЇХмІв Ј¬2Ј­±ЁѕЇґҐ·ўЈ¬
            //3-±ЁѕЇ|ТЖ¶ЇХмІв 4-±ЁѕЇ&ТЖ¶ЇХмІв 5-ГьБоґҐ·ў 6-КЦ¶ЇВјПс
            public uint dwIsLocked;//КЗ·сЛш¶Ё 0-ХэіЈОДјю,1-Лш¶ЁОДјю, 0xff±нКѕЛщУРОДјю
            public uint dwUseCardNo;//КЗ·сК№УГїЁєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//їЁєЕ
            public NET_DVR_TIME struStartTime;//їЄКјК±јд
            public NET_DVR_TIME struStopTime;//ЅбКшК±јд
        }

        //ФЖМЁЗшУтСЎФс·ЕґуЛхРЎ(HIK їмЗтЧЁУГ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_FRAME
        {
            public int xTop;//·ЅїтЖрКјµгµДxЧш±к
            public int yTop;//·ЅїтЅбКшµгµДyЧш±к
            public int xBottom;//·ЅїтЅбКшµгµДxЧш±к
            public int yBottom;//·ЅїтЅбКшµгµДyЧш±к
            public int bCounter;//±ЈБф
        }

        //УпТф¶ФЅІІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            public byte byAudioEncType;//ТфЖµ±аВлАаРН 0-G722; 1-G711
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_AP_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sSsid;
            public uint dwMode;/* 0 mange ДЈКЅ;1 ad-hocДЈКЅЈ¬ІОјыNICMODE */
            public uint dwSecurity;  /*0 І»јУГЬЈ»1 wepјУГЬЈ»2 wpa-psk;3 wpa-EnterpriseЈ¬ІОјыWIFISECURITY*/
            public uint dwChannel;/*1-11±нКѕ11ёцНЁµА*/
            public uint dwSignalStrength;/*0-100РЕєЕУЙЧоИх±дОЄЧоЗї*/
            public uint dwSpeed;/*ЛЩВК,µҐО»КЗ0.01mbps*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AP_INFO_LIST
        {
            public uint dwSize;
            public uint dwCount;/*ОЮПЯAPКэБїЈ¬І»і¬№э20*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = WIFI_MAX_AP_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AP_INFO[] struApInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFIETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpAddress;/*IPµШЦ·*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpMask;/*СЪВл*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/*ОпАнµШЦ·Ј¬Ц»УГАґПФКѕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes;
            public uint dwEnableDhcp;/*КЗ·сЖф¶Їdhcp  0І»Жф¶Ї 1Жф¶Ї*/
            public uint dwAutoDns;/*Из№ыЖф¶ЇdhcpКЗ·сЧФ¶Ї»сИЎdns,0І»ЧФ¶Ї»сИЎ 1ЧФ¶Ї»сИЎЈ»¶ФУЪУРПЯИз№ыЖф¶ЇdhcpДїЗ°ЧФ¶Ї»сИЎdns*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDns; /*µЪТ»ёцdnsУтГы*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDns;/*µЪ¶юёцdnsУтГы*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIpAddr;/* Нш№ШµШЦ·*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TTLS
        {
            public byte byEapolVersion; //EAPOL°ж±ѕЈ¬0-°ж±ѕ1Ј¬1-°ж±ѕ2
            public byte byAuthType; //ДЪІїИПЦ¤·ЅКЅЈ¬0-PAPЈ¬1-MSCHAPV2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //ДдГыЙн·Э
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //УГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //ГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisДЈКЅККУГ

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_PEAP
        {
            public byte byEapolVersion; //EAPOL°ж±ѕЈ¬0-°ж±ѕ1Ј¬1-°ж±ѕ2
            public byte byAuthType; //ДЪІїИПЦ¤·ЅКЅЈ¬0-GTCЈ¬1-MD5Ј¬2-MSCHAPV2
            public byte byPeapVersion; //PEAP°ж±ѕЈ¬0-°ж±ѕ0Ј¬1-°ж±ѕ1
            public byte byPeapLabel; //PEAP±кЗ©Ј¬0-АП±кЗ©Ј¬1-РВ±кЗ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //ДдГыЙн·Э
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //УГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //ГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisДЈКЅККУГ

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TLS
        {
            public byte byEapolVersion; //EAPOL°ж±ѕЈ¬0-°ж±ѕ1Ј¬1-°ж±ѕ2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIdentity; //Йн·Э
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivateKeyPswd; //ЛЅФїГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct WIFI_AUTH_PARAM
        {
            [FieldOffsetAttribute(0)]
            public UNION_EAP_TTLS EAP_TTLS;//WPA-enterprise/WPA2-enterprisДЈКЅККУГ
			
            [FieldOffsetAttribute(0)]
            public UNION_EAP_PEAP EAP_PEAP; //WPA-enterprise/WPA2-enterprisДЈКЅККУГ

			[FieldOffsetAttribute(0)]
            public UNION_EAP_TLS EAP_TLS; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WEP
        {
            public uint dwAuthentication;/*0 -їЄ·ЕКЅ 1-№ІПнКЅ*/
            public uint dwKeyLength;/* 0 -64О»Ј»1- 128О»Ј»2-152О»*/
            public uint dwKeyType;/*0 16ЅшЦЖ;1 ASCI */
            public uint dwActive;/*0 ЛчТэЈє0---3±нКѕУГДДТ»ёцГЬФї*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WEP_MAX_KEY_COUNT * WIFI_WEP_MAX_KEY_LENGTH)]
            public string sKeyInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_PSK
        {
            public uint dwKeyLength;/*8-63ёцASCIIЧЦ·ы*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WPA_PSK_MAX_KEY_LENGTH)]
            public string sKeyInfo;
            public byte byEncryptType;/*WPA/WPA2ДЈКЅПВјУГЬАаРН,0-AES, 1-TKIP*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_WPA2
        {
            public byte byEncryptType;  /*јУГЬАаРН,0-AES, 1-TKIP*/
            public byte byAuthType; //ИПЦ¤АаРНЈ¬0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public WIFI_AUTH_PARAM auth_param;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFI_CFG_EX
        {
            public NET_DVR_WIFIETHERNET struEtherNet;/*wifiНшїЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sEssid;/*SSID*/
            public uint dwMode;/* 0 mange ДЈКЅ;1 ad-hocДЈКЅЈ¬ІОјы*/
            public uint dwSecurity;/*0 І»јУГЬЈ»1 wepјУГЬЈ»2 wpa-psk; */
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct key
            {
                [FieldOffsetAttribute(0)]
                public UNION_WEP wep;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_PSK wpa_psk;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_WPA2 wpa_wpa2;//WPA-enterprise/WPA2-enterprisДЈКЅККУГ
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CFG
        {
            public uint dwSize;
            public NET_DVR_WIFI_CFG_EX struWifiCfg;
        }

        //wifiБ¬ЅУЧґМ¬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CONNECT_STATUS
        {
            public uint dwSize;
            public byte byCurStatus;	//1-ТСБ¬ЅУЈ¬2-ОґБ¬ЅУЈ¬3-ХэФЪБ¬ЅУ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		//±ЈБф
            public uint dwErrorCode;	// byCurStatus = 2К±УРР§,1-УГ»§Гы»тГЬВлґнОу,2-ОЮґЛВ·УЙЖч,3-ОґЦЄґнОу
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_WORKMODE
        {
            public uint dwSize;
            public uint dwNetworkInterfaceMode;/*0 ЧФ¶ЇЗР»»ДЈКЅЎЎ1 УРПЯДЈКЅ*/
        }

        //ЦЗДЬїШЦЖРЕПў
        public const int MAX_VCA_CHAN = 16;//ЧоґуЦЗДЬНЁµАКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLINFO
        {
            public byte byVCAEnable;//КЗ·сїЄЖфЦЗДЬ
            public byte byVCAType;//ЦЗДЬДЬБ¦АаРНЈ¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA;//ВлБчЦРКЗ·сґшЦЗДЬРЕПў
            public byte byMode;//ДЈКЅЈ¬VCA_CHAN_MODE_TYPE ,atmДЬБ¦µДК±єтРиТЄЕдЦГ
            public byte byControlType;   //їШЦЖАаРНЈ¬°ґО»±нКѕЈ¬0-·сЈ¬1-КЗ
            // byControlType &1 КЗ·сЖфУГЧҐЕД№¦ДЬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЙиЦГОЄ0 
        }

        //ЦЗДЬїШЦЖРЕПўЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_CTRLINFO[] struCtrlInfo;//їШЦЖРЕПў,КэЧй0¶ФУ¦Йи±ёµДЖрКјНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ЦЗДЬЙи±ёДЬБ¦јЇ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_ABILITY
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public byte byVCAChanNum;//ЦЗДЬНЁµАёцКэ
            public byte byPlateChanNum;//іµЕЖНЁµАёцКэ
            public byte byBBaseChanNum;//РРОЄ»щ±ѕ°жёцКэ
            public byte byBAdvanceChanNum;//РРОЄёЯј¶°жёцКэ
            public byte byBFullChanNum;//РРОЄНкХы°жёцКэ
            public byte byATMChanNum;//ЦЗДЬATMёцКэ
            public byte byPDCChanNum;         //ИЛКэНіјЖНЁµАёцКэ
            public byte byITSChanNum;         //Ѕ»НЁКВјюНЁµАёцКэ
            public byte byBPrisonChanNum;     //РРОЄјаУь°ж(јаЙб)НЁµАёцКэ
            public byte byFSnapChanNum;       //ИЛБіЧҐЕДНЁµАёцКэ
            public byte byFSnapRecogChanNum;  //ИЛБіЧҐЕДєНК¶±рНЁµАёцКэ
            public byte byFRetrievalChanNum;  //ИЛБієујмЛчёцКэ
            public byte bySupport;            //ДЬБ¦Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦ
            //bySupport & 0x1Ј¬±нКѕКЗ·сЦ§іЦЦЗДЬёъЧЩ 2012-3-22
            //bySupport & 0x2Ј¬±нКѕКЗ·сЦ§іЦ128В·ИЎБчА©Х№2012-12-27
            public byte byFRecogChanNum;      //ИЛБіК¶±рНЁµАёцКэ
            public byte byBPPerimeterChanNum; //РРОЄјаУь°ж(ЦЬЅз)НЁµАёцКэ
            public byte byTPSChanNum;         //Ѕ»НЁУХµјНЁµАёцКэ
            public byte byTFSChanNum;         //µАВ·ОҐХВИЎЦ¤НЁµАёцКэ
            public byte byFSnapBFullChanNum;  //ИЛБіЧҐЕДєНРРОЄ·ЦОцНЁµАёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //РРОЄ·ЦОцДЬБ¦АаРН
        public enum VCA_ABILITY_TYPE:uint
        {
            TRAVERSE_PLANE_ABILITY = 0x01,       //ґ©ФЅѕЇЅдГж
            ENTER_AREA_ABILITY = 0x02,       //ЅшИлЗшУт
            EXIT_AREA_ABILITY = 0x04,       //АлїЄЗшУт
            INTRUSION_ABILITY = 0x08,       //ИлЗЦ
            LOITER_ABILITY = 0x10,       //ЕЗ»І
            LEFT_TAKE_ABILITY = 0x20,       //ОпЖ·ТЕБфДГИЎ
            PARKING_ABILITY = 0x40,       //НЈіµ
            RUN_ABILITY = 0x80,       //їмЛЩТЖ¶Ї
            HIGH_DENSITY_ABILITY = 0x100,      //ИЛФ±ѕЫјЇ
            LF_TRACK_ABILITY = 0x200,      //Зт»ъёъЧЩ
            VIOLENT_MOTION_ABILITY = 0x400,      //ѕзБТФЛ¶ЇјмІв
            REACH_HIGHT_ABILITY = 0x800,      //ЕКёЯјмІв
            GET_UP_ABILITY = 0x1000,     //ЖрЙнјмІв
            LEFT_ABILITY = 0x2000,     //ОпЖ·ТЕБф
            TAKE_ABILITY = 0x4000,     //ОпЖ·ДГИЎ
            LEAVE_POSITION = 0x8000,     //АлёЪ
            TRAIL_ABILITY = 0x10000,    //ОІЛж 
            KEY_PERSON_GET_UP_ABILITY = 0x20000,    //ЦШµгИЛФ±ЖрЙнјмІв
            FALL_DOWN_ABILITY = 0x80000,    //µ№µШ
            AUDIO_ABNORMAL_ABILITY = 0x100000,   //ЙщЗїН»±д
            ADV_REACH_HEIGHT_ABILITY = 0x200000,   //ХЫПЯЕКёЯ
            TOILET_TARRY_ABILITY = 0x400000,   //ИзІЮі¬К±
            YARD_TARRY_ABILITY = 0x800000,   //·Е·зіЎЦНБф
            ADV_TRAVERSE_PLANE_ABILITY = 0x1000000,  //ХЫПЯѕЇЅдГж
            HUMAN_ENTER_ABILITY = 0x10000000, //ИЛїїЅьATM ,Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ
            OVER_TIME_ABILITY = 0x20000000, //ІЩЧчі¬К±,Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ
            STICK_UP_ABILITY = 0x40000000, //МщЦЅМх
            INSTALL_SCANNER_ABILITY = 0x80000000  //°ІЧ°¶БїЁЖч
        }

        //ЦЗДЬНЁµААаРН
        public enum VCA_CHAN_ABILITY_TYPE
        {
            VCA_BEHAVIOR_BASE = 1,          //РРОЄ·ЦОц»щ±ѕ°ж
            VCA_BEHAVIOR_ADVANCE = 2,          //РРОЄ·ЦОцёЯј¶°ж
            VCA_BEHAVIOR_FULL = 3,          //РРОЄ·ЦОцНкХы°ж
            VCA_PLATE = 4,          //іµЕЖДЬБ¦
            VCA_ATM = 5,          //ATMДЬБ¦
            VCA_PDC = 6,          //ИЛБчБїНіјЖ
            VCA_ITS = 7,          //ЦЗДЬ Ѕ»НЁКВјю
            VCA_BEHAVIOR_PRISON = 8,          //РРОЄ·ЦОцјаУь°ж(јаЙб) 
            VCA_FACE_SNAP = 9,           //ИЛБіЧҐЕДДЬБ¦
            VCA_FACE_SNAPRECOG = 10,          //ИЛБіЧҐЕДєНК¶±рДЬБ¦
            VCA_FACE_RETRIEVAL = 11,          //ИЛБієујмЛчДЬБ¦
            VCA_FACE_RECOG = 12,          //ИЛБіК¶±рДЬБ¦
            VCA_BEHAVIOR_PRISON_PERIMETER = 13, // РРОЄ·ЦОцјаУь°ж (ЦЬЅз)
            VCA_TPS = 14,          //Ѕ»НЁУХµј
            VCA_TFS = 15,          //µАВ·ОҐХВИЎЦ¤
            VCA_BEHAVIOR_FACESNAP = 16           //ИЛБіЧҐЕДєНРРОЄ·ЦОцДЬБ¦
        }

        //ЦЗДЬATMДЈКЅАаРН(ATMДЬБ¦МШУР)
        public enum VCA_CHAN_MODE_TYPE
        {
            VCA_ATM_PANEL = 0,//ATMГж°е
            VCA_ATM_SURROUND = 1,//ATM»·ѕі
            VCA_ATM_FACE = 2	//ATMИЛБі
        }
        public enum TFS_CHAN_MODE_TYPE
        {
            TFS_CITYROAD = 0,  //TFS іЗКРµАВ·
            TFS_FREEWAY = 1   //TFS ёЯЛЩµАВ·
        }

        //РРОЄ·ЦОціЎѕ°ДЈКЅ
        public enum BEHAVIOR_SCENE_MODE_TYPE
        {
            BEHAVIOR_SCENE_DEFAULT = 0, //ПµНіД¬ИП
            BEHAVIOR_SCENE_WALL = 1,    //О§ЗЅ
            BEHAVIOR_SCENE_INDOOR = 2   //КТДЪ
        }

        //НЁµАДЬБ¦КдИлІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CHAN_IN_PARAM
        {
            public byte byVCAType;//VCA_CHAN_ABILITY_TYPEГ¶ѕЩЦµ
            public byte byMode;//ДЈКЅЈ¬VCA_CHAN_MODE_TYPE ,atmДЬБ¦µДК±єтРиТЄЕдЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЙиЦГОЄ0 
        }

        //РРОЄДЬБ¦јЇЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BEHAVIOR_ABILITY
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public uint dwAbilityType;//Ц§іЦµДДЬБ¦АаРНЈ¬°ґО»±нКѕЈ¬јыVCA_ABILITY_TYPE¶ЁТе
            public byte byMaxRuleNum;//Чоґу№жФтКэ
            public byte byMaxTargetNum;//ЧоґуДї±кКэ
            public byte bySupport;		// Ц§іЦµД№¦ДЬАаРН   °ґО»±нКѕ  
            // bySupport & 0x01 Ц§іЦ±к¶Ё№¦ДЬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБфЈ¬ЙиЦГОЄ0
        }

        // Ѕ»НЁДЬБ¦јЇЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_ABILITY
        {
            public uint dwSize;             // Ѕб№№МеґуРЎ
            public uint dwAbilityType;      // Ц§іЦµДДЬБ¦БР±н  ІОХХITS_ABILITY_TYPE
            public byte byMaxRuleNum;	 	//Чоґу№жФтКэ
            public byte byMaxTargetNum; 	//ЧоґуДї±кКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±ЈБф
        }
        /***********************************end*******************************************/

        /************************************ЦЗДЬІОКэЅб№№*********************************/
        //ЦЗДЬ№ІУГЅб№№
        //Чш±кЦµ№йТ»»Ї,ёЎµгКэЦµОЄµ±З°»­ГжµД°Щ·Ц±ИґуРЎ, ѕ«¶ИОЄРЎКэµгєуИэО»
        //µгЧш±кЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POINT
        {
            public float fX;// XЦбЧш±к, 0.001~1
            public float fY;//YЦбЧш±к, 0.001~1
        }

        //ЗшУтїтЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RECT
        {
            public float fX;//±ЯЅзїтЧуЙПЅЗµгµДXЦбЧш±к, 0.001~1
            public float fY;//±ЯЅзїтЧуЙПЅЗµгµДYЦбЧш±к, 0.001~1
            public float fWidth;//±ЯЅзїтµДїн¶И, 0.001~1
            public float fHeight;//±ЯЅзїтµДёЯ¶И, 0.001~1
        }

        //РРОЄ·ЦОцКВјюАаРН
        public enum VCA_EVENT_TYPE : uint
        {
            VCA_TRAVERSE_PLANE = 0x1,        //ґ©ФЅѕЇЅдГж
            VCA_ENTER_AREA = 0x2,        //Дї±кЅшИлЗшУт,Ц§іЦЗшУт№жФт
            VCA_EXIT_AREA = 0x4,        //Дї±кАлїЄЗшУт,Ц§іЦЗшУт№жФт
            VCA_INTRUSION = 0x8,        //ЦЬЅзИлЗЦ,Ц§іЦЗшУт№жФт
            VCA_LOITER = 0x10,       //ЕЗ»І,Ц§іЦЗшУт№жФт
            VCA_LEFT_TAKE = 0x20,       //ОпЖ·ТЕБфДГИЎ,Ц§іЦЗшУт№жФт
            VCA_PARKING = 0x40,       //НЈіµ,Ц§іЦЗшУт№жФт
            VCA_RUN = 0x80,       //їмЛЩТЖ¶Ї,Ц§іЦЗшУт№жФт
            VCA_HIGH_DENSITY = 0x100,      //ЗшУтДЪИЛФ±ѕЫјЇ,Ц§іЦЗшУт№жФт
            VCA_VIOLENT_MOTION = 0x200,		 //ѕзБТФЛ¶ЇјмІв
            VCA_REACH_HIGHT = 0x400,		 //ЕКёЯјмІв
            VCA_GET_UP = 0x800,	     //ЖрЙнјмІв
            VCA_LEFT = 0x1000,     //ОпЖ·ТЕБф
            VCA_TAKE = 0x2000,     //ОпЖ·ДГИЎ
            VCA_LEAVE_POSITION = 0x4000,     //АлёЪ
            VCA_TRAIL = 0x8000,     //ОІЛж
            VCA_KEY_PERSON_GET_UP = 0x10000,    //ЦШµгИЛФ±ЖрЙнјмІв
            VCA_FALL_DOWN = 0x80000,    //µ№µШјмІв
            VCA_AUDIO_ABNORMAL = 0x100000,   //ЙщЗїН»±дјмІв
            VCA_ADV_REACH_HEIGHT = 0x200000,   //ХЫПЯЕКёЯ
            VCA_TOILET_TARRY = 0x400000,   //ИзІЮі¬К±
            VCA_YARD_TARRY = 0x800000,   //·Е·зіЎЦНБф
            VCA_ADV_TRAVERSE_PLANE = 0x1000000,  //ХЫПЯѕЇЅдГж
            VCA_HUMAN_ENTER = 0x10000000, //ИЛїїЅьATM           Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ
            VCA_OVER_TIME = 0x20000000, //ІЩЧчі¬К±            Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ
            VCA_STICK_UP = 0x40000000, //МщЦЅМх,Ц§іЦЗшУт№жФт
            VCA_INSTALL_SCANNER = 0x80000000  //°ІЧ°¶БїЁЖч,Ц§іЦЗшУт№жФт
        }

        //РРОЄ·ЦОцКВјюАаРНА©Х№
        public enum VCA_RULE_EVENT_TYPE_EX
        {
            ENUM_VCA_EVENT_TRAVERSE_PLANE = 1,   //ґ©ФЅѕЇЅдГж
            ENUM_VCA_EVENT_ENTER_AREA = 2,   //Дї±кЅшИлЗшУт,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_EXIT_AREA = 3,   //Дї±кАлїЄЗшУт,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_INTRUSION = 4,   //ЦЬЅзИлЗЦ,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_LOITER = 5,   //ЕЗ»І,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_LEFT_TAKE = 6,   //ОпЖ·ТЕБфДГИЎ,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_PARKING = 7,   //НЈіµ,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_RUN = 8,   //їмЛЩТЖ¶Ї,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_HIGH_DENSITY = 9,   //ЗшУтДЪИЛФ±ѕЫјЇ,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_VIOLENT_MOTION = 10,  //ѕзБТФЛ¶ЇјмІв
            ENUM_VCA_EVENT_REACH_HIGHT = 11,  //ЕКёЯјмІв
            ENUM_VCA_EVENT_GET_UP = 12,  //ЖрЙнјмІв
            ENUM_VCA_EVENT_LEFT = 13,  //ОпЖ·ТЕБф
            ENUM_VCA_EVENT_TAKE = 14,  //ОпЖ·ДГИЎ
            ENUM_VCA_EVENT_LEAVE_POSITION = 15,  //АлёЪ
            ENUM_VCA_EVENT_TRAIL = 16,  //ОІЛж
            ENUM_VCA_EVENT_KEY_PERSON_GET_UP = 17,  //ЦШµгИЛФ±ЖрЙнјмІв
            ENUM_VCA_EVENT_FALL_DOWN = 20,  //µ№µШјмІв
            ENUM_VCA_EVENT_AUDIO_ABNORMAL = 21,  //ЙщЗїН»±дјмІв
            ENUM_VCA_EVENT_ADV_REACH_HEIGHT = 22,  //ХЫПЯЕКёЯ
            ENUM_VCA_EVENT_TOILET_TARRY = 23,  //ИзІЮі¬К±
            ENUM_VCA_EVENT_YARD_TARRY = 24,  //·Е·зіЎЦНБф
            ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE = 25,  //ХЫПЯѕЇЅдГж
            ENUM_VCA_EVENT_HUMAN_ENTER = 29,  //ИЛїїЅьATM,Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ   
            ENUM_VCA_EVENT_OVER_TIME = 30,  //ІЩЧчі¬К±,Ц»ФЪATM_PANELДЈКЅПВЦ§іЦ
            ENUM_VCA_EVENT_STICK_UP = 31,  //МщЦЅМх,Ц§іЦЗшУт№жФт
            ENUM_VCA_EVENT_INSTALL_SCANNER = 32   //°ІЧ°¶БїЁЖч,Ц§іЦЗшУт№жФт
        }

        //ѕЇЅдГжґ©ФЅ·ЅПтАаРН
        public enum VCA_CROSS_DIRECTION
        {
            VCA_BOTH_DIRECTION,// Л«Пт 
            VCA_LEFT_GO_RIGHT,// УЙЧуЦБУТ 
            VCA_RIGHT_GO_LEFT,// УЙУТЦБЧу 
        }

        //ПЯЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE
        {
            public NET_VCA_POINT struStart;//Жрµг 
            public NET_VCA_POINT struEnd; //ЦХµг

            //             public void init()
            //             {
            //                 struStart = new NET_VCA_POINT();
            //                 struEnd = new NET_VCA_POINT();
            //             }
        }

        //ёГЅб№№»бµјЦВxamlЅзГжіцІ»АґЈЎЈЎЈЎЈЎЈЎЈЎЈЎЈЎЈЎЈїЈїОКМвФЭК±»№Г»УРХТµЅ  
        //ФЭК±ЖБ±ОЅб№№ПИ
        //¶а±ЯРНЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POLYGON
        {
            /// DWORD->unsigned int
            public uint dwPointNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = VCA_MAX_POLYGON_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE
        {
            public NET_VCA_LINE struPlaneBottom;//ѕЇЅдГжµЧ±Я
            public VCA_CROSS_DIRECTION dwCrossDirection;//ґ©ФЅ·ЅПт: 0-Л«ПтЈ¬1-ґУЧуµЅУТЈ¬2-ґУУТµЅЧу
            public byte byRes1;//±ЈБф
            public byte byPlaneHeight;//ѕЇЅдГжёЯ¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            //             public void init()
            //             {
            //                 struPlaneBottom = new NET_VCA_LINE();
            //                 struPlaneBottom.init();
            //                 byRes2 = new byte[38];
            //             }
        }

        //ЅшИл/АлїЄЗшУтІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AREA
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ёщѕЭ±ЁѕЇСУіЩК±јдАґ±кК¶±ЁѕЇЦРґшНјЖ¬Ј¬±ЁѕЇјдёфєНIO±ЁѕЇТ»ЦВЈ¬1Гл·ўЛНТ»ёцЎЈ
        //ИлЗЦІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_INTRUSION
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//±ЁѕЇСУіЩК±јд: 1-120ГлЈ¬ЅЁТй5ГлЈ¬ЕР¶ПКЗУРР§±ЁѕЇµДК±јд
            public byte bySensitivity;        //БйГф¶ИІОКэЈ¬·¶О§[1-100]
            public byte byRate;               //Хј±ИЈєЗшУтДЪЛщУРОґ±ЁѕЇДї±кіЯґзДї±кХјЗшУтГж»эµД±ИЦШЈ¬№йТ»»ЇОЄЈ­Ј»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ЕЗ»ІІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LOITER
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//ґҐ·ўЕЗ»І±ЁѕЇµДіЦРшК±јдЈє1-120ГлЈ¬ЅЁТй10Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶Є°ь/јс°ьІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE_LEFT
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//ґҐ·ў¶Є°ь/јс°ь±ЁѕЇµДіЦРшК±јдЈє1-120ГлЈ¬ЅЁТй10Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //НЈіµІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PARKING
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//ґҐ·ўНЈіµ±ЁѕЇіЦРшК±јдЈє1-120ГлЈ¬ЅЁТй10Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±јЕЬІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RUN
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public float fRunDistance;//ИЛ±јЕЬЧоґуѕаАл, ·¶О§: [0.1, 1.00]
            public byte byRes1;             // ±ЈБфЧЦЅЪ
            public byte byMode;             // 0 ПсЛШДЈКЅ  1 КµјКДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ИЛФ±ѕЫјЇІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HIGH_DENSITY
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public float fDensity;//ГЬ¶И±ИВК, ·¶О§: [0.1, 1.0]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public ushort wDuration;      // ґҐ·ўИЛФ±ѕЫјЇІОКэ±ЁѕЇгРЦµ 20-360s
        }

        //ѕзБТФЛ¶ЇІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_VIOLENT_MOTION
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;           //ґҐ·ўѕзБТФЛ¶Ї±ЁѕЇгРЦµЈє1-50Гл
            public byte bySensitivity;       //БйГф¶ИІОКэЈ¬·¶О§[1,5]
            public byte byMode;              //0-ґїКУЖµДЈКЅЈ¬1-ТфКУЖµБЄєПДЈКЅЈ¬2-ґїТфЖµДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±ЈБф
        }

        //ЕКёЯІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REACH_HIGHT
        {
            public NET_VCA_LINE struVcaLine;   //ЕКёЯѕЇЅдГж
            public ushort wDuration; //ґҐ·ўЕКёЯ±ЁѕЇгРЦµЈє1-120Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±ЈБфЧЦЅЪ
        }

        //ЖрґІІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_GET_UP
        {
            public NET_VCA_POLYGON struRegion; //ЗшУт·¶О§
            public ushort wDuration;	        //ґҐ·ўЖрґІ±ЁѕЇгРЦµ1-100 Гл
            public byte byMode;             //ЖрЙнјмІвДЈКЅ,0-ґуґІНЁЖМДЈКЅ,1-ёЯµНЖМДЈКЅ,2-ґуґІНЁЖМЧшБўЖрЙнДЈКЅ
            public byte bySensitivity;      //БйГф¶ИІОКэЈ¬·¶О§[1,10]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±ЈБфЧЦЅЪ
        }

        //ОпЖ·ТЕБф
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEFT
        {
            public NET_VCA_POLYGON struRegion; // ЗшУт·¶О§
            public ushort wDuration;       // ґҐ·ўОпЖ·ТЕБф±ЁѕЇгРЦµ 10-100Гл
            public byte bySensitivity;   // БйГф¶ИІОКэЈ¬·¶О§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // ±ЈБфЧЦЅЪ
        }

        // ОпЖ·ДГИЎ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE
        {
            public NET_VCA_POLYGON struRegion;     // ЗшУт·¶О§
            public ushort wDuration;      // ґҐ·ўОпЖ·ДГИЎ±ЁѕЇгРЦµ10-100Гл
            public byte bySensitivity;  // БйГф¶ИІОКэЈ¬·¶О§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_OVER_TIME
        {
            public NET_VCA_POLYGON struRegion;    // ЗшУт·¶О§
            public ushort wDuration;  // ІЩЧч±ЁѕЇК±јдгРЦµ 4s-60000s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ENTER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;			//±ЈБфЧЦЅЪ
        }

        //МщЦЅМхІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_STICK_UP
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//±ЁѕЇіЦРшК±јдЈє10-60ГлЈ¬ЅЁТй10Гл
            public byte bySensitivity;//БйГф¶ИІОКэЈ¬·¶О§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶БїЁЖчІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SCANNER
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;//¶БїЁіЦРшК±јдЈє10-60Гл
            public byte bySensitivity;//БйГф¶ИІОКэЈ¬·¶О§[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //АлёЪКВјю
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEAVE_POSITION
        {
            public NET_VCA_POLYGON struRegion; //ЗшУт·¶О§
            public ushort wLeaveDelay;  //ОЮИЛ±ЁѕЇК±јдЈ¬µҐО»ЈєsЈ¬ИЎЦµ1-1800
            public ushort wStaticDelay; //ЛЇѕх±ЁѕЇК±јдЈ¬µҐО»ЈєsЈ¬ИЎЦµ1-1800
            public byte byMode;       //ДЈКЅЈ¬0-АлёЪКВјюЈ¬1-ЛЇёЪКВјюЈ¬2-АлёЪЛЇёЪКВјю
            public byte byPersonType; //ЦµёЪИЛКэАаРНЈ¬0-µҐИЛЦµёЪЈ¬1-Л«ИЛЦµёЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
        }

        //ОІЛжІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAIL
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wRes;      /* ±ЈБф */
            public byte bySensitivity;       /* БйГф¶ИІОКэЈ¬·¶О§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //µ№µШІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FALL_DOWN
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDuration;      /* ґҐ·ўКВјюгРЦµ 1-60s*/
            public byte bySensitivity;       /* БйГф¶ИІОКэЈ¬·¶О§[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ЙщЗїН»±дІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AUDIO_ABNORMAL
        {
            public ushort wDecibel;       //ЙщТфЗї¶И
            public byte bySensitivity;  //БйГф¶ИІОКэЈ¬·¶О§[1,5] 
            public byte byAudioMode;    //ЙщТфјмІвДЈКЅЈ¬0-БйГф¶ИјмІвЈ¬1-·Ц±ґгРЦµјмІвЈ¬2-БйГф¶ИУл·Ц±ґгРЦµјмІв 
            public byte byEnable;       //К№ДЬЈ¬КЗ·сїЄЖф
            public byte byThreshold;    //ЙщТфгРЦµ[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±ЈБф   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_EXCEPTION
        {
            public uint dwSize;
            public byte byEnableAudioInException;  //К№ДЬЈ¬КЗ·сїЄЖф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched; //Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;  //ТміЈґ¦Ан·ЅКЅ
            public uint dwMaxRelRecordChanNum;  //±ЁѕЇґҐ·ўµДВјПуНЁµА КэЈЁЦ»¶БЈ©ЧоґуЦ§іЦКэБї
            public uint dwRelRecordChanNum;     //±ЁѕЇґҐ·ўµДВјПуНЁµА Кэ КµјКЦ§іЦµДКэБї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TOILET_TARRY
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDelay;        //ИзІЮі¬К±К±јд[1,3600]Ј¬µҐО»ЈєГл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_YARD_TARRY
        {
            public NET_VCA_POLYGON struRegion;//ЗшУт·¶О§
            public ushort wDelay;        //·Е·зіЎЦНБфК±јд[1,120]Ј¬µҐО»ЈєГл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_REACH_HEIGHT
        {
            public NET_VCA_POLYGON struRegion; //ЕКёЯХЫПЯ
            public uint dwCrossDirection;   //їзФЅ·ЅПт(ПкјыVCA_CROSS_DIRECTION): 0-Л«ПтЈ¬1-ґУЧуµЅУТ2-ґУУТµЅЧу
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_TRAVERSE_PLANE
        {
            public NET_VCA_POLYGON struRegion; //ѕЇЅдГжХЫПЯ
            public uint dwCrossDirection;   //їзФЅ·ЅПт(ПкјыVCA_CROSS_DIRECTION): 0-Л«ПтЈ¬1-ґУЧуµЅУТ2-ґУУТµЅЧу
            public byte bySensitivity;      //БйГф¶ИІОКэЈ¬·¶О§[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //±ЈБфЧЦЅЪ
        }

        //ѕЇЅдКВјюІОКэ
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;//ІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_TRAVERSE_PLANE struTraversePlane;//ґ©ФЅѕЇЅдГжІОКэ 
            [FieldOffsetAttribute(0)]
            public NET_VCA_AREA struArea;//ЅшИл/АлїЄЗшУтІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_INTRUSION struIntrusion;//ИлЗЦІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_LOITER struLoiter;//ЕЗ»ІІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_TAKE_LEFT struTakeTeft;//¶Є°ь/јс°ьІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_PARKING struParking;//НЈіµІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_RUN struRun;//±јЕЬІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_HIGH_DENSITY struHighDensity;//ИЛФ±ѕЫјЇІОКэ  
            [FieldOffsetAttribute(0)]
            public NET_VCA_VIOLENT_MOTION struViolentMotion;	//ѕзБТФЛ¶Ї
            [FieldOffsetAttribute(0)]
            public NET_VCA_REACH_HIGHT struReachHight;      //ЕКёЯ
            [FieldOffsetAttribute(0)]
            public NET_VCA_GET_UP struGetUp;           //ЖрґІ
            [FieldOffsetAttribute(0)]
            public NET_VCA_LEFT struLeft;            //ОпЖ·ТЕБф
            [FieldOffsetAttribute(0)]
            public NET_VCA_TAKE struTake;            // ОпЖ·ДГИЎ
            [FieldOffsetAttribute(0)]
            public NET_VCA_HUMAN_ENTER struHumanEnter;      //ИЛФ±ЅшИл
            [FieldOffsetAttribute(0)]
            public NET_VCA_OVER_TIME struOvertime;        //ІЩЧчі¬К±
            [FieldOffsetAttribute(0)]
            public NET_VCA_STICK_UP struStickUp;//МщЦЅМх
            [FieldOffsetAttribute(0)]
            public NET_VCA_SCANNER struScanner;//¶БїЁЖчІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_LEAVE_POSITION struLeavePos;        //АлёЪІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_TRAIL struTrail;           //ОІЛжІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_FALL_DOWN struFallDown;        //µ№µШІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;   //ЙщЗїН»±д
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADV_REACH_HEIGHT struReachHeight;     //ХЫПЯЕКёЯІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_TOILET_TARRY struToiletTarry;     //ИзІЮі¬К±ІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_YARD_TARRY struYardTarry;       //·Е·зіЎЦНБфІОКэ
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADV_TRAVERSE_PLANE struAdvTraversePlane;//ХЫПЯѕЇЅдГжІОКэ            
        }

        // іЯґз№эВЛЖчАаРН
        public enum SIZE_FILTER_MODE
        {
            IMAGE_PIX_MODE,//ёщѕЭПсЛШґуРЎЙиЦГ
            REAL_WORLD_MODE,//ёщѕЭКµјКґуРЎЙиЦГ
            DEFAULT_MODE 	// Д¬ИПДЈКЅ
        }

        //іЯґз№эВЛЖч
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SIZE_FILTER
        {
            public byte byActive;//КЗ·сј¤»оіЯґз№эВЛЖч 0-·с ·З0-КЗ
            public byte byMode;//№эВЛЖчДЈКЅSIZE_FILTER_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЦГ0
            public NET_VCA_RECT struMiniRect;//ЧоРЎДї±кїт,И«0±нКѕІ»ЙиЦГ
            public NET_VCA_RECT struMaxRect;//ЧоґуДї±кїт,И«0±нКѕІ»ЙиЦГ
        }

        //ѕЇЅд№жФтЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE
        {
            public byte byActive;//КЗ·сј¤»о№жФт,0-·с,·З0-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЙиЦГОЄ0ЧЦ¶О
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//№жФтГыіЖ
            public VCA_EVENT_TYPE dwEventType;//РРОЄ·ЦОцКВјюАаРН
            public NET_VCA_EVENT_UNION uEventParam;//РРОЄ·ЦОцКВјюІОКэ
            public NET_VCA_SIZE_FILTER struSizeFilter;//іЯґз№эВЛЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
        }

        //РРОЄ·ЦОцЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public byte byPicProType;//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPictureParam;//НјЖ¬№жёсЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE[] struRule;//№жФтКэЧй
        }

        //іЯґз№эВЛІЯВФ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FILTER_STRATEGY
        {
            public byte byStrategy;      //іЯґз№эВЛІЯВФ 0 - І»ЖфУГ 1-ёЯ¶ИєНїн¶И№эВЛ,2-Гж»э№эВЛ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±ЈБф
        }

        //№жФтґҐ·ўІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_TRIGGER_PARAM
        {
            public byte byTriggerMode;   //№жФтµДґҐ·ў·ЅКЅЈ¬0- І»ЖфУГЈ¬1- №мјЈµг 2- Дї±кГж»э 
            public byte byTriggerPoint;  //ґҐ·ўµгЈ¬ґҐ·ў·ЅКЅОЄ№мјЈµгК±УРР§ 0- ЦР,1-ЙП,2-ПВ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±ЈБф
            public float fTriggerArea;    //ґҐ·ўДї±кГж»э°Щ·Ц±И [0,100]Ј¬ґҐ·ў·ЅКЅОЄДї±кГж»эК±УРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±ЈБф
        }

        //ѕЇЅд№жФтЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE_V41
        {
            public byte byActive; //КЗ·сј¤»о№жФт,0-·с,·З0-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±ЈБфЈ¬ЙиЦГОЄ0ЧЦ¶О
            public ushort wEventTypeEx; //РРОЄКВјюАаРНА©Х№Ј¬УГУЪґъМжЧЦ¶ОdwEventTypeЈ¬ІОїјVCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //№жФтГыіЖ
            public VCA_EVENT_TYPE dwEventType;	//РРОЄКВјюАаРНЈ¬±ЈБфКЗОЄБЛјжИЭЈ¬єуРшЅЁТйК№УГwEventTypeEx»сИЎКВјюАаРН
            public NET_VCA_EVENT_UNION uEventParam; //РРОЄ·ЦОцКВјюІОКэ
            public NET_VCA_SIZE_FILTER struSizeFilter;  //іЯґз№эВЛЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            public ushort wAlarmDelay; //ЦЗДЬ±ЁѕЇСУК±Ј¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
            public NET_VCA_FILTER_STRATEGY struFilterStrategy; //іЯґз№эВЛІЯВФ
            public NET_VCA_RULE_TRIGGER_PARAM struTriggerParam;   //№жФтґҐ·ўІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //РРОЄ·ЦОцЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG_V41
        {
            public uint dwSize;			//Ѕб№№і¤¶И
            public byte byPicProType;	//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            public byte byUpLastAlarm; //2011-04-06 КЗ·сПИЙПґ«ЧоЅьТ»ґОµД±ЁѕЇ
            public byte byPicRecordEnable;  /*2012-3-1КЗ·сЖфУГНјЖ¬ґжґў, 0-І»ЖфУГ, 1-ЖфУГ*/
            public byte byRes1;
            public NET_DVR_JPEGPARA struPictureParam; 		//НјЖ¬№жёсЅб№№	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE_V41[] struRule;  //№жФтКэЧй
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //јт»ЇДї±кЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TARGET_INFO
        {
            public uint dwID;//Дї±кID ,ИЛФ±ГЬ¶И№эёЯ±ЁѕЇК±ОЄ0
            public NET_VCA_RECT struRect; //Дї±к±ЯЅзїт 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //јт»ЇµД№жФтРЕПў, °ьє¬№жФтµД»щ±ѕРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_INFO
        {
            public byte byRuleID;//№жФтID,0-7
            public byte byRes;//±ЈБф
            public ushort wEventTypeEx;   //РРОЄКВјюАаРНА©Х№Ј¬УГУЪґъМжЧЦ¶ОdwEventTypeЈ¬ІОїјVCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//№жФтГыіЖ
            public VCA_EVENT_TYPE dwEventType;//ѕЇЅдКВјюАаРН
            public NET_VCA_EVENT_UNION uEventParam;//КВјюІОКэ
        }

        //З°¶ЛЙи±ёµШЦ·РЕПўЈ¬ЦЗДЬ·ЦОцТЗ±нКѕµДКЗЗ°¶ЛЙи±ёµДµШЦ·РЕПўЈ¬ЖдЛыЙи±ё±нКѕ±ѕ»ъµДµШЦ·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_INFO
        {
            public NET_DVR_IPADDR struDevIP;//З°¶ЛЙи±ёµШЦ·Ј¬
            public ushort wPort;//З°¶ЛЙи±ё¶ЛїЪєЕЈ¬ 
            public byte byChannel;//З°¶ЛЙи±ёНЁµАЈ¬
            public byte byRes;// ±ЈБфЧЦЅЪ
        }

        //РРОЄ·ЦОцЅб№ыЙП±ЁЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_ALARM
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public uint dwRelativeTime;//Па¶ФК±±к
            public uint dwAbsTime;//ѕш¶ФК±±к
            public NET_VCA_RULE_INFO struRuleInfo;//КВјю№жФтРЕПў
            public NET_VCA_TARGET_INFO struTargetInfo;//±ЁѕЇДї±кРЕПў
            public NET_VCA_DEV_INFO struDevInfo;//З°¶ЛЙи±ёРЕПў
            public uint dwPicDataLen;//·µ»ШНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ*/
            public byte byPicType;		//  0-ЖХНЁНјЖ¬ 1-¶Ф±ИНјЖ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±ЈБфЈ¬ЙиЦГОЄ0
            public IntPtr pImage;//ЦёПтНјЖ¬µДЦёХл
        }

        //РРОЄ·ЦОц№жФтDSPРЕПўµюјУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DRAW_MODE
        {
            public uint dwSize;
            public byte byDspAddTarget;//±аВлКЗ·сµюјУДї±к
            public byte byDspAddRule;//±аВлКЗ·сµюјУ№жФт
            public byte byDspPicAddTarget;//ЧҐНјКЗ·сµюјУДї±к
            public byte byDspPicAddRule;//ЧҐНјКЗ·сµюјУ№жФт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ОпМеАаРН
        public enum OBJECT_TYPE_ENUM
        {
            ENUM_OBJECT_TYPE_COAT = 1  //ЙПТВ
        }

        //ОпМеСХЙ«МхјюЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_COND
        {
            public uint dwChannel;   //НЁµАєЕ
            public uint dwObjType;   //ОпМеАаРНЈ¬ІОјыOBJECT_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±ЈБф
        }

        //НјЖ¬ІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIC
        {
            public byte byPicType;        //НјЖ¬АаРНЈ¬1-jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±ЈБф
            public uint dwPicWidth;       //НјЖ¬їн¶И
            public uint dwPicHeight;      //НјЖ¬ёЯ¶И
            public uint dwPicDataLen;     //НјЖ¬КэѕЭКµјКґуРЎ
            public uint dwPicDataBuffLen; //НјЖ¬КэѕЭ»єіеЗшґуРЎ
            public IntPtr byPicDataBuff;    //НјЖ¬КэѕЭ»єіеЗш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //±ЈБф
        }

        //СХЙ«БЄєПМе
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_UNION
        {
            public NET_DVR_COLOR struColor;   //СХЙ«Цµ
            public NET_DVR_PIC struPicture; //НјЖ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±ЈБф
        }

        //ОпМеСХЙ«ІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR
        {
            public uint dwSize;       //Ѕб№№МеґуРЎ
            public byte byEnable;     //0-І»ЖфУГЈ¬1-ЖфУГ
            public byte byColorMode;  //ИЎЙ«·ЅКЅЈ¬1-СХЙ«ЦµЈ¬2-НјЖ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±ЈБф
            public NET_DVR_OBJECT_COLOR_UNION uObjColor; //ОпМеСХЙ«БЄєПМеЈ¬ИЎЦµТААµУЪИЎЙ«·ЅКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±ЈБф
        }

        //ЗшУтАаРН
        public enum AREA_TYPE_ENUM
        {
            ENUM_OVERLAP_REGION = 1,//№ІН¬ЗшУт
            ENUM_BED_LOCATION = 2   //ґІЖМО»ЦГ
        }

        //ёЁЦъЗшУт
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA
        {
            public uint dwAreaType;   //ЗшУтАаРНЈ¬ІОјыAREA_TYPE_ENUM
            public byte byEnable;     //0-І»ЖфУГЈ¬1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     //±ЈБф
            public NET_VCA_POLYGON struPolygon; //ЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±ЈБф
        }

        //ёЁЦъЗшУтБР±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA_LIST
        {
            public uint dwSize;	// Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AUXAREA[] struArea; //ёЁЦъЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±ЈБф
        }

        //НЁµА№¤ЧчДЈКЅ
        public enum CHAN_WORKMODE_ENUM
        {
            ENUM_CHAN_WORKMODE_INDEPENDENT = 1,  //¶АБўДЈКЅ
            ENUM_CHAN_WORKMODE_MASTER = 2,      //ЦчДЈКЅ
            ENUM_CHAN_WORKMODE_SLAVE = 3        //ґУДЈКЅ
        }

        //НЁµА№¤ЧчДЈКЅІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_WORKMODE
        {
            public uint dwSize;        //Ѕб№№МеґуРЎ
            public byte byWorkMode;    //№¤ЧчДЈКЅЈ¬ІОјыCHAN_WORKMODE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
        }

        //Йи±ёНЁµАІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddress;	//Йи±ёIP»тУтГы
            public ushort wDVRPort;			 	    //¶ЛїЪєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	        //Цч»ъУГ»§Гы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;       //Цч»ъГЬВл
            public uint dwChannel;                   //НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  //±ЈБф
        }

        //ґУНЁµАРЕПўБЄєПМе
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_SLAVE_CHANNEL_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //БЄєПМеґуРЎ
            [FieldOffsetAttribute(0)]
            public uint dwLocalChannel;    //±ѕ»ъНЁµА
            [FieldOffsetAttribute(0)]
            public NET_DVR_CHANNEL struRemoteChannel; //Ф¶іМНЁµА
        }

        //ґУНЁµАІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_PARAM
        {
            public byte byChanType;   //ґУНЁµААаРНЈ¬1-±ѕ»ъНЁµАЈ¬2-Ф¶іМНЁµА 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±ЈБф
            public NET_DVR_SLAVE_CHANNEL_UNION uSlaveChannel; //ґУНЁµАБЄєПМеЈ¬ИЎЦµТААµУЪbyChanType
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±ЈБф
        }


        //ґУНЁµАІОКэЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_CFG
        {
            public uint dwSize;   //Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SLAVE_CHANNEL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SLAVE_CHANNEL_PARAM[] struChanParam;//ґУНЁµАІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        //КУЖµЦКБїХп¶ПјмІвКВјю
        public enum VQD_EVENT_ENUM
        {
            ENUM_VQD_EVENT_BLUR = 1,  //НјПсДЈєэ
            ENUM_VQD_EVENT_LUMA = 2,  //ББ¶ИТміЈ
            ENUM_VQD_EVENT_CHROMA = 3,  //НјПсЖ«Й«
            ENUM_VQD_EVENT_SNOW = 4,  //С©»ЁёЙИЕ
            ENUM_VQD_EVENT_STREAK = 5,  //МхОЖёЙИЕ
            ENUM_VQD_EVENT_FREEZE = 6,  //»­Гж¶іЅб
            ENUM_VQD_EVENT_SIGNAL_LOSS = 7,  //РЕєЕ¶ЄК§
            ENUM_VQD_EVENT_PTZ = 8,  //ФЖМЁК§їШ
            ENUM_VQD_EVENT_SCNENE_CHANGE = 9,  //іЎѕ°Н»±д
            ENUM_VQD_EVENT_VIDEO_ABNORMAL = 10, //КУЖµТміЈ
            ENUM_VQD_EVENT_VIDEO_BLOCK = 11, //КУЖµХЪµІ
        }

        //КУЖµЦКБїХп¶ПКВјюМхјюЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_COND
        {
            public uint dwChannel;   //НЁµАєЕ
            public uint dwEventType; //јмІвКВјюАаРНЈ¬ІОјыVQD_EVENT_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±ЈБф
        }

        //КУЖµЦКБїХп¶ПКВјюІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_PARAM
        {
            public byte byThreshold;    //±ЁѕЇгРЦµЈ¬·¶О§[0,100]
            public byte byTriggerMode;  //1-іЦРшґҐ·ўЈ¬2-µҐґОґҐ·ў
            public byte byUploadPic;    //0-І»ЙПґ«НјЖ¬Ј¬1-ЙПґ«НјЖ¬Ј¬ОЮВЫКЗ·сЙПґ«НјЖ¬Ј¬КВєу¶јїЙТФґУЙи±ё»сИЎёГКВјюЛщ¶ФУ¦ЧоРВµДТ»ХЕ±ЁѕЇНјЖ¬Ј¬ІОјыЅУїЪNET_DVR_StartDownload
            public byte byRes1;         //±ЈБф
            public uint dwTimeInterval; //іЦРшґҐ·ў±ЁѕЇК±јдјдёфЈ¬·¶О§[0,3600] µҐО»ЈєГл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±ЈБф
        }

        //КУЖµЦКБїХп¶ПКВјю№жФт
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_RULE
        {
            public uint dwSize;       //Ѕб№№МеґуРЎ 
            public byte byEnable;     //0-І»ЖфУГЈ¬1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±ЈБф
            public NET_DVR_VQD_EVENT_PARAM struEventParam; //КУЖµЦКБїХп¶ПКВјюІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//јмІвК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;  //ґ¦Ан·ЅКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±ЁѕЇґҐ·ўµДВјПуНЁµАЈє1±нКѕґҐ·ўёГНЁµАЈ»0±нКѕІ»ґҐ·ў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        //»щЧјіЎѕ°ІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASELINE_SCENE
        {
            public uint dwSize;     //Ѕб№№МеґуРЎ
            public byte byEnable;   //0-І»ЖфУГЈ¬1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        //»щЧјіЎѕ°ІЩЧчІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_BASELINE_SCENE_PARAM
        {
            public uint dwSize;     //Ѕб№№МеґуРЎ
            public uint dwChannel;  //НЁµАєЕ
            public byte byCommand;  //ІЩЧчАаРНЈ¬1-ґЛЧЦ¶О±ЈБфЈ¬ФЭІ»К№УГЈ¬2-ёьРВ»щЧјіЎѕ°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        //КУЖµЦКБїХп¶П±ЁѕЇЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_ALARM
        {
            public uint dwSize;                //Ѕб№№МеґуРЎ
            public uint dwRelativeTime;        //Па¶ФК±±к
            public uint dwAbsTime;	          //ѕш¶ФК±±к
            public NET_VCA_DEV_INFO struDevInfo; //З°¶ЛЙи±ёРЕПў 
            public uint dwEventType;           //КВјюАаРНЈ¬ІОїјVQD_EVENT_ENUM
            public float fThreshold;            //±ЁѕЇгРЦµ[0.000,1.000]
            public uint dwPicDataLen;          //НјЖ¬і¤¶ИЈ¬ОЄ0±нКѕГ»УРНјЖ¬
            public IntPtr pImage;               //ЦёПтНјЖ¬µДЦёХл 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //±ЈБф
        }

        //±к¶ЁµгЧУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CB_POINT
        {
            public NET_VCA_POINT struPoint;     //±к¶ЁµгЈ¬ЦчЙгПс»ъЈЁЗ№»ъЈ©
            public NET_DVR_PTZPOS struPtzPos;  //Зт»ъКдИлµДPTZЧш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±к¶ЁІОКэЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CALIBRATION_PARAM
        {
            public byte byPointNum;			//УРР§±к¶ЁµгёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint; //±к¶ЁµгЧй
        }

        //Зт»ъЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CFG
        {
            public uint dwSize;				//Ѕб№№і¤¶И	
            public byte byEnable;				//±к¶ЁК№ДЬ
            public byte byFollowChan;          // ±»їШЦЖµДґУНЁµА
            public byte byDomeCalibrate;			//ЙиЦГЦЗДЬёъЧЩЗт»ъ±к¶ЁЈ¬1ЙиЦГ 0І»ЙиЦГ 
            public byte byRes;					// ±ЈБфЧЦЅЪ
            public NET_DVR_TRACK_CALIBRATION_PARAM struCalParam; //±к¶ЁµгЧй
        }

        //ёъЧЩДЈКЅ
        public enum TRACK_MODE
        {
            MANUAL_CTRL = 0,  //КЦ¶ЇёъЧЩ
            ALARM_TRACK    //±ЁѕЇґҐ·ўёъЧЩ
        }

        //КЦ¶ЇїШЦЖЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ёъЧЩДЈКЅЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_MODE
        {
            public uint dwSize;		//Ѕб№№і¤¶И
            public byte byTrackMode;   //ёъЧЩДЈКЅ
            public byte byRuleConfMode;   //№жФтЕдЦГёъЧЩДЈКЅ0-±ѕµШЕдЦГёъЧЩЈ¬1-Ф¶іМЕдЦГёъЧЩ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±ЈБфЈ¬ЦГ0
            [StructLayout(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_MANUAL_CTRL_INFO struManualCtrl;//КЦ¶ЇёъЧЩЅб№№
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_JPEG
        {
            public byte byPicProType;	    /*±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан 1-ЙПґ«*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±ЈБфЧЦЅЪ
            public NET_DVR_JPEGPARA struPicParam; 				/*НјЖ¬№жёсЅб№№*/
        }

        //·ЦОцТЗРРОЄ·ЦОц№жФтЅб№№
        //ѕЇЅд№жФтЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ONE_RULE
        {
            public byte byActive;/* КЗ·сј¤»о№жФт,0-·с, ·З0-КЗ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБфЈ¬ЙиЦГОЄ0ЧЦ¶О
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//№жФтГыіЖ
            public VCA_EVENT_TYPE dwEventType;//РРОЄ·ЦОцКВјюАаРН
            public NET_VCA_EVENT_UNION uEventParam;//РРОЄ·ЦОцКВјюІОКэ
            public NET_VCA_SIZE_FILTER struSizeFilter;//іЯґз№эВЛЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*±ЈБфЈ¬ЙиЦГОЄ0*/
        }

        // ·ЦОцТЗ№жФтЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_RULECFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_ONE_RULE[] struRule; //№жФтКэЧй
        }

        // IVMSРРОЄ·ЦОцЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_BEHAVIORCFG
        {
            public uint dwSize;
            public byte byPicProType;//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;//НјЖ¬№жёсЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_RULECFG[] struRuleCfg;//ГїёцК±јд¶О¶ФУ¦№жФт
        }

        //ЦЗДЬ·ЦОцТЗИЎБчјЖ»®ЧУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_DEVSCHED
        {
            public NET_DVR_SCHEDTIME struTime;//К±јдІОКэ
            public NET_DVR_PU_STREAM_CFG struPUStream;//З°¶ЛИЎБчІОКэ
        }

        //ЦЗДЬ·ЦОцТЗІОКэЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_STREAMCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_DEVSCHED[] struDevSched;//°ґК±јд¶ОЕдЦГЗ°¶ЛИЎБчТФј°№жФтРЕПў
        }

        //ЖБ±ОЗшУт
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION
        {
            public byte byEnable;//КЗ·сј¤»о, 0-·сЈ¬·З0-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЦГ0
            public NET_VCA_POLYGON struPolygon;//ЖБ±О¶а±ЯРО
        }

        //ЖБ±ОЗшУтБґ±нЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION_LIST
        {
            public uint dwSize;//Ѕб№№і¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБфЈ¬ЦГ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MASK_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION[] struMask;//ЖБ±ОЗшУтКэЧй
        }

        //ATMЅшИлЗшУтІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ENTER_REGION
        {
            public uint dwSize;
            public byte byEnable;//КЗ·сј¤»оЈ¬0-·сЈ¬·З0-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_POLYGON struPolygon;//ЅшИлЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //IVMSЖБ±ОЗшУтБґ±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_MASK_REGION_LIST
        {
            public uint dwSize;//Ѕб№№і¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION_LIST[] struList;
        }

        //IVMSµДATMЅшИлЗшУтІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ENTER_REGION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ENTER_REGION[] struEnter;//ЅшИлЗшУт
        }

        // ivms ±ЁѕЇНјЖ¬ЙПґ«Ѕб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ALARM_JPEG
        {
            public byte byPicProType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;
        }

        // IVMS єујмЛчЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_SEARCHCFG
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;// Ф¶іМ»Ш·Е
            public NET_IVMS_ALARM_JPEG struAlarmJpeg;// ±ЁѕЇЙПґ«НјЖ¬ЕдЦГ
            public NET_IVMS_RULECFG struRuleCfg;//IVMS РРОЄ№жФтЕдЦГ
        }

        /************************************end******************************************/
        //NASИПЦ¤ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICATION_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* УГ»§Гы 32*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ГЬВл 16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNT_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;   //БЄєПМеЅб№№ґуРЎ
            [FieldOffsetAttribute(0)]
            public NET_DVR_IDENTIFICATION_PARAM struIdentificationParam;//(SMB/CIFSК±ЙъР§)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAS_MOUNT_PARAM
        {
            public byte byMountType; //0Ў«±ЈБф,1~NFS, 2~ SMB/CIFS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MOUNT_PARAM_UNION uMountParam;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNTMETHOD_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen; //БЄєПМеЅб№№ґуРЎ   
            [FieldOffsetAttribute(0)]
            public NET_DVR_NAS_MOUNT_PARAM struNasMountParam;//NAS№ТФШ·ЅКЅ (byNetDiskTypeОЄNFS(NAS)К±ЙъР§) 
        }

        //НшВзУІЕМЅб№№ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_NET_DISK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            public NET_DVR_IPADDR struNetDiskAddr;//НшВзУІЕМµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDirectory;// PATHNAME_LEN = 128
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБф
        }

        public const int MAX_NET_DISK = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NET_DISKCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NET_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
        }

        //КВјюАаРН
        //ЦчАаРН
        public enum MAIN_EVENT_TYPE
        {
            EVENT_MOT_DET = 0,//ТЖ¶ЇХмІв
            EVENT_ALARM_IN = 1,//±ЁѕЇКдИл
            EVENT_VCA_BEHAVIOR = 2,//РРОЄ·ЦОц
            EVENT_INQUEST = 3,       //ЙуС¶КВјю
            EVENT_VCA_DETECTION = 4, //ЦЗДЬХмІв
            EVENT_STREAM_INFO = 100  //БчIDРЕПў
        }

        public const int INQUEST_START_INFO = 0x1001;      /*С¶ОКїЄКјРЕПў*/
        public const int INQUEST_STOP_INFO = 0x1002;       /*С¶ОКНЈЦ№РЕПў*/
        public const int INQUEST_TAG_INFO = 0x1003;       /*ЦШµг±кјЗРЕПў*/
        public const int INQUEST_SEGMENT_INFO = 0x1004;      /*ЙуС¶Ж¬¶ПЧґМ¬РЕПў*/

        public enum VCA_DETECTION_MINOR_TYPE:uint
        {
            EVENT_VCA_TRAVERSE_PLANE = 1,        //ФЅѕЇХмІв
            EVENT_FIELD_DETECTION,		     //ЗшУтИлЗЦХмІв
            EVENT_AUDIO_INPUT_ALARM,      //ТфЖµКдИлТміЈ
            EVENT_SOUND_INTENSITY_ALARM,   //ЙщЗїН»±дХмІв
            EVENT_FACE_DETECTION,             //ИЛБіХмІв
            EVENT_VIRTUAL_FOCUS_ALARM, /*РйЅ№ХмІв*/
            EVENT_SCENE_CHANGE_ALARM, /*іЎѕ°±дёьХмІв*/
            EVENT_ALL = 0xffffffff				//±нКѕИ«Ії
        }

        //РРОЄ·ЦОцЦчАаРН¶ФУ¦µДґЛАаРНЈ¬ 0xffff±нКѕИ«Ії
        public enum BEHAVIOR_MINOR_TYPE
        {
            EVENT_TRAVERSE_PLANE = 0,// ґ©ФЅѕЇЅдГж,
            EVENT_ENTER_AREA,//Дї±кЅшИлЗшУт,Ц§іЦЗшУт№жФт
            EVENT_EXIT_AREA,//Дї±кАлїЄЗшУт,Ц§іЦЗшУт№жФт
            EVENT_INTRUSION,// ЦЬЅзИлЗЦ,Ц§іЦЗшУт№жФт
            EVENT_LOITER,//ЕЗ»І,Ц§іЦЗшУт№жФт
            EVENT_LEFT_TAKE,//¶Є°ьјс°ь,Ц§іЦЗшУт№жФт
            EVENT_PARKING,//НЈіµ,Ц§іЦЗшУт№жФт
            EVENT_RUN,//±јЕЬ,Ц§іЦЗшУт№жФт
            EVENT_HIGH_DENSITY,//ЗшУтДЪИЛФ±ГЬ¶И,Ц§іЦЗшУт№жФт
            EVENT_STICK_UP,//МщЦЅМх,Ц§іЦЗшУт№жФт
            EVENT_INSTALL_SCANNER,//°ІЧ°¶БїЁЖч,Ц§іЦЗшУт№жФт
            EVENT_OPERATE_OVER_TIME,        // ІЩЧчі¬К±
            EVENT_FACE_DETECT,              // ТміЈИЛБі
            EVENT_LEFT,                     // ОпЖ·ТЕБф
            EVENT_TAKE,                      // ОпЖ·ДГИЎ
            EVENT_LEAVE_POSITION,         //АлёЪКВјю
            EVENT_TRAIL_INFO = 16,            //ОІЛж
            EVENT_FALL_DOWN_INFO = 19,                 //µ№µШ
            EVENT_OBJECT_PASTE = 20,		// ТмОпХіМщЗшУт
            EVENT_FACE_CAPTURE_INFO = 21,                //ХэіЈИЛБі
            EVENT_MULTI_FACES_INFO = 22,                  //¶аХЕИЛБі
            EVENT_AUDIO_ABNORMAL_INFO = 23,             //ЙщЗїН»±д
            EVENT_DETECT = 24     			   //ЦЗДЬХмІв
        }

        // ЦчАаРН100Ј¬¶ФУ¦µДРЎАаРН
        public enum STREAM_INFO_MINOR_TYPE
        {
            EVENT_STREAM_ID = 0,				// БчID
            EVENT_TIMING = 1,					// ¶ЁК±ВјПс
            EVENT_MOTION_DETECT = 2,			// ТЖ¶ЇХмІв
            EVENT_ALARM = 3,					// ±ЁѕЇВјПс
            EVENT_ALARM_OR_MOTION_DETECT = 4,	// ±ЁѕЇ»тТЖ¶ЇХмІв
            EVENT_ALARM_AND_MOTION_DETECT = 5,	// ±ЁѕЇєНТЖ¶ЇХмІв
            EVENT_COMMAND_TRIGGER = 6,			// ГьБоґҐ·ў
            EVENT_MANNUAL = 7,					// КЦ¶ЇВјПс
            EVENT_BACKUP_VOLUME = 8				// ґжµµѕнВјПс
        }

        //°оЕµCVR
        public const int MAX_ID_COUNT = 256;
        public const int MAX_STREAM_ID_COUNT = 1024;
        public const int STREAM_ID_LEN = 32;
        public const int PLAN_ID_LEN = 32;

        // БчРЕПў - 72ЧЦЅЪі¤
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;      //IDКэѕЭ
            public uint dwChannel;                //№ШБЄЙи±ёНЁµАЈ¬µИУЪ0xffffffffК±Ј¬±нКѕІ»№ШБЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                //±ЈБф
            public void init()
            {
                byID = new byte[STREAM_ID_LEN];
                byRes = new byte[32];
            }
        }

        //КВјюЛСЛчМхјю 200-04-07 9000_1.1
        public const int SEARCH_EVENT_INFO_LEN = 300;

        //±ЁѕЇКдИл
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInNo;//±ЁѕЇКдИлєЕЈ¬byAlarmInNo[0]ИфЦГ1Фт±нКѕІйХТУЙ±ЁѕЇКдИл1ґҐ·ўµДКВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byAlarmInNo = new byte[MAX_ALARMIN_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //±ЁѕЇКдИл °ґЦµ±нКѕ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
            public ushort[] wAlarmInNo;//±ЁѕЇКдИлєЕЈ¬byAlarmInNo[0]ИфЦГ1Фт±нКѕІйХТУЙ±ЁѕЇКдИл1ґҐ·ўµДКВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wAlarmInNo = new ushort[128];
                byRes = new byte[44];
            }
        }

        //ТЖ¶ЇХмІв
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotDetChanNo;//ТЖ¶ЇХмІвНЁµАЈ¬byMotDetChanNo[0]ИфЦГ1Фт±нКѕІйХТУЙНЁµА1·ўЙъТЖ¶ЇХмІвґҐ·ўµДКВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byMotDetChanNo = new byte[MAX_CHANNUM_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //ТЖ¶ЇХмІв--°ґЦµ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;//±ЁѕЇКдИлєЕЈ¬byAlarmInNo[0]ИфЦГ1Фт±нКѕІйХТУЙ±ЁѕЇКдИл1ґҐ·ўµДКВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wMotDetChanNo = new ushort[64];
                byRes = new byte[172];
            }
        }

        //РРОЄ·ЦОц
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChanNo;//ґҐ·ўКВјюµДНЁµА
            public byte byRuleID;//№жФтIDЈ¬0xff±нКѕИ«Ії
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф

            public void init()
            {
                byChanNo = new byte[MAX_CHANNUM_V30];
                byRes1 = new byte[235];
            }
        }

        //РРОЄ·ЦОц--°ґЦµ·ЅКЅІйХТ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChanNo;	//ґҐ·ўКВјюµДНЁµА			
            public byte byRuleID;      //РРОЄ·ЦОцАаРНЈ¬№жФт0xff±нКѕИ«ІїЈ¬ґУ0їЄКј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	 /*±ЈБф*/
            public void init()
            {
                wChanNo = new ushort[64];
                byRes = new byte[171];
            }
        }

        //ЙуС¶КВјюЛСЛчМхјю
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_PARAM
		{			
            public byte byRoomIndex;    //ЙуС¶КТ±аєЕ,ґУ1їЄКј
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
            public void init()
            {
                byRes = new byte[299];
            }
		}

        //ЦЗДЬХмІвІйХТМхјю
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYBIT
		{
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;//ґҐ·ўЦЗДЬХмІвµДНЁµАєЕЈ¬°ґКэЧйПВ±к±нКѕЈ¬byChan[0]ИфЦГ1Фт±нКѕІйХТУЙНЁµА1·ўЙъТЖ¶ЇХмІвґҐ·ўµДКВјю 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
            public void init()
            {
                byChan = new byte[256];
                byRes = new byte[44];
            }
		}
		
        //ЦЗДЬХмІвІйХТМхјю Ј¬НЁµАєЕ°ґЦµ±нКѕ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYVALUE
		{
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30-1, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo;// ґҐ·ўНЁµАєЕ,°ґЦµ±нКѕЈ¬0xffffffffОЮР§Ј¬ЗТєуРшКэѕЭТІ±нКѕОЮР§Цµ
            public byte byAll;//0-±нКѕІ»КЗИ«ІїЈ¬1-±нКѕИ«ІїЎЈ
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                dwChanNo = new uint[MAX_CHANNUM_V30 - 1];
                byRes = new byte[47];
            }
		}

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_PARAM
        {
            public NET_DVR_STREAM_INFO struIDInfo; // БчidРЕПўЈ¬72ЧЦЅЪі¤
            public uint dwCmdType;  // НвІїґҐ·ўАаРНЈ¬NVRЅУИлФЖґжґўК№УГ
            public byte byBackupVolumeNum; //ґжµµѕнєЕЈ¬CVRК№УГ
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                struIDInfo.init();
                byRes = new byte[223];
            }
		}

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYBIT struAlarmParam;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYVALUE struAlarmParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYBIT struMotionParam;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYVALUE struMotionParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYBIT struVcaParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYVALUE struVcaParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_INQUEST_PARAM struInquestParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYBIT struVCADetectByBit;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYVALUE struVCADetectByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_STREAMID_PARAM struStreamIDParam;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM
        {
            public ushort wMajorType;//0-ТЖ¶ЇХмІвЈ¬1-±ЁѕЇКдИл, 2-ЦЗДЬКВјю
            public ushort wMinorType;//ЛСЛчґОАаРН- ёщѕЭЦчАаРН±д»ЇЈ¬0xffff±нКѕИ«Ії
            public NET_DVR_TIME struStartTime;//ЛСЛчµДїЄКјК±јдЈ¬НЈЦ№К±јд: Н¬К±ОЄ(0, 0) ±нКѕґУЧоФзµДК±јдїЄКјЈ¬µЅЧоєуЈ¬ЧоЗ°ГжµД4000ёцКВјю
            public NET_DVR_TIME struEndTime;
            public byte byLockType;		// 0xff-И«ІїЈ¬0-ОґЛшЈ¬1-Лш¶Ё
            public byte byValue;			//0-°ґО»±нКѕЈ¬1-°ґЦµ±нКѕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
            public SEARCH_EVENT_UNION uSeniorPara;
        }

        //±ЁѕЇКдИлЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_RET
        {
            public uint dwAlarmInNo;//±ЁѕЇКдИлєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //ТЖ¶ЇХмІвЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_RET
        {
            public uint dwMotDetNo;//ТЖ¶ЇХмІвНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //РРОЄ·ЦОцЅб№ы 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_RET
        {
            public uint dwChanNo;//ґҐ·ўКВјюµДНЁµАєЕ
            public byte byRuleID;//№жФтID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//№жФтГыіЖ
            public NET_VCA_EVENT_UNION uEvent;//РРОЄКВјюІОКэЈ¬wMinorType = VCA_EVENT_TYPEѕц¶ЁКВјюАаРН

            public void init()
            {
                byRes1 = new byte[3];
                byRuleName = new byte[NAME_LEN];
            }
        }

        //ЙуС¶КВјюІйСЇЅб№ы 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_RET
        {
            public byte byRoomIndex;  //ЙуС¶КТ±аєЕ,ґУ1їЄКј
            public byte byDriveIndex; //їМВј»ъ±аєЕ,ґУ1їЄКј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±ЈБф            
            public uint dwSegmentNo;     //±ѕЖ¬¶ПФЪ±ѕґОЙуС¶ЦРµДРтєЕ,ґУ1їЄКј 
            public ushort wSegmetSize;     //±ѕЖ¬¶ПµДґуРЎ, µҐО»M 
            public ushort wSegmentState;   //±ѕЖ¬¶ПЧґМ¬ 0 їМВјХэіЈЈ¬1 їМВјТміЈЈ¬2 І»їМВјЙуС¶
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //±ЈБф

            public void init()
            {
                byRes1 = new byte[6];
                byRes2 = new byte[288];
            }
        }

        //БчidВјПсІйСЇЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_RET
        {
            public uint dwRecordType;	//ВјПсАаРН 0-¶ЁК±ВјПс 1-ТЖ¶ЇХмІв 2-±ЁѕЇВјПс 3-±ЁѕЇ|ТЖ¶ЇХмІв 4-±ЁѕЇ&ТЖ¶ЇХмІв 5-ГьБоґҐ·ў 6-КЦ¶ЇВјПс 7-Хр¶Ї±ЁѕЇ 8-»·ѕіґҐ·ў 9-ЦЗДЬ±ЁѕЇ 10-»Шґ«ВјПс
            public uint dwRecordLength;	//ВјПсґуРЎ
            public byte byLockFlag;    // Лш¶Ё±кЦѕ 0ЈєГ»Лш¶Ё 1ЈєЛш¶Ё
            public byte byDrawFrameType;    // 0Јє·ЗійЦЎВјПс 1ЈєійЦЎВјПс
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName; 	//ОДјюГы
            public uint dwFileIndex;    		// ґжµµѕнЙПµДОДјюЛчТэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes1 = new byte[2];
                byFileName = new byte[NAME_LEN];
                byRes = new byte[256];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_RET
        {
            [FieldOffset(0)]
            public EVENT_ALARM_RET struAlarmRet;
            [FieldOffset(0)]
            public EVENT_MOTION_RET struMotionRet;
            [FieldOffset(0)]
            public EVENT_VCA_RET struVcaRet;
            [FieldOffset(0)]
            public EVENT_INQUEST_RET struInquestRet;
            [FieldOffset(0)]
            public EVENT_STREAMID_RET struStreamIDRet;
            public void init()
            {
                struAlarmRet = new EVENT_ALARM_RET();
                struAlarmRet.init();
                //struMotionRet = new EVENT_MOTION_RET();
                //struMotionRet.init();
            }
        }
        //ІйХТ·µ»ШЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_RET
        {
            public ushort wMajorType;//ЦчАаРНMA
            public ushort wMinorType;//ґОАаРН
            public NET_DVR_TIME struStartTime;//КВјюїЄКјµДК±јд
            public NET_DVR_TIME struEndTime;//КВјюНЈЦ№µДК±јдЈ¬ВціеКВјюК±єНїЄКјК±јдТ»Сщ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public SEARCH_EVENT_RET uSeniorRet;

            public void init()
            {
                byChan = new byte[MAX_CHANNUM_V30];
                byRes = new byte[36];
                uSeniorRet = new SEARCH_EVENT_RET();
                uSeniorRet.init();
            }
        }

        //SDK_V35  2009-10-26

        // ±к¶ЁЕдЦГАаРН
        public enum tagCALIBRATE_TYPE
        {
            PDC_CALIBRATE  = 0x01,  // PDC ±к¶Ё
            BEHAVIOR_OUT_CALIBRATE  = 0x02, //РРОЄКТНвіЎѕ°±к¶Ё  
            BEHAVIOR_IN_CALIBRATE = 0x03,    // РРОЄКТДЪіЎѕ°±к¶Ё 
            ITS_CALBIRETE       = 0x04      //  Ѕ»НЁКВјю±к¶Ё
        }

        public const int MAX_RECT_NUM = 6;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECT_LIST
        {	
            public byte byRectNum;    // ѕШРОїтµДёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±ЈБфЧЦЅЪ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect; // ЧоґуОЄ6ёцRect 
        }

        // PDC ±к¶ЁІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_CALIBRATION
        {
            public NET_DVR_RECT_LIST struRectList;       // ±к¶ЁѕШРОїтБР±н
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±ЈБфЧЦЅЪ 
        }

        // ±к¶ЁПЯµДКфРФАа±рЈ¬УГАґ±нКѕµ±З°±к¶ЁПЯФЪКµјК±нКѕµДКЗёЯ¶ИПЯ»№КЗі¤¶ИПЯЎЈ
        public enum LINE_MODE
        {
            HEIGHT_LINE,        //ёЯ¶ИСщ±ѕПЯ
            LENGTH_LINE        //і¤¶ИСщ±ѕПЯ
        }
        /*ФЪЙиЦГ±к¶ЁРЕПўµДК±єтЈ¬Из№ыПаУ¦О»ЙиЦГБЛК№ДЬЈ¬ІўЙиЦГПа№ШІОКэЈ¬ИфГ»УРЙиЦГК№ДЬЈ¬Фт±к¶ЁєуїЙТФ»сИЎПа№ШµДЙгПс»ъІОКэ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_PARAM
        {
            public byte byEnableHeight;     // КЗ·сК№ДЬЙиЦГЙгПс»ъёЯ¶ИПЯ
            public byte byEnableAngle;      // КЗ·сК№ДЬЙиЦГЙгПс»ъё©СцЅЗ¶И
            public byte byEnableHorizon;    // КЗ·сК№ДЬЙиЦГЙгПс»ъµШЖЅПЯ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±ЈБфЧЦЅЪ 
            public float  fCameraHeight;    // ЙгПс»ъёЯ¶И
            public float  fCameraAngle;     // ЙгПс»ъё©СцЅЗ¶И
            public float  fHorizon;         // іЎѕ°ЦРµДµШЖЅПЯ
        }
        
        /*µ±fValue±нКѕДї±кёЯ¶ИµДК±єтЈ¬struStartPointєНstruEndPoint·Ц±р±нКѕДї±кН·ІїµгєНЅЕІїµгЎЈ
         * µ±fValue±нКѕПЯ¶Оі¤¶ИµДК±єтЈ¬struStartPointєНstruEndPoint·Ц±р±нКѕПЯ¶ОЖрКјµгєНЦХµгЈ¬
         * mode±нКѕµ±З°Сщ±ѕПЯ±нКѕёЯ¶ИПЯ»№КЗі¤¶ИПЯЎЈ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINE_SEGMENT
        {
            public byte byLineMode;     // ІОХХ LINE_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±ЈБфЧЦЅЪ 
            public NET_VCA_POINT   struStartPoint;  
            public NET_VCA_POINT   struEndPoint;
            public float fValue;
        }

        public const int MAX_LINE_SEG_NUM = 8;

        /*±к¶ЁСщ±ѕПЯДїЗ°РиТЄ4-8µчСщ±ѕПЯЈ¬ТФ»сИЎЙгПс»ъПа№ШІОКэ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_OUT_CALIBRATION
        {
            public uint dwLineSegNum;          // Сщ±ѕПЯёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINE_SEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LINE_SEGMENT[]  struLineSegment;    // Сщ±ѕПЯЧоґуёцКэ
            public NET_DVR_CAMERA_PARAM  struCameraParam;    // ЙгПс»ъІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*ёГЅб№№Ме±нКѕIASЦЗДЬїв±к¶ЁСщ±ѕЈ¬ЖдЦР°ьАЁТ»ёцДї±кїтєНТ»Мх¶ФУ¦µДёЯ¶И±к¶ЁПЯЈ»
         * Дї±кїтОЄХѕБўµДИЛМеНвЅУѕШРОїтЈ»ёЯ¶ИПЯСщ±ѕ±кК¶ґУИЛН·¶ҐµгµЅЅЕµгµД±к¶ЁПЯЈ»УГ№йТ»»ЇЧш±к±нКѕЈ»*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_CAL_SAMPLE
        {
            public NET_VCA_RECT struVcaRect;   // Дї±кїт
            public NET_DVR_LINE_SEGMENT struLineSegment;    // ёЯ¶И±к¶ЁПЯ
        }

        public const int MAX_SAMPLE_NUM = 5;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_IN_CALIBRATION 
        {
            public uint dwCalSampleNum;      //  ±к¶ЁСщ±ѕёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SAMPLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IN_CAL_SAMPLE[]  struCalSample; // ±к¶ЁСщ±ѕЧоґуёцКэ
            public NET_DVR_CAMERA_PARAM    struCameraParam;    // ЙгПс»ъІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int CALIB_PT_NUM = 4;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_CALIBRATION
        {
            public uint dwPointNum; //±к¶ЁµгКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CALIB_PT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPoint; //НјПсЧш±к
            public float fWidth;
            public float fHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        // ±ЈБфЧЦЅЪ
        }

        // ±к¶ЁІОКэБЄєПМе
        // єуРшµДПа№Ш±к¶ЁІОКэїЙТФ·ЕФЪёГЅб№№АпГж
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_CALIBRATION_PRARM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //БЄєПМеЅб№№ґуРЎ
            [FieldOffsetAttribute(0)]
            public NET_DVR_PDC_CALIBRATION struPDCCalibration;  //PDC ±к¶ЁІОКэ
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_OUT_CALIBRATION  struBehaviorOutCalibration;  //  РРОЄКТНвіЎѕ°±к¶Ё  ЦчТЄУ¦УГУЪIVSµИ
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_IN_CALIBRATION  struBehaviorInCalibration;     // РРОЄКТДЪіЎѕ°±к¶ЁЈ¬ЦчТЄУ¦УГIASµИ 
            [FieldOffsetAttribute(0)]
            public NET_DVR_ITS_CALIBRATION struITSCalibration;
        }

        // ±к¶ЁЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CALIBRATION_CFG
        {
            public uint dwSize;               //±к¶ЁЅб№№ґуРЎ
            public byte byEnable;           // КЗ·сЖфУГ±к¶Ё
            public byte byCalibrationType;    // ±к¶ЁАаРН ёщѕЭІ»Н¬АаРНФЪБЄєПМеАаСЎФсІ»Н¬µД±к¶Ё ІОїјCALIBRATE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_CALIBRATION_PRARM_UNION uCalibrateParam;  // ±к¶ЁІОКэБЄєПМе
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //БчБїНіјЖ·ЅПтЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ENTER_DIRECTION
        {
            public NET_VCA_POINT struStartPoint; //БчБїНіјЖ·ЅПтЖрКјµг
            public NET_VCA_POINT struEndPoint;    // БчБїНіјЖ·ЅПтЅбКшµг 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG
        {
            public uint dwSize;              //Ѕб№№ґуРЎ
            public byte byEnable;             // КЗ·сј¤»о№жФт;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±ЈБфЧЦЅЪ 
            public NET_VCA_POLYGON  struPolygon;            // ¶а±ЯРО
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // БчБїЅшИл·ЅПт
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG_V41
        {
            public uint dwSize;              //Ѕб№№ґуРЎ
            public byte byEnable;             // КЗ·сј¤»о№жФт;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±ЈБфЧЦЅЪ 
            public NET_VCA_POLYGON struPolygon;            // ¶а±ЯРО
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // БчБїЅшИл·ЅПт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME struAlarmTime;//Іј·АК±јд
            public NET_DVR_TIME_EX struDayStartTime; //°ЧМмїЄКјК±јдЈ¬К±·ЦГлУРР§
            public NET_DVR_TIME_EX struNightStartTime; //Т№НнїЄКјК±јдЈ¬К±·ЦГлУРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // ±ЈБфЧЦЅЪ
        }

        //КФУГ°жРЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIAL_VERSION_CFG
        {
            public uint dwSize;
            public ushort wReserveTime; //КФУГЖЪКЈУаК±јдЈ¬0xffff±нКѕОЮР§Ј¬µҐО»ЈєМм
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYN_CHANNEL_NAME_PARAM
        {
            public uint dwSize;
            public uint dwChannel; //НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RESET_COUNTER_CFG
        {
            public uint dwSize;
            public byte byEnable; //КЗ·сЖфУГЈ¬0-І»ЖфУГЈ¬1-ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TIME_EX[] struTime;//КэѕЭЗеБгК±јдЈ¬К±·ЦГлУРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO  struStreamInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_CFG
        {
            public uint dwSize;
            public byte byVCAEnable;     //КЗ·сїЄЖфЦЗДЬ
            public byte byVCAType;       //ЦЗДЬДЬБ¦АаРНЈ¬VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA; //ВлБчЦРКЗ·сґшЦЗДЬРЕПў
            public byte byMode;			//ДЈКЅЈ¬ATM ДЬБ¦К±ІОХХVCA_CHAN_MODE_TYPE ,TFS ДЬБ¦К±ІОХХ TFS_CHAN_MODE_TYPEЈ¬РРОЄ·ЦОцНкХы°жК±ІОХХBEHAVIOR_SCENE_MODE_TYPE
            public byte byControlType;   //їШЦЖАаРНЈ¬°ґО»±нКѕЈ¬0-·сЈ¬1-КЗ
	                        //byControlType &1 КЗ·сЖфУГЧҐЕД№¦ДЬ
                            //byControlType &2 КЗ·сЖфУГБЄ¶ЇЗ°¶ЛЙи±ё
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 		//±ЈБфЈ¬ЙиЦГОЄ0
        }

        /*ЙиЦГИЛБчБїНіјЖІОКэ  ёґУГРРОЄДЪІї№ШјьЧЦІОКэ
         * HUMAN_GENERATE_RATE
         * Дї±кЙъіЙЛЩ¶ИІОКэЈ¬їШЦЖPDCївЙъіЙДї±кµДЛЩ¶ИЎЈЛЩ¶ИФЅїмЈ¬Дї±кФЅИЭТЧЙъіЙЎЈ
         * µ±КдИлКУЖµ№вХХМхјюЅПІоЈ¬¶Ф±И¶ИЅПµНК±Ј¬»тХЯЙиЦГµД№жФтЗшУтЅПРЎК±Ј¬У¦јУїмДї±кЙъіЙЛЩ¶ИЈ¬ ±ЬГвДї±кµДВ©јмЈ»
         * µ±КдИлКУЖµЦР¶Ф±И¶ИЅПёЯК±Ј¬»тХЯ№жФтЗшУтЅПґуК±Ј¬У¦ёГЅµµНДї±кЙъіЙЛЩ¶ИЈ¬ТФјхЙЩОујмЎЈ
         * Дї±кЙъіЙЛЩ¶ИІОКэ№ІУР5ј¶Ј¬1ј¶ЛЩ¶ИЧоВэЈ¬5ј¶ЧоїмЈ¬Д¬ИПІОКэОЄ3ЎЈ
         *
         * DETECT_SENSITIVE
         * Дї±кјмІвБйГф¶ИїШЦЖІОКэЈ¬їШЦЖPDCївЦРТ»ёцѕШРОЗшУт±»јмІвОЄДї±кµДБйГф¶ИЎЈ
         * БйГф¶ИФЅёЯЈ¬ѕШРОЗшУтФЅИЭТЧ±»јмІвОЄДї±кЈ¬БйГф¶ИФЅµНФтФЅДСјмІвОЄДї±кЎЈ
         * µ±КдИлКУЖµ№вХХМхјюЅПІоЈ¬¶Ф±И¶ИЅПµНК±Ј¬У¦МбёЯјмІвБйГф¶ИЈ¬ ±ЬГвДї±кµДВ©јмЈ»
         * µ±КдИлКУЖµЦР¶Ф±И¶ИЅПёЯК±Ј¬У¦ёГЅµµНјмІвБйГф¶ИЈ¬ТФјхЙЩОујмЎЈ
         * ¶ФУ¦ІОКэ№ІУР5ј¶Ј¬ј¶±р1БйГф¶ИЧоµНЈ¬5ј¶ЧоёЯЈ¬Д¬ИПј¶±рОЄ3ЎЈ
         * 
         * TRAJECTORY_LEN
         * №мјЈЙъіЙі¤¶ИїШЦЖІОКэЈ¬±нКѕЙъіЙ№мјЈК±ТЄЗуДї±кµДЧоґуО»ТЖПсЛШЎЈ
         * ¶ФУ¦ІОКэ№ІУР5ј¶Ј¬ј¶±р1Ј¬ЙъіЙі¤¶ИЧоі¤Ј¬№мјЈЙъіЙЧоВэЈ¬5ј¶ЙъіЙі¤¶ИЧо¶МЈ¬№мјЈЙъіЙЧоїмЈ¬Д¬ИПј¶±рОЄ3ЎЈ
         * 
         * TRAJECT_CNT_LEN
         * №мјЈјЖКэі¤¶ИїШЦЖІОКэЈ¬±нКѕ№мјЈјЖКэК±ТЄЗуДї±кµДЧоґуО»ТЖПсЛШЎЈ
         * ¶ФУ¦ІОКэ№ІУР5ј¶Ј¬ј¶±р1Ј¬јЖКэТЄЗуі¤¶ИЧоі¤Ј¬№мјЈјЖКэЧоВэЈ¬5ј¶јЖКэТЄЗуі¤¶ИЧо¶МЈ¬№мјЈјЖКэЧоїмЈ¬Д¬ИПј¶±рОЄ3ЎЈ
         * 
         * PREPROCESS
         * НјПсФ¤ґ¦АнїШЦЖІОКэЈ¬0 - І»ґ¦АнЈ»1 - ґ¦АнЎЈД¬ИПОЄ0Ј»
         * 
         * CAMERA_ANGLE
         * ЙгПс»ъЅЗ¶ИКдИлІОКэЈ¬ 0 - ЗгР±Ј» 1 - ґ№Ц±ЎЈД¬ИПОЄ0Ј»
         */

        public enum PDC_PARAM_KEY
        {
            HUMAN_GENERATE_RATE = 50,  // Дї±кЙъіЙЛЩ¶И ґУ50їЄКј
            DETECT_SENSITIVE    = 51,  // јмІвБйГф¶И
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_INFO
        {
            public uint dwTargetID;                 // Дї±кid 
            public NET_VCA_RECT struTargetRect;    // Дї±кїт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_IN_FRAME
        {
            public byte byTargetNum;                   //Дї±кёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] yRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PDC_TARGET_INFO[]  struTargetInfo;   //Дї±кРЕПўКэЧй
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  // ±ЈБфЧЦЅЪ
        }

        //µҐЦЎНіјЖЅб№ыК±К№УГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATFRAME
        {
            public uint dwRelativeTime;     // Па¶ФК±±к
            public uint dwAbsTime;          // ѕш¶ФК±±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATTIME
        {
            public NET_DVR_TIME tmStart; // НіјЖЖрКјК±јд 
            public NET_DVR_TIME tmEnd;  //  НіјЖЅбКшК±јд 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ALRAM_INFO
        {
            public uint dwSize;           // PDCИЛБчБї±ЁѕЇЙПґ«Ѕб№№МеґуРЎ
            public byte byMode;            // 0 µҐЦЎНіјЖЅб№ы 1ЧоРЎК±јд¶ОНіјЖЅб№ы  
            public byte byChannel;           // ±ЁѕЇЙПґ«НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;         // ±ЈБфЧЦЅЪ   
            public NET_VCA_DEV_INFO  	 struDevInfo;		        //З°¶ЛЙи±ёРЕПў
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uStatModeParam
            {
                [FieldOffsetAttribute(0)]
                //µҐЦЎНіјЖЅб№ыК±К№УГ
                public UNION_STATFRAME struStatFrame;

                [FieldOffsetAttribute(0)]
                public UNION_STATTIME struStatTime;
            }
            public uint dwLeaveNum;        // АлїЄИЛКэ
            public uint dwEnterNum;        // ЅшИлИЛКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±ЈБфЧЦЅЪ
        }

        //ИЛБчБїРЕПўІйСЇ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_QUERY
        {
            public NET_DVR_TIME tmStart;
            public NET_DVR_TIME tmEnd;
            public uint dwLeaveNum;
            public uint dwEnterNum; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_POSITION
        {
            // КЗ·сЖфУГіЎѕ°Ј¬ФЪЙиЦГіЎѕ°РРОЄ№жФтµДК±єтёГЧЦ¶ООЮР§Ј¬ФЪЙиЦГЗт»ъ±ѕµШЕдЦГіЎѕ°О»ЦГРЕПўК±ЧчОЄК№ДЬО»
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPtzPositionName; //іЎѕ°О»ЦГГыіЖ
            public NET_DVR_PTZPOS struPtzPos; //ptz Чш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG
        {
            public uint dwSize;             // Ѕб№№ґуРЎ 
            public NET_DVR_PTZ_POSITION    struPtzPosition;    // іЎѕ°О»ЦГРЕПў
            public NET_VCA_RULECFG         struVcaRuleCfg;     //РРОЄ№жФтЕдЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±ЈБфЧЦЅЪ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG_V41
        {
            public uint dwSize;             // Ѕб№№ґуРЎ 
            public NET_DVR_PTZ_POSITION  struPtzPosition;    // іЎѕ°О»ЦГРЕПў
            public NET_VCA_RULECFG_V41   struVcaRuleCfg;     //РРОЄ№жФтЕдЦГ
            public byte byTrackEnable; //КЗ·сЖфУГёъЧЩ
            public byte byRes1;
            public ushort wTrackDuration; //ёъЧЩіЦРшК±јдЈ¬µҐО»s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIMIT_ANGLE
        {
            public byte byEnable;	// КЗ·сЖфУГіЎѕ°ПЮО»№¦ДЬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_PTZPOS  struUp;     // ЙППЮО»
            public NET_DVR_PTZPOS  struDown;   // ПВПЮО»
            public NET_DVR_PTZPOS  struLeft;   // ЧуПЮО»
            public NET_DVR_PTZPOS  struRight;  // УТПЮО»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_INDEX
        {
            public byte byIndex;    // іЎѕ°ЛчТэ
            public byte byRes1;
            public ushort wDwell;	// НЈБфК±јд 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   // ±ЈБфЧЦЅЪ
        }

        public const int MAX_POSITION_NUM = 10;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_TRACK_CFG
        {
            public uint dwSize;
            public byte byNum; // іЎѕ°ёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_POSITION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_POSITION_INDEX[]   struPositionIndex;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //СІєЅВ·ѕ¶іЎѕ°РЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_SCENE_INFO
        {
            public ushort wDwell;         // НЈБфК±јд 30-300
            public byte byPositionID;   // іЎѕ°єЕ1-10Ј¬Д¬ИП0±нКѕёГСІєЅµгІ»МнјУіЎѕ°
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //іЎѕ°СІєЅёъЧЩЕдЦГРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_TRACKCFG
        {
            public uint dwSize;  // Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PATROL_SCENE_INFO[] struPatrolSceneInfo;    // СІєЅВ·ѕ¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                              // ±ЈБфЧЦЅЪ
        }

        //Зт»ъ±ѕµШ№жФтІЛµҐЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_PARAMCFG
        {
            public uint dwSize;             // Ѕб№№ґуРЎ
            public ushort wAlarmDelayTime;    // ±ЁѕЇСУК±К±јдЈ¬ДїЗ°Зт»ъЦ»Ц§іЦИ«ѕЦИлЗЦ ·¶О§1-120Гл
            public ushort wTrackHoldTime;     // ±ЁѕЇёъЧЩіЦРшК±јд  ·¶О§0-300Гл
            public byte byTrackMode;        //  ІОХХ IPDOME_TRACK_MODE
            public byte byPreDirection;	// ёъЧЩ·ЅПтФ¤ЕР 0-І»ЖфУГ 1-ЖфУГ
            public byte byTrackSmooth;	    // ёъЧЩБ¬Рш  0-І»ЖфУГ 1-ЖфУГ
            public byte byZoomAdjust;	// ±¶ВКПµКэµчХы ІОјыПВ±н
            public byte byMaxTrackZoom;	//ЧоґуёъЧЩ±¶ВКПµКэ,0-±нКѕД¬ИП±¶ВКПµКэ,µИј¶6-±к¶ЁЦµ*1.0(Д¬ИП),1-5ОЄЛхРЎ±к¶ЁЦµЈ¬ЦµФЅРЎЈ¬ЛхРЎµД±ИАэФЅґу,7-15ОЄ·ЕґуЈ¬ЦµФЅґуЈ¬·ЕґуµД±ИАэФЅґу
            public byte byStopTrackWhenFindFace;  //ИЛБіјмІвµЅєуКЗ·сНЈЦ№ёъЧЩ 0-·с 1-КЗ
            public byte byStopTrackThreshold;   //ёъЧЩЦХЦ№ЖА·ЦгРЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //  ±ЈБфЧЦЅЪ                
        }

        //Зт»ъ»ъРѕІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOME_MOVEMENT_PARAM
        {
            public ushort wMaxZoom;   // Зт»ъЧоґу±¶ВКПµКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±ЈБфЧЦЅЪ
        }

        /********************************ЦЗДЬЅ»НЁКВјю begin****************************************/
        public const int MAX_REGION_NUM	= 8;  // ЗшУтБР±нЧоґуКэДї
        public const int MAX_TPS_RULE = 8;   // ЧоґуІОКэ№жФтКэДї
        public const int MAX_AID_RULE = 8;   // ЧоґуКВјю№жФтКэДї
        public const int MAX_LANE_NUM = 8;   // ЧоґуіµµАКэДї

        //Ѕ»НЁКВјюАаРН
        public enum TRAFFIC_AID_TYPE
        {
            CONGESTION            = 0x01,    //Уµ¶В
            PARKING               = 0x02,    //НЈіµ  
            INVERSE               = 0x04,    //ДжРР
            PEDESTRIAN            = 0x08,    //РРИЛ                      
            DEBRIS                = 0x10,    //ТЕБфОп ЕЧИчОпЛйЖ¬ 
            SMOKE                 = 0x20,    //СМОн  
	        OVERLINE              = 0x40,     //С№ПЯ
	        VEHICLE_CONTROL_LIST  = 0x80,  //єЪГыµҐКэѕЭ
	        SPEED                 = 0x100  //і¬ЛЩ
        }
        
        public enum TRAFFIC_SCENE_MODE
        {
	        FREEWAY = 0,	//  ёЯЛЩ»§НвіЎѕ°
	        TUNNEL,         //  ёЯЛЩЛнµАіЎѕ°
	        BRIDGE          //  ёЯЛЩЗЕБєіЎѕ°
        }
        
        public enum ITS_ABILITY_TYPE
        {
            ITS_CONGESTION_ABILITY             = 0x01,      //Уµ¶В
            ITS_PARKING_ABILITY                = 0x02,      //НЈіµ  
            ITS_INVERSE_ABILITY                = 0x04,      //ДжРР
            ITS_PEDESTRIAN_ABILITY             = 0x08,      //РРИЛ                      
            ITS_DEBRIS_ABILITY                 = 0x10,      //ТЕБфОп ЕЧИчОпЛйЖ¬
            ITS_SMOKE_ABILITY                  = 0x20,      //СМОн-ЛнµА
            ITS_OVERLINE_ABILITY               = 0x40,      //С№ПЯ
	        ITS_VEHICLE_CONTROL_LIST_ABILITY   = 0x80,		//єЪГыµҐКэѕЭ
	        ITS_SPEED_ABILITY				   = 0x100,	    //і¬ЛЩ	
            ITS_LANE_VOLUME_ABILITY            = 0x010000,  //іµµАБчБї
            ITS_LANE_VELOCITY_ABILITY          = 0x020000,  //іµµАЖЅѕщЛЩ¶И
            ITS_TIME_HEADWAY_ABILITY           = 0x040000,  //іµН·К±ѕа
            ITS_SPACE_HEADWAY_ABILITY          = 0x080000,  //іµН·јдѕа
            ITS_TIME_OCCUPANCY_RATIO_ABILITY   = 0x100000,  //іµµАХјУРВКЈ¬ЈЁК±јдЙП)
            ITS_SPACE_OCCUPANCY_RATIO_ABILITY  = 0x200000,  //іµµАХјУРВКЈ¬°Щ·Ц±ИјЖЛгЈЁїХјдЙП)
            ITS_LANE_QUEUE_ABILITY             = 0x400000,  //ЕЕ¶Уі¤¶И
	        ITS_VEHICLE_TYPE_ABILITY           = 0x800000,  //іµБѕАаРН
	        ITS_TRAFFIC_STATE_ABILITY          = 0x1000000  //Ѕ»НЁЧґМ¬
        }
        
        // Ѕ»НЁНіјЖІОКэ
        public enum ITS_TPS_TYPE
        {
            LANE_VOLUME           = 0x01,    //іµµАБчБї
            LANE_VELOCITY         = 0x02,    //іµµАЛЩ¶И
            TIME_HEADWAY          = 0x04,    //іµН·К±ѕа
            SPACE_HEADWAY         = 0x08,    //іµН·јдѕа
            TIME_OCCUPANCY_RATIO  = 0x10,    //іµµАХјУРВК (К±јдЙП)
            SPACE_OCCUPANCY_RATIO = 0x20,    //іµµАХјУРВКЈ¬°Щ·Ц±ИјЖЛг(їХјдЙП)
            QUEUE                 = 0x40,    //ЕЕ¶Уі¤¶И
	        VEHICLE_TYPE          = 0x80,    //іµБѕАаРН
	        TRAFFIC_STATE         = 0x100    //Ѕ»НЁЧґМ¬
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REGION_LIST
        {
            public uint dwSize;	// Ѕб№№МеґуРЎ
            public byte byNum;      // ЗшУтёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POLYGON[] struPolygon; // ЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ±ЈБфЧЦЅЪ
        }

        //·ЅПтЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIRECTION
        {
            public NET_VCA_POINT struStartPoint;   // ·ЅПтЖрКјµг
            public NET_VCA_POINT struEndPoint;     // ·ЅПтЅбКшµг 
        }

        //µҐёціµµА
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LANE
        {
            public byte byEnable;  //іµµАКЗ·сЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	   // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneName;       // іµµА№жФтГыіЖ
            public NET_DVR_DIRECTION struFlowDirection;// іµµАДЪіµБч·ЅПт
            public NET_VCA_POLYGON struPolygon;		// іµµАЗшУт
        }

        //іµµАЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_CFG
        {
            public uint dwSize;	// Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LANE[] struLane;	// іµµАІОКэ КэЧйПВ±кЧчОЄіµµАID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	 // ±ЈБфЧЦЅЪ
        }

        //Ѕ»НЁКВјюІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_PARAM
        {
            public ushort wParkingDuration;       // ОҐНЈјмІвБйГф¶И  10-120s
            public ushort wPedestrianDuration;    // РРИЛіЦРшК±јд    1-120s
            public ushort wDebrisDuration;        // ЕЧИчОпіЦРшК±јд  10-120s
            public ushort wCongestionLength;      // Уµ¶Ві¤¶ИгРЦµ    5-200ЈЁГЧЈ©
            public ushort wCongestionDuration;    // Уµ¶ВіЦРшІОКэ    10-120s
            public ushort wInverseDuration;       // ДжРРіЦРшК±јд    1-10s
            public ushort wInverseDistance;       // ДжРРѕаАлгРЦµ µҐО»m ·¶О§[2-100] Д¬ИП 10ГЧ
            public ushort wInverseAngleTolerance; // ФКРнЅЗ¶ИЖ«Іо 90-180¶И,іµБчУлДжРРФКРнµДјРЅЗ
            public ushort wIllegalParkingTime;    // ОҐНЈК±јд[4,60]Ј¬µҐО»Јє·ЦЦУ ,TFS(Ѕ»НЁОҐХВИЎЦ¤) іЗКРДЈКЅПВ
            public ushort wIllegalParkingPicNum;  // ОҐНЈНјЖ¬КэБї[1,6], TFS(Ѕ»НЁОҐХВИЎЦ¤) іЗКРДЈКЅПВ
            public byte byMergePic;             // НјЖ¬ЖґЅУ,TFS іЗКРДЈКЅПВ 0- І»ЖґЅУ 1- ЖґЅУ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;             // ±ЈБфЧЦЅЪ
        }

        //µҐМхЅ»НЁКВјю№жФтЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE
        {   
            public byte byEnable;                   // КЗ·сЖфУГКВјю№жФт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;       // №жФтГыіЖ 
            public uint dwEventType;                // Ѕ»НЁКВјюјмІвАаРН TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; // іЯґз№эВЛЖч
            public NET_VCA_POLYGON     struPolygon;    // №жФтЗшУт
            public NET_DVR_AID_PARAM   struAIDParam;   //  КВјюІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //ґ¦Ан·ЅКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ѕ»НЁКВјю№жФт
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG
        {
            public uint dwSize;                    // Ѕб№№МеґуРЎ 
            public byte byPicProType;              //±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                 // ±ЈБфЧЦЅЪ
            public NET_DVR_JPEGPARA struPictureParam; //НјЖ¬№жёсЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE[]  struOneAIDRule;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //µҐМхЅ»НЁКВјю№жФтЅб№№Ме(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE_V41
        {   
            public byte byEnable;                 // КЗ·сЖфУГКВјю№жФт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;     // №жФтГыіЖ 
            public uint dwEventType;              // Ѕ»НЁКВјюјмІвАаРН TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;           // іЯґз№эВЛЖч
            public NET_VCA_POLYGON struPolygon;              // №жФтЗшУт
            public NET_DVR_AID_PARAM struAIDParam;             // КВјюІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;// Іј·АК±јд¶О
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	          //ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //±ЁѕЇґҐ·ўµДВјПуНЁµАЈє1±нКѕґҐ·ўёГНЁµАЈ»0±нКѕІ»ґҐ·ў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±ЈБф
        }

        //Ѕ»НЁКВјю№жФт(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG_V41
        {
            public uint dwSize;                     // Ѕб№№МеґуРЎ 
            public byte byPicProType;               // ±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // ±ЈБфЧЦЅЪ
            public NET_DVR_JPEGPARA struPictureParam; 	// НјЖ¬№жёсЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE_V41[]  struAIDRule;  //№жФтКэЧй
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //±ЈБф
        }

        //Ѕ»НЁНіјЖІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE
        {
            public byte byEnable;                   //КЗ·сК№ДЬіµµАЅ»НЁ№жФтІОКэ
            public byte byLaneID;		            //іµµАID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwCalcType;                 //НіјЖІОКэАаРНITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; //іЯґз№эВЛЖч 
            public NET_VCA_POLYGON struVitrualLoop;    //РйДвПЯИ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//ґ¦Ан·ЅКЅ,Т»°гОЄґ¦АнКЗ·сЙПґ«ЦРРДЈ¬ЖдЛы№¦ДЬІ»РиТЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                         //±ЈБфЧЦЅЪ
        }

        //Ѕ»НЁІОКэНіјЖ№жФтЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG
        {
            public uint dwSize;              // Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE[] struOneTpsRule; // ПВ±к¶ФУ¦Ѕ»НЁІОКэID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // ±ЈБфЧЦЅЪ
        }

        //Ѕ»НЁНіјЖІОКэЅб№№Ме(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE_V41
        {
            public byte byEnable;                     //КЗ·сК№ДЬіµµАЅ»НЁ№жФтІОКэ
            public byte byLaneID;		              //іµµАID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±ЈБф
            public uint dwCalcType;                   // НіјЖІОКэАаРНITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER  struSizeFilter;  //іЯґз№эВЛЖч 
            public NET_VCA_POLYGON  struVitrualLoop; //РйДвПЯИ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	   //ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   // ±ЈБфЧЦЅЪ
        }

        //Ѕ»НЁІОКэНіјЖ№жФтЕдЦГЅб№№Ме(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG_V41
        {
            public uint dwSize;         // Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE_V41[] struOneTpsRule; // ПВ±к¶ФУ¦Ѕ»НЁІОКэID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±ЈБф
        }

        //Ѕ»НЁКВјюРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_INFO
        {
            public byte byRuleID;   // №жФтРтєЕЈ¬ОЄ№жФтЕдЦГЅб№№ПВ±кЈ¬0-16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //  №жФтГыіЖ
            public uint dwAIDType;  // ±ЁѕЇКВјюАаРН
            public NET_DVR_DIRECTION   struDirect; // ±ЁѕЇЦёПтЗшУт  
            public byte bySpeedLimit; //ПЮЛЩЦµЈ¬µҐО»km/h[0,255]
            public byte byCurrentSpeed; //µ±З°ЛЩ¶ИЦµЈ¬µҐО»km/h[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  // ±ЈБфЧЦЅЪ 
        }

        //Ѕ»НЁКВјю±ЁѕЇ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM
        {
            public uint dwSize;         // Ѕб№№і¤¶И
            public uint dwRelativeTime;	// Па¶ФК±±к
            public uint dwAbsTime;		// ѕш¶ФК±±к
            public NET_VCA_DEV_INFO struDevInfo;	// З°¶ЛЙи±ёРЕПў
            public NET_DVR_AID_INFO struAIDInfo;    // Ѕ»НЁКВјюРЕПў
            public uint dwPicDataLen;   // ·µ»ШНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ
            public IntPtr pImage;        // ЦёПтНјЖ¬µДЦёХл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±ЈБфЧЦЅЪ  
        }

        //іµµА¶УБРЅб№№Ме 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_QUEUE
        {
            public NET_VCA_POINT struHead;       //¶УБРН·
            public NET_VCA_POINT struTail;       //¶УБРОІ
            public uint dwLength;      //КµјК¶УБРі¤¶И µҐО»ОЄГЧ [0-500]
        }

        public enum TRAFFIC_DATA_VARY_TYPE
        {
            NO_VARY,         //ОЮ±д»Ї 
            VEHICLE_ENTER,   //іµБѕЅшИлРйДвПЯИ¦
            VEHICLE_LEAVE,   //іµБѕАлїЄРйДвПЯИ¦ 
            UEUE_VARY        //¶УБР±д»Ї             
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;  //іµµА№жФтГыіЖ 
            public byte byRuleID;              //№жФтРтєЕЈ¬ОЄ№жФтЕдЦГЅб№№ПВ±кЈ¬0-7 
            public byte byVaryType;            //іµµАЅ»НЁІОКэ±д»ЇАаРН ІОХХ TRAFFIC_DATA_VARY_TYPE
            public byte byLaneType;			   //іµµАЙПРР»тПВРР
            public byte byRes1;
            public uint dwLaneVolume;         //іµµАБчБї Ј¬НіјЖУР¶аЙЩіµЧУНЁ№э
            public uint dwLaneVelocity;        //іµµАЛЩ¶ИЈ¬№«АпјЖЛг
            public uint dwTimeHeadway;         //іµН·К±ѕаЈ¬ТФГлјЖЛг
            public uint dwSpaceHeadway;        //іµН·јдѕаЈ¬ТФГЧАґјЖЛг
            public float fSpaceOccupyRation;    //іµµАХјУРВКЈ¬°Щ·Ц±ИјЖЛгЈЁїХјдЙП)
            public NET_DVR_LANE_QUEUE struLaneQueue;    //іµµА¶УБРі¤¶И
            public NET_VCA_POINT struRuleLocation; //ПЯИ¦№жФтµДЦРРДµгО»ЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO
        {
            public uint dwLanNum;   // Ѕ»НЁІОКэµДіµµАКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM[]  struLaneParam;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM
        {
            public uint dwSize;          //Ѕб№№МеґуРЎ
            public uint dwRelativeTime;  //Па¶ФК±±к
            public uint dwAbsTime;       //ѕш¶ФК±±к
            public NET_VCA_DEV_INFO  struDevInfo;     //З°¶ЛЙи±ёРЕПў
            public NET_DVR_TPS_INFO  struTPSInfo;     //Ѕ»НЁКВјюРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      //±ЈБфЧЦЅЪ
        }
        
        public enum TRAFFIC_DATA_VARY_TYPE_EX_ENUM
        {    
	        ENUM_TRAFFIC_VARY_NO             = 0x00,   //ОЮ±д»Ї
	        ENUM_TRAFFIC_VARY_VEHICLE_ENTER  = 0x01,   //іµБѕЅшИлРйДвПЯИ¦
	        ENUM_TRAFFIC_VARY_VEHICLE_LEAVE  = 0x02,   //іµБѕАлїЄРйДвПЯИ¦
	        ENUM_TRAFFIC_VARY_QUEUE          = 0x04,   //¶УБР±д»Ї
	        ENUM_TRAFFIC_VARY_STATISTIC      = 0x08,   //НіјЖКэѕЭ±д»ЇЈЁГї·ЦЦУ±д»ЇТ»ґО°ьАЁЖЅѕщЛЩ¶ИЈ¬іµµАїХјд/К±јдХјУРВКЈ¬Ѕ»НЁЧґМ¬Ј©        
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM_V41
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; // іµµА№жФтГыіЖ
            public byte byRuleID;             // №жФтРтєЕЈ¬ОЄ№жФтЕдЦГЅб№№ПВ±кЈ¬0-7 
            public byte byLaneType;		     // іµµАЙПРР»тПВРР
            public byte byTrafficState;       // іµµАµДЅ»НЁЧґМ¬Ј¬0-ОЮР§Ј¬1-і©НЁЈ¬2-Уµј·Ј¬3-¶ВИы
            public byte byRes1;               // ±ЈБф
            public uint dwVaryType;           // іµµАЅ»НЁІОКэ±д»ЇАаРНІОХХ  TRAFFIC_DATA_VARY_TYPE_EX_ENUMЈ¬°ґО»Зш·Ц
            public uint dwTpsType;            // КэѕЭ±д»ЇАаРН±кЦѕЈ¬±нКѕµ±З°ЙПґ«µДНіјЖІОКэЦРЈ¬ДДР©КэѕЭУРР§Ј¬ІОХХITS_TPS_TYPE,°ґО»Зш·Ц
            public uint dwLaneVolume;	     // іµµАБчБїЈ¬НіјЖУР¶аЙЩіµЧУНЁ№э
            public uint dwLaneVelocity;       // іµµАЛЩ¶ИЈ¬№«АпјЖЛг
            public uint dwTimeHeadway ;       // іµН·К±ѕаЈ¬ТФГлјЖЛг
            public uint dwSpaceHeadway;       // іµН·јдѕаЈ¬ТФГЧАґјЖЛг
            public float fSpaceOccupyRation;   // іµµАХјУРВКЈ¬°Щ·Ц±ИјЖЛгЈЁїХјдЙП)
            public float fTimeOccupyRation;    // К±јдХјУРВКЈ¬°Щ·Ц±ИјЖЛг
            public uint dwLightVehicle;       // РЎРНіµКэБї
            public uint dwMidVehicle;         // ЦРРНіµКэБї
            public uint dwHeavyVehicle;       // ЦШРНіµКэБї
            public NET_DVR_LANE_QUEUE struLaneQueue;        // іµµА¶УБРі¤¶И
            public NET_VCA_POINT struRuleLocation;     // №жФтО»ЦГРйДвПЯИ¦µДЦРРД
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ±ЈБф
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO_V41
        {
            public uint dwLanNum;          // Ѕ»НЁІОКэµДіµµАКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM_V41[]  struLaneParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±ЈБф
        }

        //ИЛБі№жФтЕдЦГ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG
        {
            public uint dwSize;              // Ѕб№№МеґуРЎ
            public byte byEnable;            // КЗ·сЖфУГ
            public byte byEventType;			//ѕЇЅдКВјюАаРНЈ¬ 0-ТміЈИЛБі; 1-ХэіЈИЛБі;2-ТміЈИЛБі&ХэіЈИЛБі;
            public byte byUpLastAlarm;       //2011-04-06 КЗ·сПИЙПґ«ЧоЅьТ»ґОµД±ЁѕЇ
            public byte byUpFacePic; //КЗ·сЙПґ«ИЛБіЧУНјЈ¬0-·сЈ¬1-КЗ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON     struVcaPolygon;    // ИЛБіјмІв№жФтЗшУт
            public byte byPicProType;	//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            public byte bySensitivity;   // №жФтБйГф¶И
            public ushort wDuration;      // ґҐ·ўИЛБі±ЁѕЇК±јдгРЦµ
            public NET_DVR_JPEGPARA    struPictureParam; 		//НјЖ¬№жёсЅб№№
            public NET_VCA_SIZE_FILTER struSizeFilter;         //іЯґз№эВЛЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            public byte byPicRecordEnable;  /*2012-3-1КЗ·сЖфУГНјЖ¬ґжґў, 0-І»ЖфУГ, 1-ЖфУГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         //±ЈБфЧЦЅЪ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PIPCFG
        {	
            public byte byEnable; //КЗ·сїЄЖф»­ЦР»­
            public byte byBackChannel; //±іѕ°НЁµАєЕЈЁГж°еНЁµАЈ©
            public byte byPosition; //µюјУО»ЦГЈ¬0-ЧуЙП,1-ЧуПВ,2-УТЙП,3-УТПВ
            public byte byPIPDiv; //·ЦЖБПµКэ(ИЛБі»­Гж:Гж°е»­Гж)Ј¬0-1:4,1-1:9,2-1:16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG_V41
        {
            public uint dwSize;              // Ѕб№№МеґуРЎ
            public byte byEnable;            // КЗ·сЖфУГ
            public byte byEventType;			//ѕЇЅдКВјюАаРНЈ¬ 0-ТміЈИЛБі; 1-ХэіЈИЛБі;2-ТміЈИЛБі&ХэіЈИЛБі;
            public byte byUpLastAlarm;       //2011-04-06 КЗ·сПИЙПґ«ЧоЅьТ»ґОµД±ЁѕЇ
            public byte byUpFacePic; //КЗ·сЙПґ«ИЛБіЧУНјЈ¬0-·сЈ¬1-КЗ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // ИЛБіјмІв№жФтЗшУт
            public byte byPicProType;	//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            public byte bySensitivity;   // №жФтБйГф¶И
            public ushort wDuration;      // ґҐ·ўИЛБі±ЁѕЇК±јдгРЦµ
            public NET_DVR_JPEGPARA    struPictureParam; 		//НјЖ¬№жёсЅб№№
            public NET_VCA_SIZE_FILTER struSizeFilter;         //іЯґз№эВЛЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //ґ¦Ан·ЅКЅ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            public byte byPicRecordEnable;  /*2012-10-22КЗ·сЖфУГНјЖ¬ґжґў, 0-І»ЖфУГ, 1-ЖфУГ*/
            public byte byRes1;
            public ushort wAlarmDelay; //2012-10-22ЦЗДЬ±ЁѕЇСУК±Ј¬0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            public NET_DVR_FACE_PIPCFG struFacePIP; //2012-11-7»­ЦР»­ІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±ЈБфЧЦЅЪ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_ALARM
        {
            public uint dwSize;     		// Ѕб№№ґуРЎ
            public uint dwRelativeTime; // Па¶ФК±±к
            public uint dwAbsTime;			// ѕш¶ФК±±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;   // №жФтГыіЖ
            public NET_VCA_TARGET_INFO  struTargetInfo;	//±ЁѕЇДї±кРЕПў
            public NET_VCA_DEV_INFO  	 struDevInfo;		//З°¶ЛЙи±ёРЕПў
            public uint dwPicDataLen;						//·µ»ШНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ*/
            public byte byAlarmPicType;			// 0-ТміЈИЛБі±ЁѕЇНјЖ¬ 1- ИЛБіНјЖ¬,2-¶аХЕИЛБі 
            public byte byPanelChan;        /*2012-3-1ИЛБіНЁµА№ШБЄµДГж°еНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFacePicDataLen;			//ИЛБіНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±ЈБфЧЦЅЪ
            public IntPtr pFaceImage; //ЦёПтИЛБіНјЦёХл
            public IntPtr pImage;   						//ЦёПтНјЖ¬µДЦёХл
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;        	// БЄєПМеґуРЎОЄ12ЧЦЅЪ
            public uint dwHumanIn;  	//УРОЮИЛЅУЅь 0 - ОЮИЛ 1- УРИЛ  
            public float fCrowdDensity;  // ИЛФ±ѕЫјЇЦµ
        }

        //ДїЗ°Ц»УРУРИЛОЮИЛКВјюєНИЛФ±ѕЫјЇКВјюКµК±±ЁѕЇЙПґ«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO
        {
            public byte byRuleID;				// Rule ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				// ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;	// №жФтГыіЖ
            public uint dwEventType;    		// ІОХХVCA_EVENT_TYPE
            public NET_DVR_EVENT_PARAM_UNION uEventParam;  // 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO_LIST
        {
            public byte byNum;		// КВјюКµК±РЕПўёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_EVENT_INFO[] struEventInfo;	// КВјККµК±РЕПў
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RULE_INFO_ALARM
        {
            public uint dwSize;				// Ѕб№№МеґуРЎ
            public uint dwRelativeTime; 	// Па¶ФК±±к
            public uint dwAbsTime;			// ѕш¶ФК±±к
            public NET_VCA_DEV_INFO  	struDevInfo;		// З°¶ЛЙи±ёРЕПў
            public NET_DVR_EVENT_INFO_LIST struEventInfoList;	//КВјюРЕПўБР±н
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±ЈБфЧЦЅЪ
        }

        //µҐМхіЎѕ°К±јд¶О
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_TIME
        {
            public byte byActive;                     //0 -ОЮР§,1ЁCУРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //±ЈБф
            public uint dwSceneID;                    //іЎѕ°ID
            public NET_DVR_SCHEDTIME struEffectiveTime;   //іЎѕ°ЖрР§К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   //±ЈБф
        }

        //іЎѕ°ЖрР§К±јд¶ОЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_TIME_CFG
        {   
            public uint dwSize;                                               //Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SCENE_TIMESEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_TIME[] struSceneTime; //іЎѕ°К±јд¶ОКэЧй
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                            //±ЈБф
        }

        //µҐМхіЎѕ°ЕдЦГРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_CFG
        {    
            public byte byEnable;                 //КЗ·сЖфУГёГіЎѕ°,0-І»ЖфУГ 1- ЖфУГ
            public byte byDirection;              //јаІв·ЅПт 1-ЙПРРЈ¬2-ПВРРЈ¬3-Л«ПтЈ¬4-УЙ¶«ПтОчЈ¬5-УЙДППт±±Ј¬6-УЙОчПт¶«Ј¬7-УЙ±±ПтДПЈ¬8-ЖдЛь
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                //±ЈБф
            public uint dwSceneID;                //іЎѕ°ID(Ц»¶Б), 0 - ±нКѕёГіЎѕ°ОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;    //іЎѕ°ГыіЖ
            public NET_DVR_PTZPOS struPtzPos;       //ptz Чш±к
            public uint dwTrackTime;              //Зт»ъёъЧЩК±јд[5,300] ГлЈ¬TFS(Ѕ»НЁИЎЦ¤)ДЈКЅПВУРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //±ЈБф
        }

        //іЎѕ°ЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_CFG
        {
            public uint dwSize;                                          //Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITS_SCENE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_CFG[] struSceneCfg; //іЎѕ°ЕдЦГРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                      //±ЈБф
        }

        //¶аіЎѕ°ІЩЧчМхјю
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_COND
        {
            public uint dwSize;       //Ѕб№№ґуРЎ
            public Int32 lChannel;     //НЁµАєЕ
            public uint dwSceneID;    //іЎѕ°ID, 0-±нКѕёГіЎѕ°ОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±ЈБф
        }

        //ИЎЦ¤·ЅКЅ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FORENSICS_MODE
        {
            public uint dwSize;      //Ѕб№№ґуРЎ
            public byte byMode;      // 0-КЦ¶ЇИЎЦ¤ ,1-ЧФ¶ЇИЎЦ¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //±ЈБф
        }

        //±ЁѕЇіЎѕ°РЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_INFO
        {  
            public uint dwSceneID;              //іЎѕ°ID, 0 - ±нКѕёГіЎѕ°ОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;  //іЎѕ°ГыіЖ
            public byte byDirection;            //јаІв·ЅПт 1-ЙПРРЈ¬2-ПВРРЈ¬3-Л«ПтЈ¬4-УЙ¶«ПтОчЈ¬5-УЙДППт±±Ј¬6-УЙОчПт¶«Ј¬7-УЙ±±ПтДПЈ¬8-ЖдЛь
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //±ЈБф
            public NET_DVR_PTZPOS  struPtzPos;             //Ptz Чш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2 ;            //±ЈБф
        }

        //Ѕ»НЁКВјю±ЁѕЇ(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM_V41
        {
            public uint dwSize;              //Ѕб№№і¤¶И
            public uint dwRelativeTime;	    //Па¶ФК±±к
            public uint dwAbsTime;			//ѕш¶ФК±±к
            public NET_VCA_DEV_INFO  struDevInfo;		    //З°¶ЛЙи±ёРЕПў
            public NET_DVR_AID_INFO  struAIDInfo;         //Ѕ»НЁКВјюРЕПў
            public NET_DVR_SCENE_INFO struSceneInfo;       //іЎѕ°РЕПў
            public uint dwPicDataLen;        //НјЖ¬і¤¶И
            public IntPtr pImage; 			//ЦёПтНјЖ¬µДЦёХл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±ЈБф
        }

        //Ѕ»НЁНіјЖРЕПў±ЁѕЇ(А©Х№)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM_V41
        {
            public uint dwSize;          // Ѕб№№МеґуРЎ
            public uint dwRelativeTime;  // Па¶ФК±±к
            public uint dwAbsTime;       // ѕш¶ФК±±к
            public NET_VCA_DEV_INFO struDevInfo;     // З°¶ЛЙи±ёРЕПў
            public NET_DVR_TPS_INFO_V41  struTPSInfo;     // Ѕ»НЁІОКэНіјЖРЕПў 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_VERSION
        {
            public ushort wMajorVersion;		// Цч°ж±ѕєЕ
            public ushort wMinorVersion;		// ґО°ж±ѕєЕ
            public ushort wRevisionNumber;	// РЮХэєЕ
            public ushort wBuildNumber;		// ±аТлєЕ
            public ushort wVersionYear;		//	°ж±ѕИХЖЪ-Дк
            public byte byVersionMonth;		//	°ж±ѕИХЖЪ-ФВ
            public byte byVersionDay;		//	°ж±ѕИХЖЪ-ИХ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			// ±ЈБфЧЦЅЪ
        }
        /*******************************ЦЗДЬЅ»НЁКВјю end*****************************************/

        /******************************іµЕЖК¶±р begin******************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_PARAM
        {	
            public byte byPlateRecoMode;    //іµЕЖК¶±рµДДЈКЅ,Д¬ИПОЄ1(КУЖµґҐ·ўДЈКЅ)
            public byte byBelive;	/*ХыЕЖЦГРЕ¶ИгРЦµ, Ц»УГУЪКУЖµК¶±р·ЅКЅ, ёщѕЭ±іѕ°ёґФУіМ¶ИЙиЦГ, ОуґҐ·ўВКёЯѕНЙиёЯ, В©іµВКёЯѕНЙиµН, 
                                     * ЅЁТйФЪ80-90·¶О§ДЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±ЈБфЧЦЅЪ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATECFG
        {	
            public uint dwSize;
            public uint dwEnable;				           /* КЗ·сЖфУГКУЖµіµЕЖК¶±р 0Ј­·с 1Ј­КЗ */
            public byte byPicProType;	//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан ·З0-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±ЈБфЧЦЅЪ
            public NET_DVR_JPEGPARA struPictureParam; 		//НјЖ¬№жёсЅб№№
            public NET_DVR_PLATE_PARAM struPlateParam;   // іµЕЖК¶±рІОКэЕдЦГ
            public NET_DVR_HANDLEEXCEPTION struHandleType;	   /* ґ¦Ан·ЅКЅ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±ЈБфЧЦЅЪ
        }

        //іµЕЖК¶±рЅб№ыЧУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_INFO
        {
            public byte byPlateType; //іµЕЖАаРН
            public byte byColor; //іµЕЖСХЙ«
            public byte byBright; //іµЕЖББ¶И
            public byte byLicenseLen;	//іµЕЖЧЦ·ыёцКэ
            public byte byEntireBelieve;//ХыёціµЕЖµДЦГРЕ¶ИЈ¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
            public NET_VCA_RECT	struPlateRect;	//іµЕЖО»ЦГ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;	//іµЕЖєЕВл 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelieve; //ёчёцК¶±рЧЦ·ыµДЦГРЕ¶ИЈ¬ИзјмІвµЅіµЕЖ"ХгA12345", ЦГРЕ¶ИОЄ,20,30,40,50,60,70Ј¬Фт±нКѕ"Хг"ЧЦХэИ·µДїЙДЬРФЦ»УР%Ј¬"A"ЧЦµДХэИ·µДїЙДЬРФКЗ%
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATERECO_RESULE
        {
            public uint dwSize;
            public uint dwRelativeTime;	//Па¶ФК±±к
            public uint dwAbsTime;	//ѕш¶ФК±±к
            public NET_VCA_DEV_INFO struDevInfo; // З°¶ОЙи±ёРЕПў
            public NET_DVR_PLATE_INFO struPlateInfo;
            public uint dwPicDataLen;	//·µ»ШНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;	//±ЈБфЈ¬ЙиЦГОЄ0
            public IntPtr pImage;   //ЦёПтНјЖ¬µДЦёХл
        }
        /******************************іµЕЖК¶±р end******************************************/

        /******************************ЧҐЕД»ъ*******************************************/
        //IOКдИлЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_INCFG
        {
            public uint dwSize;
            public byte byIoInStatus;//КдИлµДIOїЪЧґМ¬Ј¬0-ПВЅµСШЈ¬1-ЙПЙэСШЈ¬2-ЙПЙэСШєНПВЅµСШЈ¬3-ёЯµзЖЅЈ¬4-µНµзЖЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЧЦЅЪ
        }

        //IOКдіцЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_OUTCFG
        {
            public uint dwSize;
            public byte byDefaultStatus;//IOД¬ИПЧґМ¬Јє0-µНµзЖЅЈ¬1-ёЯµзЖЅ 
            public byte byIoOutStatus;//IOЖрР§К±ЧґМ¬Јє0-µНµзЖЅЈ¬1-ёЯµзЖЅЈ¬2-Вціе
            public ushort wAheadTime;//КдіцIOМбЗ°К±јдЈ¬µҐО»us
            public uint dwTimePluse;//ВціејдёфК±јдЈ¬µҐО»us
            public uint dwTimeDelay;//IOУРР§іЦРшК±јдЈ¬µҐО»us
            public byte byFreqMulti;		//±¶ЖµЈ¬КэЦµ·¶О§[1,15]
            public byte byDutyRate;		//ХјїХ±ИЈ¬[0,40%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ЙБ№вµЖЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLASH_OUTCFG
        {
            public uint dwSize;
            public byte byMode;//ЙБ№вµЖЙБЛёДЈКЅЈ¬0-І»ЙБЈ¬1-ЙБЈ¬2-№ШБЄЙБЈ¬3-ВЦЙБ
            public byte byRelatedIoIn;//ЙБ№вµЖ№ШБЄµДКдИлIOєЕЈЁ№ШБЄЙБК±ґЛІОКэУРР§Ј©
            public byte byRecognizedLane;  /*№ШБЄµДIOєЕЈ¬°ґО»±нКѕЈ¬bit0±нКѕIO1КЗ·с№ШБЄЈ¬0-І»№ШБЄЈ¬1-№ШБЄ*/
            public byte byDetectBrightness;/*ЧФ¶ЇјмІвББ¶ИК№ДЬЙБ№вµЖ0-І»јмІвЈ»1-јмІв*/
            public byte byBrightnessThreld;/*К№ДЬЙБ№вµЖББ¶ИгРЦµЈ¬·¶О§[0,100],ёЯУЪгРЦµЙБ*/
            public byte byStartHour;		//їЄКјК±јд-РЎК±,ИЎЦµ·¶О§0-23
            public byte byStartMinute;		//їЄКјК±јд-·Ц,ИЎЦµ·¶О§0-59
            public byte byEndHour;		 	//ЅбКшК±јд-РЎК±,ИЎЦµ·¶О§0-23
            public byte byEndMinute;		//ЅбКшК±јд-·Ц,ИЎЦµ·¶О§0-59
            public byte byFlashLightEnable;	//ЙиЦГЙБ№вµЖК±јдК№ДЬ:0-№Ш;1-їЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ємВМµЖ№¦ДЬЈЁ2ёцIOКдИлТ»ЧйЈ©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIGHTSNAPCFG
        {
            public uint dwSize;
            public byte byLightIoIn;//ємВМµЖµДIO єЕ
            public byte byTrigIoIn;//ґҐ·ўµДIOєЕ
            public byte byRelatedDriveWay;//ґҐ·ўIO№ШБЄµДіµµАєЕ
            public byte byTrafficLight; //0-ёЯµзЖЅємµЖЈ¬µНµзЖЅВМµЖЈ»1-ёЯµзЖЅВМµЖЈ¬µНµзЖЅємµЖ
            public byte bySnapTimes1; //ємµЖЧҐЕДґОКэ1Ј¬0-І»ЧҐЕДЈ¬·З0-Б¬ЕДґОКэЈ¬Чоґу5ґО 
            public byte bySnapTimes2; //ВМµЖЧҐЕДґОКэ2Ј¬0-І»ЧҐЕДЈ¬·З0-Б¬ЕДґОКэЈ¬Чоґу5ґО 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//ємµЖБ¬ЕДјдёфК±јдЈ¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//ВМµЖБ¬ЕДјдёфК±јдЈ¬ms
            public byte byRecord;//ґіємµЖЦЬЖЪВјПс±кЦѕЈ¬0-І»ВјПсЈ¬1-ВјПс
            public byte bySessionTimeout;//ґіємµЖЦЬЖЪВјПсі¬К±К±јдЈЁГлЈ©
            public byte byPreRecordTime;//ґіємµЖВјПсЖ¬¶ОФ¤ВјК±јд(Гл)
            public byte byVideoDelay;//ґіємµЖВјПсЖ¬¶ОСУК±К±јдЈЁГлЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБфЧЦЅЪ
        }

        //ІвЛЩ№¦ДЬ(2ёцIOКдИлТ»ЧйЈ©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MEASURESPEEDCFG
        {
            public uint dwSize;
            public byte byTrigIo1;   //ІвЛЩµЪ1ПЯИ¦
            public byte byTrigIo2;   //ІвЛЩµЪ2ПЯИ¦
            public byte byRelatedDriveWay;//ґҐ·ўIO№ШБЄµДіµµАєЕ
            public byte byTestSpeedTimeOut;//ІвЛЩДЈКЅі¬К±К±јдЈ¬µҐО»s
            public uint dwDistance;//ПЯИ¦ѕаАл,cm
            public byte byCapSpeed;//ІвЛЩДЈКЅЖрЕДЛЩ¶ИЈ¬µҐО»km/h
            public byte bySpeedLimit;//ПЮЛЩЦµЈ¬µҐО»km/h
            public byte bySnapTimes1; //ПЯИ¦1ЧҐЕДґОКэЈ¬0-І»ЧҐЕДЈ¬·З0-Б¬ЕДґОКэЈ¬Чоґу5ґО 
            public byte bySnapTimes2; //ПЯИ¦2ЧҐЕДґОКэЈ¬0-І»ЧҐЕДЈ¬·З0-Б¬ЕДґОКэЈ¬Чоґу5ґО 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//ПЯИ¦1Б¬ЕДјдёфК±јдЈ¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//ПЯИ¦2Б¬ЕДјдёфК±јдЈ¬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЧЦЅЪ
        }

        //КУЖµІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOEFFECT
        {
            public byte byBrightnessLevel; /*0-100*/
            public byte byContrastLevel; /*0-100*/
            public byte bySharpnessLevel; /*0-100*/
            public byte bySaturationLevel; /*0-100*/
            public byte byHueLevel; /*0-100,ЈЁ±ЈБфЈ©*/
            public byte byEnableFunc; //К№ДЬЈ¬°ґО»±нКѕЈ¬bit0-SMART IR(·А№эЖШ)Ј¬bit1-µНХХ¶И,bit2-Зї№вТЦЦЖК№ДЬЈ¬0-·сЈ¬1-КЗ
            public byte byLightInhibitLevel; //Зї№вТЦЦЖµИј¶Ј¬[1-3]±нКѕµИј¶
            public byte byGrayLevel; //»Т¶ИЦµУтЈ¬0-[0-255]Ј¬1-[16-235]
        }

        //ФцТжЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAIN
        {
            public byte byGainLevel; /*ФцТжЈє0-100*/
            public byte byGainUserSet; /*УГ»§ЧФ¶ЁТеФцТжЈ»0-100Ј¬¶ФУЪЧҐЕД»ъЈ¬КЗCCDДЈКЅПВµДЧҐЕДФцТж*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMaxGainValue;/*ЧоґуФцТжЦµЈ¬µҐО»dB*/
        }

        //°ЧЖЅєвЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WHITEBALANCE
        {
            public byte byWhiteBalanceMode; /*0-КЦ¶Ї°ЧЖЅєвЈЁMWBЈ©,1-ЧФ¶Ї°ЧЖЅєв1ЈЁAWB1Ј©,2-ЧФ¶Ї°ЧЖЅєв2 (AWB2),3-ЧФ¶ЇїШЦЖёДГыОЄЛш¶Ё°ЧЖЅєв(Locked WB)Ј¬
	                         4-КТНв(Indoor)Ј¬5-КТДЪ(Outdoor)6-ИХ№вµЖ(Fluorescent Lamp)Ј¬7-ДЖµЖ(Sodium Lamp)Ј¬
	                         8-ЧФ¶ЇёъЧЩ(Auto-Track)9-Т»ґО°ЧЖЅєв(One Push)Ј¬10-КТНвЧФ¶Ї(Auto-Outdoor)Ј¬
	                         11-ДЖµЖЧФ¶Ї (Auto-Sodiumlight)Ј¬12-Л®ТшµЖ(Mercury Lamp)Ј¬13-ЧФ¶Ї°ЧЖЅєв(Auto)Ј¬
	                         14-°ЧігµЖ (IncandescentLamp)Ј¬15-ЕЇ№вµЖ(Warm Light Lamp)Ј¬16-ЧФИ»№в(Natural Light) */
            public byte byWhiteBalanceModeRGain; /*КЦ¶Ї°ЧЖЅєвК±УРР§Ј¬КЦ¶Ї°ЧЖЅєв RФцТж*/
            public byte byWhiteBalanceModeBGain; /*КЦ¶Ї°ЧЖЅєвК±УРР§Ј¬КЦ¶Ї°ЧЖЅєв BФцТж*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ЖШ№вїШЦЖ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXPOSURE
        {
            public byte byExposureMode; /*0 КЦ¶ЇЖШ№в 1ЧФ¶ЇЖШ№в*/
            public byte byAutoApertureLevel; /* ЧФ¶Ї№вИ¦БйГф¶И, 0-10 */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwVideoExposureSet; /* ЧФ¶ЁТеКУЖµЖШ№вК±јдЈЁµҐО»usЈ©*//*Чў:ЧФ¶ЇЖШ№вК±ёГЦµОЄЖШ№вЧоВэЦµ РВФц20-1s(1000000us)*/        
            public uint dwExposureUserSet; /* ЧФ¶ЁТеЖШ№вК±јд,ФЪЧҐЕД»ъЙПУ¦УГК±Ј¬CCDДЈКЅК±КЗЧҐЕДїмГЕЛЩ¶И*/   
            public uint dwRes;    
        }

        //їн¶ЇМ¬ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WDR
        {
            public byte byWDREnabled; /*їн¶ЇМ¬Јє0 dsibale  1 enable 2 auto*/
            public byte byWDRLevel1; /*0-F*/
            public byte byWDRLevel2; /*0-F*/
            public byte byWDRContrastLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ИХТ№ЧЄ»»№¦ДЬЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DAYNIGHT
        {
            public byte byDayNightFilterType; /*ИХТ№ЗР»»Јє0-°ЧМмЈ¬1-Т№НнЈ¬2-ЧФ¶ЇЈ¬3-¶ЁК±Ј¬4-±ЁѕЇКдИлґҐ·ў*/
            public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(±ЈБф)*/
            //¶ЁК±ДЈКЅІОКэ
            public byte byBeginTime; /*їЄКјК±јдЈЁРЎК±Ј©Ј¬0-23*/
            public byte byEndTime; /*ЅбКшК±јдЈЁРЎК±Ј©Ј¬0-23*/
            //ДЈКЅ2
            public byte byDayToNightFilterLevel; //0-7
            public byte byNightToDayFilterLevel; //0-7
            public byte byDayNightFilterTime;//(60Гл)
            //¶ЁК±ДЈКЅІОКэ
            public byte byBeginTimeMin; //їЄКјК±јдЈЁ·ЦЈ©Ј¬0-59
            public byte byBeginTimeSec; //їЄКјК±јдЈЁГлЈ©Ј¬0-59
            public byte byEndTimeMin; //ЅбКшК±јдЈЁ·ЦЈ©Ј¬0-59
            public byte byEndTimeSec; //ЅбКшК±јдЈЁГлЈ©Ј¬0-59
	        //±ЁѕЇКдИлґҐ·ўДЈКЅІОКэ
            public byte byAlarmTrigState; //±ЁѕЇКдИлґҐ·ўЧґМ¬Ј¬0-°ЧМмЈ¬1-Т№Нн
        }

        //GammaРЈХэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAMMACORRECT
        {
            public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
            public byte byGammaCorrectionLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±і№вІ№іҐЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKLIGHT
        {
            public byte byBacklightMode; /*±і№вІ№іҐ:0 off 1 UPЎў2 DOWNЎў3 LEFTЎў4 RIGHTЎў5MIDDLEЎў6ЧФ¶ЁТе*/
            public byte byBacklightLevel; /*0x0-0xF*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionX1; //ЈЁXЧш±к1Ј©
            public uint dwPositionY1; //ЈЁYЧш±к1Ј©
            public uint dwPositionX2; //ЈЁXЧш±к2Ј©
            public uint dwPositionY2; //ЈЁYЧш±к2Ј©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //КэЧЦЅµФл№¦ДЬ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOISEREMOVE
        {
            public byte byDigitalNoiseRemoveEnable; /*0-І»ЖфУГЈ¬1-ЖХНЁДЈКЅКэЧЦЅµФлЈ¬2-ЧЁјТДЈКЅКэЧЦЅµФл*/
            public byte byDigitalNoiseRemoveLevel; /*ЖХНЁДЈКЅКэЧЦЅµФлј¶±рЈє0x0-0xF*/
            public byte bySpectralLevel;       /*ЧЁјТДЈКЅПВїХУтЗї¶ИЈє0-100*/
            public byte byTemporalLevel;   /*ЧЁјТДЈКЅПВК±УтЗї¶ИЈє0-100*/
            public byte byDigitalNoiseRemove2DEnable;         /* ЧҐЕДЦЎ2DЅµФлЈ¬0-І»ЖфУГЈ¬1-ЖфУГ */	
            public byte byDigitalNoiseRemove2DLevel;            /* ЧҐЕДЦЎ2DЅµФлј¶±рЈ¬0-100 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //CMOSДЈКЅПВЗ°¶ЛѕµН·ЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CMOSMODECFG
        {
            public byte byCaptureMod;   //ЧҐЕДДЈКЅЈє0-ЧҐЕДДЈКЅ1Ј»1-ЧҐЕДДЈКЅ2
            public byte byBrightnessGate;//ББ¶ИгРЦµ
            public byte byCaptureGain1;   //ЧҐЕДФцТж1,0-100
            public byte byCaptureGain2;   //ЧҐЕДФцТж2,0-100
            public uint dwCaptureShutterSpeed1;//ЧҐЕДїмГЕЛЩ¶И1
            public uint dwCaptureShutterSpeed2;//ЧҐЕДїмГЕЛЩ¶И2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //З°¶ЛІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ББ¶ИЎў¶Ф±И¶ИЎў±ҐєН¶ИЎўИс¶ИЎўЙ«µчЕдЦГ*/    
            public NET_DVR_GAIN struGain;/*ЧФ¶ЇФцТж*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°ЧЖЅєв*/
            public NET_DVR_EXPOSURE struExposure; /*ЖШ№вїШЦЖ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaРЈХэ*/
            public NET_DVR_WDR struWdr;/*їн¶ЇМ¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*ИХТ№ЧЄ»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±і№вІ№іҐ*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*КэЧЦЅµФл*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0 ЧФ¶Ї№вИ¦ 1КЦ¶Ї№вИ¦*/    
            public byte byMirror ;  /* ѕµПсЈє0 offЈ¬1- leftrightЈ¬2- updownЈ¬3-center */
            public byte byDigitalZoom;  /*КэЧЦЛх·Е:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµгјмІв,0 dsibale  1 enable*/
            public byte byBlackPwl;/*єЪµзЖЅІ№іҐ ,  0-255*/ 
            public byte byEptzGate;// EPTZїЄ№Ш±дБї:0-І»ЖфУГµзЧУФЖМЁЈ¬1-ЖфУГµзЧУФЖМЁ
            public byte byLocalOutputGate;//±ѕµШКдіцїЄ№Ш±дБї0-±ѕµШКдіц№Ш±Х1-±ѕµШBNCКдіцґтїЄ 2-HDMIКдіц№Ш±Х  
				     //20-HDMI_720P50КдіцїЄ
					 //21-HDMI_720P60КдіцїЄ
					 //22-HDMI_1080I60КдіцїЄ
					 //23-HDMI_1080I50КдіцїЄ
					 //24-HDMI_1080P24КдіцїЄ
					 //25-HDMI_1080P25КдіцїЄ
					 //26-HDMI_1080P30КдіцїЄ
					 //27-HDMI_1080P50КдіцїЄ
			         //28-HDMI_1080P60КдіцїЄ
					 //40-SDI_720P50,
					 //41-SDI_720P60,
					 //42-SDI_1080I50,
					 //43-SDI_1080I60,
					 //44-SDI_1080P24,
					 //45-SDI_1080P25,
					 //46-SDI_1080P30,
					 //47-SDI_1080P50,
					 //48-SDI_1080P60
            public byte byCoderOutputMode;//±аВлЖчfpgaКдіцДЈКЅ0Ц±НЁ3ПсЛШ°бјТ
            public byte byLineCoding; //КЗ·сїЄЖфРР±аВлЈє0-·сЈ¬1-КЗ
            public byte byDimmerMode; //µч№вДЈКЅЈє0-°лЧФ¶ЇЈ¬1-ЧФ¶Ї
            public byte byPaletteMode; //µчЙ«°еЈє0-°ЧИИЈ¬1-єЪИИЈ¬2-µчЙ«°е2Ј¬Ў­Ј¬8-µчЙ«°е8
            public byte byEnhancedMode; //ФцЗї·ЅКЅЈЁМЅІвОпМеЦЬ±ЯЈ©Јє0-І»ФцЗїЈ¬1-1Ј¬2-2Ј¬3-3Ј¬4-4
            public byte byDynamicContrastEN;    //¶ЇМ¬¶Ф±И¶ИФцЗї 0-1
            public byte byDynamicContrast;    //¶ЇМ¬¶Ф±И¶И 0-100
            public byte byJPEGQuality;    //JPEGНјПсЦКБї 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSДЈКЅПВЗ°¶ЛІОКэЕдЦГЈ¬ѕµН·ДЈКЅґУДЬБ¦јЇ»сИЎ
            public byte byFilterSwitch; //ВЛІЁїЄ№ШЈє0-І»ЖфУГЈ¬1-ЖфУГ
            public byte byFocusSpeed; //ѕµН·µчЅ№ЛЩ¶ИЈє0-10
            public byte byAutoCompensationInterval; //¶ЁК±ЧФ¶ЇїмГЕІ№іҐЈє1-120Ј¬µҐО»Јє·ЦЦУ
            public byte bySceneMode;  //іЎѕ°ДЈКЅЈє0-КТНвЈ¬1-КТДЪЈ¬2-Д¬ИПЈ¬3-Их№в
        }

        //НёОн
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOGCFG
        {
            public byte byMode; //ДЈКЅЈ¬0-І»ЖфУГЈ¬1-ЧФ¶ЇДЈКЅЈ¬2-іЈїЄДЈКЅ
            public byte byLevel; //µИј¶Ј¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //µзЧУ·А¶¶
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ELECTRONICSTABILIZATION
        {
            public byte byEnable;//К№ДЬ 0- І»ЖфУГЈ¬1- ЖфУГ
            public byte byLevel; //µИј¶Ј¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //ЧЯАИДЈКЅ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRIDOR_MODE_CCD
        {
            public byte byEnableCorridorMode; //КЗ·сЖфУГЧЯАИДЈКЅ 0Ў«І»ЖфУГЈ¬ 1Ў«ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //SMART IR(·А№эЖШ)ЕдЦГІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMARTIR_PARAM
        {
            public byte byMode;//0Ў«КЦ¶ЇЈ¬1Ў«ЧФ¶Ї
            public byte byIRDistance;//ємНвѕаАлµИј¶(µИј¶Ј¬ѕаАлХэ±ИАэ)level:1~100 Д¬ИП:50ЈЁКЦ¶ЇДЈКЅПВФцјУЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ФЪbyIrisMode ОЄP-Iris1К±ЙъР§Ј¬ЕдЦГємНв№вИ¦ґуРЎµИј¶Ј¬ЕдЦГДЈКЅ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIRIS_PARAM
        {
            public byte byMode;//0-ЧФ¶ЇЈ¬1-КЦ¶Ї
            public byte byPIrisAperture;//ємНв№вИ¦ґуРЎµИј¶(µИј¶,№вИ¦ґуРЎХэ±ИАэ)level:1~100 Д¬ИП:50ЈЁКЦ¶ЇДЈКЅПВФцјУЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //З°¶ЛІОКэЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG_EX
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*ББ¶ИЎў¶Ф±И¶ИЎў±ҐєН¶ИЎўИс¶ИЎўЙ«µчЕдЦГ*/
            public NET_DVR_GAIN struGain;/*ЧФ¶ЇФцТж*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*°ЧЖЅєв*/
            public NET_DVR_EXPOSURE struExposure; /*ЖШ№вїШЦЖ*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaРЈХэ*/
            public NET_DVR_WDR struWdr;/*їн¶ЇМ¬*/
            public NET_DVR_DAYNIGHT struDayNight;/*ИХТ№ЧЄ»»*/
            public NET_DVR_BACKLIGHT struBackLight;/*±і№вІ№іҐ*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*КэЧЦЅµФл*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0-ЧФ¶Ї№вИ¦ 1-КЦ¶Ї№вИ¦, 2-P-Iris1*/    
            public byte byMirror ;  /* ѕµПсЈє0 offЈ¬1- leftrightЈ¬2- updownЈ¬3-center */
            public byte byDigitalZoom;  /*КэЧЦЛх·Е:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*»µµгјмІв,0 dsibale  1 enable*/
            public byte byBlackPwl;/*єЪµзЖЅІ№іҐ ,  0-255*/ 
            public byte byEptzGate;// EPTZїЄ№Ш±дБї:0-І»ЖфУГµзЧУФЖМЁЈ¬1-ЖфУГµзЧУФЖМЁ
            public byte byLocalOutputGate;//±ѕµШКдіцїЄ№Ш±дБї0-±ѕµШКдіц№Ш±Х1-±ѕµШBNCКдіцґтїЄ 2-HDMIКдіц№Ш±Х  
	        //20-HDMI_720P50КдіцїЄ
	        //21-HDMI_720P60КдіцїЄ
	        //22-HDMI_1080I60КдіцїЄ
	        //23-HDMI_1080I50КдіцїЄ
	        //24-HDMI_1080P24КдіцїЄ
	        //25-HDMI_1080P25КдіцїЄ
	        //26-HDMI_1080P30КдіцїЄ
	        //27-HDMI_1080P50КдіцїЄ
	        //28-HDMI_1080P60КдіцїЄ
            public byte byCoderOutputMode;//±аВлЖчfpgaКдіцДЈКЅ0Ц±НЁ3ПсЛШ°бјТ
            public byte byLineCoding; //КЗ·сїЄЖфРР±аВлЈє0-·сЈ¬1-КЗ
            public byte byDimmerMode; //µч№вДЈКЅЈє0-°лЧФ¶ЇЈ¬1-ЧФ¶Ї
            public byte byPaletteMode; //µчЙ«°еЈє0-°ЧИИЈ¬1-єЪИИЈ¬2-µчЙ«°е2Ј¬Ў­Ј¬8-µчЙ«°е8
            public byte byEnhancedMode; //ФцЗї·ЅКЅЈЁМЅІвОпМеЦЬ±ЯЈ©Јє0-І»ФцЗїЈ¬1-1Ј¬2-2Ј¬3-3Ј¬4-4
            public byte byDynamicContrastEN;    //¶ЇМ¬¶Ф±И¶ИФцЗї 0-1
            public byte byDynamicContrast;    //¶ЇМ¬¶Ф±И¶И 0-100
            public byte byJPEGQuality;    //JPEGНјПсЦКБї 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSДЈКЅПВЗ°¶ЛІОКэЕдЦГЈ¬ѕµН·ДЈКЅґУДЬБ¦јЇ»сИЎ
            public byte byFilterSwitch; //ВЛІЁїЄ№ШЈє0-І»ЖфУГЈ¬1-ЖфУГ
            public byte byFocusSpeed; //ѕµН·µчЅ№ЛЩ¶ИЈє0-10
            public byte byAutoCompensationInterval; //¶ЁК±ЧФ¶ЇїмГЕІ№іҐЈє1-120Ј¬µҐО»Јє·ЦЦУ
            public byte bySceneMode;  //іЎѕ°ДЈКЅЈє0-КТНвЈ¬1-КТДЪЈ¬2-Д¬ИПЈ¬3-Их№в
            public NET_DVR_DEFOGCFG struDefogCfg;//НёОнІОКэ
            public NET_DVR_ELECTRONICSTABILIZATION struElectronicStabilization;//µзЧУ·А¶¶
            public NET_DVR_CORRIDOR_MODE_CCD struCorridorMode;//ЧЯАИДЈКЅ
            public byte byExposureSegmentEnable; //0~І»ЖфУГ,1~ЖфУГ  ЖШ№вК±јдєНФцТжіКЅЧМЭЧґµчХыЈ¬±ИИзЖШ№вНщЙПµчХыК±Ј¬ПИМбёЯЖШ№вК±јдµЅЦРјдЦµЈ¬И»єуМбёЯФцТжµЅЦРјдЦµЈ¬ФЩМбёЯЖШ№вµЅЧоґуЦµЈ¬ЧоєуМбёЯФцТжµЅЧоґуЦµ
            public byte byBrightCompensate;//ББ¶ИФцЗї [0~100]

	        /*0-№Ш±ХЎў1-640*480@25fpsЎў2-640*480@30psЎў3-704*576@25fpsЎў4-704*480@30fpsЎў5-1280*720@25fpsЎў6-1280*720@30fpsЎў
             * 7-1280*720@50fpsЎў8-1280*720@60fpsЎў9-1280*960@15fpsЎў10-1280*960@25fpsЎў11-1280*960@30fpsЎў
             * 12-1280*1024@25fpsЎў13--1280*1024@30fpsЎў14-1600*900@15fpsЎў15-1600*1200@15fpsЎў16-1920*1080@15fpsЎў
             * 17-1920*1080@25fpsЎў18-1920*1080@30fpsЎў19-1920*1080@50fpsЎў20-1920*1080@60fpsЎў21-2048*1536@15fpsЎў22-2048*1536@20fpsЎў
             * 23-2048*1536@24fpsЎў24-2048*1536@25fpsЎў25-2048*1536@30fpsЎў26-2560*2048@25fpsЎў27-2560*2048@30fpsЎў
             * 28-2560*1920@7.5fpsЎў29-3072*2048@25fpsЎў30-3072*2048@30fpsЎў31-2048*1536@12.5Ўў32-2560*1920@6.25Ўў
             * 33-1600*1200@25Ўў34-1600*1200@30Ўў35-1600*1200@12.5Ўў36-1600*900@12.5Ўў37-1600@900@15Ўў38-800*600@25Ўў39-800*600@30*/
            public byte byCaptureModeN; //КУЖµКдИлДЈКЅЈЁNЦЖЈ©
            public byte byCaptureModeP; //КУЖµКдИлДЈКЅЈЁPЦЖЈ©
            public NET_DVR_SMARTIR_PARAM struSmartIRParam; //ємНв·Е№э±¬ЕдЦГРЕПў
            public NET_DVR_PIRIS_PARAM struPIrisParam;//PIrisЕдЦГРЕПў¶ФУ¦byIrisModeЧЦ¶ОґУ2-PIris1їЄКјЙъР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //іµЕЖСХЙ«
        public enum VCA_PLATE_COLOR
        {
            VCA_BLUE_PLATE = 0,//А¶Й«іµЕЖ
            VCA_YELLOW_PLATE,//»ЖЙ«іµЕЖ
            VCA_WHITE_PLATE,//°ЧЙ«іµЕЖ
            VCA_BLACK_PLATE,//єЪЙ«іµЕЖ
            VCA_GREEN_PLATE //ВМЙ«іµЕЖ
        }

        //іµЕЖАаРН
        public enum VCA_PLATE_TYPE
        {
            VCA_STANDARD92_PLATE = 0,//±кЧјГсУГіµУлѕьіµ
            VCA_STANDARD02_PLATE,//02КЅГсУГіµЕЖ 
            VCA_WJPOLICE_PLATE,//ОдѕЇіµ 
            VCA_JINGCHE_PLATE,//ѕЇіµ
            STANDARD92_BACK_PLATE,//ГсУГіµЛ«РРОІЕЖ
            VCA_SHIGUAN_PLATE,          //К№№ЭіµЕЖ
            VCA_NONGYONG_PLATE,         //Е©УГіµ
            VCA_MOTO_PLATE              //Д¦НРіµ
        }

        public enum VLR_VEHICLE_CLASS
        {
            VLR_OTHER       = 0,   //ЖдЛь
	        VLR_VOLKSWAGEN = 1,    //ґуЦЪ
	        VLR_BUICK        = 2,  //±рїЛ
	        VLR_BMW         = 3,   //±¦Вн
	        VLR_HONDA       = 4,   //±ѕМп
	        VLR_PEUGEOT     = 5,   //±кЦВ
	        VLR_TOYOTA      = 6,   //·бМп
	        VLR_FORD         = 7,  //ёЈМШ
	        VLR_NISSAN       = 8,  //ИХІъ
	        VLR_AUDI         = 9,  //°ВµП
	        VLR_MAZDA       = 10,  //ВнЧФґп
	        VLR_CHEVROLET  = 11,   //С©·рАј
	        VLR_CITROEN     = 12,  //С©МъБъ
	        VLR_HYUNDAI    = 13,   //ПЦґъ
	        VLR_CHERY       = 14   //ЖжИр
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VEHICLE_INFO
        {
            public uint dwIndex;
            public byte byVehicleType;
            public byte byColorDepth;
            public byte byColor;
            public byte byRes1;
            public ushort wSpeed;
            public ushort wLength;
            public byte byIllegalType;
            public byte byVehicleLogoRecog; //ІОїјГ¶ѕЩАаРН VLR_VEHICLE_CLASS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byCustomInfo;  //ЧФ¶ЁТеРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes2 = new byte[2];
                byCustomInfo = new byte[16];
                byRes = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RESULT
        {
            public uint dwSize;
            public byte byResultType;
            public byte byChanIndex;
            public ushort wAlarmRecordID;	//±ЁѕЇВјПсID(УГУЪІйСЇВјПсЈ¬Ѕцµ±byResultTypeОЄ2К±УРР§)
            public uint dwRelativeTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAbsTime;
            public uint dwPicLen;
            public uint dwPicPlateLen;
            public uint dwVideoLen;
            public byte byTrafficLight;
            public byte byPicNum;
            public byte byDriveChan;
            public byte byVehicleType; //0- ОґЦЄЈ¬1- їНіµЈ¬2- »хіµЈ¬3- ЅОіµЈ¬4- Гж°ьіµЈ¬5- РЎ»хіµ
            public uint dwBinPicLen;
            public uint dwCarPicLen;
            public uint dwFarCarPicLen;
            public IntPtr pBuffer3;
            public IntPtr pBuffer4;
            public IntPtr pBuffer5;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            public IntPtr pBuffer1;
            public IntPtr pBuffer2;

            public void Init()
            {
                byAbsTime = new byte[32];
                byRes3 = new byte[8];
            }
        }

        //НјПсµюјУРЕПўЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IMAGEOVERLAYCFG
        {
            public uint dwSize;
            public byte byOverlayInfo;//µюјУК№ДЬїЄ№ШЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayMonitorInfo;//КЗ·сµюјУјаІвµгРЕПўЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayTime;//КЗ·сµюјУК±јдЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlaySpeed;//КЗ·сµюјУЛЩ¶ИЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlaySpeeding;//КЗ·сµюјУі¬ЛЩ±ИАэЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayLimitFlag;//КЗ·сµюјУПЮЛЩ±кЦѕЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayPlate;//КЗ·сµюјУіµЕЖєЕЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayColor;//КЗ·сµюјУіµЙнСХЙ«Ј¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayLength;//КЗ·сµюјУіµі¤Ј¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayType;//КЗ·сµюјУіµРНЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayColorDepth;//КЗ·сµюјУіµЙнСХЙ«ЙоЗіЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayDriveChan;//КЗ·сµюјУіµµАЈ¬0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayMilliSec; //µюјУєБГлРЕПў 0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayIllegalInfo; //µюјУОҐХВРЕПў 0-І»µюјУЈ¬1-µюјУ
            public byte byOverlayRedOnTime;  //µюјУємµЖТСББК±јд 0-І»µюјУЈ¬1-µюјУ
            public byte byFarAddPlateJpeg;      //Ф¶ѕ°НјКЗ·сµюјУіµЕЖЅШНј,0-І»µюјУ,1-µюјУ
            public byte byNearAddPlateJpeg;      //Ѕьѕ°НјКЗ·сµюјУіµЕЖЅШНј,0-І»µюјУ,1-µюјУ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo1;    //јаІвµгРЕПў1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo2; //јмІвµгРЕПў2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPCFG
        {
            public uint dwSize;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public ushort wSnapWaitTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public enum ITC_MAINMODE_ABILITY
        {
            ITC_MODE_UNKNOW = 0x0,   //ОЮ
	        ITC_POST_MODE   = 0x1,  //їЁїЪДЈКЅ
	        ITC_EPOLICE_MODE      = 0x2,  //µзѕЇДЈКЅ
	        ITC_POSTEPOLICE_MODE  = 0x4  //їЁКЅµзѕЇДЈКЅ
        }

        public enum ITC_RECOG_REGION_TYPE
        {
            ITC_REGION_RECT    = 0x0,   //ѕШРО
	        ITC_REGION_POLYGON  = 0x1,  //¶а±ЯРО
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAP_ABILITY
        {
            public uint dwSize;
            public byte byIoInNum;//IOКдИлїЪКэ
            public byte byIoOutNum;//IOКдіцїЪКэ
            public byte bySingleSnapNum;//µҐIOґҐ·ўЧйКэ
            public byte byLightModeArrayNum;//ємВМµЖДЈКЅЧйКэ
            public byte byMeasureModeArrayNum;//ІвЛЩДЈКЅЧйКэ
            public byte byPlateEnable; //іµЕЖК¶±рДЬБ¦
            public byte byLensMode;//ѕµН·ДЈКЅ0-CCD,1-CMOS
            public byte byPreTriggerSupport; //КЗ·сЦ§іЦФ­ґҐ·ўДЈКЅЈ¬0-Ц§іЦЈ¬1-І»Ц§іЦ
            public uint dwAbilityType; //Ц§іЦµДґҐ·ўДЈКЅДЬБ¦Ј¬°ґО»±нКѕЈ¬¶ЁТејыITC_MAINMODE_ABILITY
            public byte byIoSpeedGroup; //Ц§іЦµДIOІвЛЩЧйКэ
            public byte byIoLightGroup; //Ц§іЦµДIOємВМµЖЧйКэ
            public byte byRecogRegionType; //ЕЖК¶ЗшУтЦ§іЦµДАаРНЈ¬Пкјы¶ЁТеITC_RECOG_REGION_TYPE
            public byte bySupport; //Йи±ёДЬБ¦Ј¬°ґО»±нКѕЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
	        // bySupport&0x1Ј¬±нКѕКЗ·сЦ§іЦА©Х№µДЧЦ·ыµюјУЕдЦГ
	        // bySupport&0x2Ј¬±нКѕКЗ·сЦ§іЦА©Х№µДРЈК±ЕдЦГЅб№№
	        // bySupport&0x4, ±нКѕКЗ·сЦ§іЦ¶аНшїЁ(¶аНшёфАл)
	        // bySupport&0x8, ±нКѕКЗ·сЦ§іЦНшїЁµДbonding№¦ДЬ(НшВзИЭґн)
	        // bySupport&0x10, ±нКѕКЗ·сЦ§іЦУпТф¶ФЅІ
	        //2013-07-09 ДЬБ¦јЇ·µ»Ш
            public ushort wSupportMultiRadar;// Йи±ёДЬБ¦Ј¬°ґО»±нКѕЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
	        // wSupportMultiRadar&0x1Ј¬±нКѕ їЁїЪRS485АЧґп Ц§іЦіµµА№ШБЄАЧґпґ¦Ан
	        // wSupportMultiRadar&0x2Ј¬±нКѕ їЁїЪРйДвПЯИ¦ Ц§іЦіµµА№ШБЄАЧґпґ¦Ан
	        // wSupportMultiRadar&0x4Ј¬±нКѕ »мРРїЁїЪ Ц§іЦіµµА№ШБЄАЧґпґ¦Ан
	        // wSupportMultiRadar&0x8Ј¬±нКѕ КУЖµјмІв Ц§іЦіµµА№ШБЄАЧґпґ¦Ан
            public byte byICRPresetNum;
	        // ±нКѕЦ§іЦµДICRФ¤ЦГµгЈЁВЛ№вЖ¬Ж«ТЖµгЈ©Кэ
            public byte byICRTimeSlot;//±нКѕЦ§іЦµДICRµДК±јд¶ОКэЈЁ1Ў«8Ј©
            public byte bySupportRS485Num;//±нКѕЦ§іЦµДRS485їЪµДКэБї
            public byte byExpandRs485SupportSensor;// Йи±ёДЬБ¦Ј¬°ґО»±нКѕЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
	        // byExpandRs485SupportSensor &0x1Ј¬±нКѕµзѕЇіµјмЖчЦ§іЦіµјмЖч
	        // byExpandRs485SupportSensor &0x2Ј¬±нКѕїЁКЅµзѕЇіµјмЖчЦ§іЦіµјмЖч
            public byte byExpandRs485SupportSignalLampDet;// Йи±ёДЬБ¦Ј¬°ґО»±нКѕЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
	        // byExpandRs485SupportSignalLampDet &0x1Ј¬±нКѕµзѕЇіµјмЖчЦ§іЦНвЅУРЕєЕµЖјмІвЖч
            // byExpandRs485SupportSignalLampDet &0x2Ј¬±нКѕїЁКЅµзѕЇіµјмЖчЦ§іЦНвЅУРЕєЕµЖјмІвЖч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRTIMECFG
        {
            public NET_DVR_SCHEDTIME  struTime;
            public byte byAssociateRresetNo;//Ф¤ЦГµгєЕ1Ў«8 , 0ґъ±нОЮ
            public byte bySubSwitchMode;//1~°ЧМмЈ¬2~НнЙП (µ±Ф¤ЦГµгµИУЪ0 µДК±єтЙъР§)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_TIMESWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_ICRTIMECFG[] struAutoCtrlTime;//ЧФ¶ЇЗР»»К±јд¶О (ЧФ¶ЇЗР»»ПВ К±їХПВЙъР§ ПЦФЪЦ§іЦ4ЧйЈ¬Ф¤Бф4Чй)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //КµјКЙъР§ёщѕЭДЬБ¦јЇ¶ЇМ¬ПФКѕ [0~100] КэЧйПВ±к±нКѕФ¤ЦГµгєЕ1Ў«8 ЈЁ0Ў«7 Па¶ФУ¦Ј©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_MANUALSWITCH_PARAM
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //КµјКЙъР§ёщѕЭДЬБ¦јЇ¶ЇМ¬ПФКѕ [0~100]
            public byte  bySubSwitchMode;//1~°ЧМмЈ¬2~НнЙП
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_AOTOSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //КµјКЙъР§ёщѕЭДЬБ¦јЇ¶ЇМ¬ПФКѕ [0~100] КэЧйПВ±к±нКѕФ¤ЦГµгєЕ1Ў«8 ЈЁ0Ў«7 Па¶ФУ¦Ј©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;
            public NET_ITC_ICR_AOTOSWITCH_PARAM struICRAutoSwitch;
            public NET_ITC_ICR_MANUALSWITCH_PARAM struICRManualSwitch;
            public NET_ITC_ICR_TIMESWITCH_PARAM struICRTimeSwitch;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRCFG
        {
            public uint dwSize;
            public byte bySwitchType;//1~ЧФ¶ЇЗР»»Ј¬2~КЦ¶ЇЗР»» ,3~¶ЁК±ЗР»» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_ITC_ICR_PARAM_UNION uICRParam;
        }

        //2013-07-09 ТміЈґ¦Ан
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_HANDLEEXCEPTION
        {
            public uint dwHandleType; //ТміЈґ¦Ан,ТміЈґ¦Ан·ЅКЅµД"»т"Ѕб№ы
	        /*0x00: ОЮПмУ¦*/
	        /*0x01: јаКУЖчЙПѕЇёж*/
	        /*0x02: ЙщТфѕЇёж*/
	        /*0x04: ЙПґ«ЦРРД*/
	        /*0x08: ґҐ·ў±ЁѕЇКдіцЈЁјМµзЖчКдіцЈ©*/
	        /*0x10: ґҐ·ўJPRGЧҐНјІўЙПґ«Email*/
	        /*0x20: ОЮПЯЙщ№в±ЁѕЇЖчБЄ¶Ї*/
	        /*0x40: БЄ¶ЇµзЧУµШНј(ДїЗ°Ц»УРPCNVRЦ§іЦ)*/
	        /*0x200: ЧҐНјІўЙПґ«FTP*/  
            public byte byEnable; //0Ў«І»ЖфУГЈ¬1Ў«ЖфУГ
            public byte byRes;
            public ushort wDuration;//іЦРшК±јд(µҐО»/s)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_EXCEPTIONOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutTriggered;//ґҐ·ўКдіцНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_HANDLEEXCEPTION[] struSnapExceptionType; 
            //КэЧйµДГїёцФЄЛШ¶ј±нКѕТ»ЦЦТміЈЈ¬КэЧй0- УІЕМіцґн,1-НшПЯ¶П,2-IP µШЦ·іеН», 3-іµјмЖчТміЈ, 4-РЕєЕµЖјмІвЖчТміЈ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIGCOORDINATE
        {
            public ushort wTopLeftX; /*ПЯИ¦ЧуЙПЅЗєбЧш±кЈЁ2ёцЧЦЅЪЈ©*/
            public ushort wTopLeftY; /*ПЯИ¦ЧуЙПЅЗЧЭЧш±кЈЁ2ёцЧЦЅЪЈ©*/
            public ushort wWdith; /*ПЯИ¦їн¶ИЈЁ2ёцЧЦЅЪЈ©*/
            public ushort wHeight; /*ПЯИ¦ёЯ¶ИЈЁ2ёцЧЦЅЪЈ©*/
        }

        public enum PROVINCE_CITY_IDX
        {
	        ANHUI_PROVINCE             = 0,              //°І»Х
	        AOMEN_PROVINCE             = 1,              //°ДГЕ
	        BEIJING_PROVINCE           = 2,              //±±ѕ©
	        CHONGQING_PROVINCE         = 3,              //ЦШЗм
	        FUJIAN_PROVINCE            = 4,              //ёЈЅЁ
	        GANSU_PROVINCE             = 5,              //ёКЛа
	        GUANGDONG_PROVINCE         = 6,              //№г¶«
	        GUANGXI_PROVINCE           = 7,              //№гОч
	        GUIZHOU_PROVINCE           = 8,              //№уЦЭ
	        HAINAN_PROVINCE            = 9,              //єЈДП
	        HEBEI_PROVINCE             = 10,             //єУ±±
	        HENAN_PROVINCE             = 11,             //єУДП
	        HEILONGJIANG_PROVINCE      = 12,             //єЪБъЅ­
	        HUBEI_PROVINCE             = 13,             //єю±±
	        HUNAN_PROVINCE             = 14,             //єюДП
	        JILIN_PROVINCE             = 15,             //јЄБЦ
	        JIANGSU_PROVINCE           = 16,             //Ѕ­ЛХ
	        JIANGXI_PROVINCE           = 17,             //Ѕ­Оч
	        LIAONING_PROVINCE          = 18,             //БЙДю
	        NEIMENGGU_PROVINCE         = 19,             //ДЪГЙ№Е
	        NINGXIA_PROVINCE           = 20,             //ДюПД
	        QINGHAI_PROVINCE           = 21,             //ЗаєЈ
	        SHANDONG_PROVINCE          = 22,             //ЙЅ¶«
	        SHANXI_JIN_PROVINCE        = 23,             //ЙЅОч
	        SHANXI_SHAN_PROVINCE       = 24,             //ЙВОч
	        SHANGHAI_PROVINCE          = 25,             //ЙПєЈ
	        SICHUAN_PROVINCE           = 26,             //ЛДґЁ
	        TAIWAN_PROVINCE            = 27,             //МЁНе
	        TIANJIN_PROVINCE           = 28,             //МмЅт
	        XIZANG_PROVINCE            = 29,             //ОчІШ
	        XIANGGANG_PROVINCE         = 30,             //ПгёЫ
	        XINJIANG_PROVINCE          = 31,             //РВЅ®
	        YUNNAN_PROVINCE            = 32,             //ФЖДП
	        ZHEJIANG_PROVINCE          = 33              //ХгЅ­
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GEOGLOCATION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public int[] iRes; /*±ЈБф*/
            public uint dwCity; /*іЗКРЈ¬ПкјыPROVINCE_CITY_IDX */
        }

        //іЎѕ°ДЈКЅ
        public enum SCENE_MODE
        {
	        UNKOWN_SCENE_MODE   = 0,            //ОґЦЄіЎѕ°ДЈКЅ
	        HIGHWAY_SCENE_MODE  = 1,            //ёЯЛЩіЎѕ°ДЈКЅ
	        SUBURBAN_SCENE_MODE = 2,            //ЅјЗшіЎѕ°ДЈКЅ(±ЈБф)
	        URBAN_SCENE_MODE    = 3,            //КРЗшіЎѕ°ДЈКЅ
	        TUNNEL_SCENE_MODE   = 4             //ЛнµАіЎѕ°ДЈКЅ(±ЈБф)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VTPARAM
        {
            public uint dwSize;
            public byte byEnable;  /* КЗ·сК№ДЬРйДвПЯИ¦Ј¬0-І»К№УГЈ¬1-К№УГ*/
            public byte byIsDisplay; /* КЗ·сПФКѕРйДвПЯИ¦Ј¬0-І»ПФКѕЈ¬1-ПФКѕ*/
            public byte byLoopPos; //НнјдґҐ·ўПЯИ¦µДЖ«ПтЈє0-ПтЙПЈ¬1-ПтПВ
            public byte bySnapGain; /*ЧҐЕДФцТж*/
            public uint dwSnapShutter; /*ЧҐЕДїмГЕЛЩ¶И*/
            public NET_DVR_TRIGCOORDINATE struTrigCoordinate; //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TRIGCOORDINATE[] struRes;
            public byte byTotalLaneNum;/*КУЖµґҐ·ўµДіµµАКэ1*/
            public byte byPolarLenType; /*Ж«ХсѕµАаРНЈ¬0ЈєІ»јУЖ«ХсѕµЈ»1ЈєјУК©ДНµВЖ«ХсѕµЎЈ*/
            public byte	byDayAuxLightMode; /*°ЧМмёЁЦъХХГчДЈКЅЈ¬0ЈєОЮёЁЦъХХГчЈ»1ЈєLEDµЖХХГчЈ»2ЈєЙБ№вµЖХХГч*/
            public byte	byLoopToCalRoadBright; /*УГТФјЖЛгВ·ГжББ¶ИµДіµµА(РйДвПЯИ¦)*/
            public byte	byRoadGrayLowTh; /*В·ГжББ¶ИµНгРЦµіхКј»ЇЦµ1*/
            public byte	byRoadGrayHighTh; /*В·ГжББ¶ИёЯгРЦµіхКј»ЇЦµ140*/
            public ushort wLoopPosBias; /*НнјдґҐ·ўПЯИ¦О»ТЖ30*/
            public uint dwHfrShtterInitValue; /*Б¬РшНјПсЖШ№вК±јдµДіхКјЦµ2000*/
            public uint dwSnapShtterInitValue; /*ЧҐЕДНјПсЖШ№вК±јдµДіхКјЦµ500*/
            public uint dwHfrShtterMaxValue; /*Б¬РшНјПсЖШ№вК±јдµДЧоґуЦµ20000*/
            public uint dwSnapShtterMaxValue; /*ЧҐЕДНјПсЖШ№вК±јдµДЧоґуЦµ1500*/
            public uint dwHfrShtterNightValue; /*НнјдБ¬РшНјПсЖШ№вК±јдµДЙиЦГЦµ3000*/
            public uint dwSnapShtterNightMinValue; /*НнјдЧҐЕДНјПсЖШ№вК±јдµДЧоРЎЦµ3000*/
            public uint dwSnapShtterNightMaxValue; /*НнјдЧҐЕДНјПсЖШ№вК±јдµДЧоґуЦµ5000*/
            public uint dwInitAfe; /*ФцТжµДіхКјЦµ200*/
            public uint dwMaxAfe; /*ФцТжµДЧоґуЦµ400*/
            public ushort wResolutionX;/* Йи±ёµ±З°·Ц±жВКїн*/
            public ushort wResolutionY;/* Йи±ёµ±З°·Ц±жВКёЯ*/
            public uint dwGainNightValue; /*НнјдФцТжЈ¬Д¬ИПЦµ70*/
            public uint dwSceneMode; /*іЎѕ°ДЈКЅЈ¬ ПкјыSCENE_MODE */
            public uint dwRecordMode; /*ВјПс±кЦѕЈє0-І»ВјПсЈ¬1-ВјПс*/
            public NET_DVR_GEOGLOCATION struGeogLocation; /*µШЦ·О»ЦГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigFlag; /*ґҐ·ў±кЦѕЈ¬0-іµН·ґҐ·ўЈ»1-іµОІґҐ·ўЈ»2-іµН·/іµОІ¶јґҐ·ў*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigSensitive;  /*ґҐ·ўБйГф¶ИЈ¬1-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPENABLECFG
        {
            public uint dwSize;
            public byte byPlateEnable;//КЗ·сЦ§іЦіµЕЖК¶±рЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   //±ЈБф
            public byte byFrameFlip;   //НјПсКЗ·с·­ЧЄ 0-І»·­ЧЄЈ¬1-·­ЧЄ
            public ushort wFlipAngle;    //НјПс·­ЧЄЅЗ¶И 0,90,180,270
            public ushort wLightPhase;   //ПаО»Ј¬ИЎЦµ·¶О§[0, 360]
            public byte byLightSyncPower;  //КЗ·сРЕєЕµЖµзФґН¬ІЅЈ¬0-І»Н¬ІЅЈ»1-Н¬ІЅ
            public byte byFrequency;		//РЕєЕЖµВК
            public byte byUploadSDEnable;  //КЗ·сЧФ¶ЇЙПґ«SDНјЖ¬Ј¬0-·сЈ»1-КЗ
            public byte byPlateMode; //К¶±рДЈКЅІОКэ:0-КУЖµґҐ·ў,1-НвІїґҐ·ў
            public byte byUploadInfoFTP; //КЗ·сЙПґ«ЧҐЕДёЅјУРЕПўµЅFTPЈ¬0-·сЈ¬1-КЗ
            public byte byAutoFormatSD; //КЗ·сЧФ¶ЇёсКЅ»ЇSDїЁЈ¬0-·сЈ¬1-КЗ
            public ushort wJpegPicSize; //JpegНјЖ¬ґуРЎ[64-8196]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        /*ftpЙПґ«ІОКэ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FTPCFG
        {
            public uint dwSize;
            public uint dwEnableFTP;			/*КЗ·сЖф¶ЇftpЙПґ«№¦ДЬ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFTPIP;				/*ftp ·юОсЖч*/
            public uint dwFTPPort;				/*ftp¶ЛїЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*УГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/*ГЬВл*/
            public uint dwDirLevel;	/*0 = І»К№УГДїВјЅб№№Ј¬Ц±ЅУ±ЈґжФЪёщДїВј,1 = К№УГ1ј¶ДїВј,2=К№УГ2ј¶ДїВј*/
            public ushort wTopDirMode;	/* Т»ј¶ДїВјЈ¬0x1 = К№УГЙи±ёГы,0x2 = К№УГЙи±ёєЕ,0x3 = К№УГЙи±ёipµШЦ·Ј¬0x4=К№УГјаІвµг,0x5=К№УГК±јд(ДкФВ),0x=6ЧФ¶ЁТе,0x7=ОҐ№жАаРН,0x8=·ЅПт,0x9=µШµг*/
            public ushort wSubDirMode;	/* ¶юј¶ДїВјЈ¬0x1 = К№УГНЁµАГы,0x2 = К№УГНЁµАєЕЈ¬,0x3=К№УГК±јд(ДкФВИХ),0x4=К№УГіµµАєЕ,0x=5ЧФ¶ЁТе,0x6=ОҐ№жАаРН,0x7=·ЅПт,0x8=µШµг*/
            public byte byEnableAnony; //ЖфУГДдГыЈ¬0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*їЙУГАґГьГыНјЖ¬µДПа№ШФЄЛШ */
        public const int PICNAME_ITEM_DEV_NAME = 1;		/*Йи±ёГы*/
        public const int PICNAME_ITEM_DEV_NO = 2;		/*Йи±ёєЕ*/
        public const int PICNAME_ITEM_DEV_IP = 3;		/*Йи±ёIP*/
        public const int PICNAME_ITEM_CHAN_NAME = 4;	/*НЁµАГы*/
        public const int PICNAME_ITEM_CHAN_NO = 5;		/*НЁµАєЕ*/
        public const int PICNAME_ITEM_TIME = 6;		/*К±јд*/
        public const int PICNAME_ITEM_CARDNO = 7;		/*їЁєЕ*/
        public const int PICNAME_ITEM_PLATE_NO = 8;   /*іµЕЖєЕВл*/
        public const int PICNAME_ITEM_PLATE_COLOR = 9;   /*іµЕЖСХЙ«*/
        public const int PICNAME_ITEM_CAR_CHAN = 10;  /*іµµАєЕ*/
        public const int PICNAME_ITEM_CAR_SPEED = 11;  /*іµБѕЛЩ¶И*/
        public const int PICNAME_ITEM_CARCHAN = 12;  /*јаІвµг*/
        public const int PICNAME_ITEM_PIC_NUMBER = 13;  //НјЖ¬РтєЕ
        public const int PICNAME_ITEM_CAR_NUMBER = 14;  //іµБѕРтєЕ

        public const int PICNAME_ITEM_SPEED_LIMIT_VALUES = 15; //ПЮЛЩЦµ
        public const int PICNAME_ITEM_ILLEGAL_CODE = 16; //№ъ±кОҐ·ЁґъВл
        public const int PICNAME_ITEM_CROSS_NUMBER = 17; //В·їЪ±аєЕ
        public const int PICNAME_ITEM_DIRECTION_NUMBER = 18; //·ЅПт±аєЕ

        public const int PICNAME_MAXITEM = 15;
        //НјЖ¬ГьГы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	исКэЧй¶ЁТеОДјюГьГыµД№жФт */
            public byte byDelimiter;		/*·Цёф·ыЈ¬Т»°гОЄ'_'*/
        }


        //ГьГы№жФтЈє2013-09-27
        public const int PICNAME_ITEM_PARK_DEV_IP = 1;	/*Йи±ёIP*/
        public const int PICNAME_ITEM_PARK_PLATE_NO = 2;/*іµЕЖєЕВл*/
        public const int PICNAME_ITEM_PARK_TIME = 3;	/*К±јд*/
        public const int PICNAME_ITEM_PARK_INDEX = 4;   /*іµО»±аєЕ*/
        public const int PICNAME_ITEM_PARK_STATUS = 5;  /*іµО»ЧґМ¬*/

        //НјЖ¬ГьГыА©Х№ 2013-09-27
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	исКэЧй¶ЁТеОДјюГьГыµД№жФт */
            public byte byDelimiter;	            	/*·Цёф·ыЈ¬Т»°гОЄ'_'*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                      /*±ЈБф*/
        }

        /* ґ®їЪЧҐНјЙиЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CATCHPIC_PARA
        {
            public byte byStrFlag;	/*ґ®їЪКэѕЭїЄКј·ы*/
            public byte byEndFlag;	/*ЅбКш·ы*/
            public ushort wCardIdx;	/*їЁєЕПа¶ФЖрКјО»*/
            public uint dwCardLen;	/*їЁєЕі¤¶И*/
            public uint dwTriggerPicChans;	/*ЛщґҐ·ўµДНЁµАєЕЈ¬°ґО»Ј¬ґУµЪ1О»їЄКјјЖЈ¬јґ0x2±нКѕµЪТ»НЁµА*/
        }

        //DVRЧҐНјІОКэЕдЦГЈЁ»щПЯЈ©
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_JPEGPARA[] struJpegPara;	/*ГїёцНЁµАµДНјПсІОКэ*/
            public ushort wBurstMode;							/*ЧҐНј·ЅКЅ,°ґО»ЙиЦГ.0x1=±ЁѕЇКдИлґҐ·ўЈ¬0x2=ТЖ¶ЇХмІвґҐ·ў 0x4=232ґҐ·ўЈ¬0x8=485ґҐ·ўЈ¬0x10=НшВзґҐ·ў*/
            public ushort wUploadInterval;					/*НјЖ¬ЙПґ«јдёф(Гл)[0,65535]*/
            public NET_DVR_PICTURE_NAME 	struPicNameRule;	/* НјЖ¬ГьГы№жФт */
            public byte bySaveToHD;		/*КЗ·с±ЈґжµЅУІЕМ*/
            public byte byRes1;
            public ushort wCatchInterval;		/*ЧҐНјјдёф(єБГл)[0,65535]*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs232Cfg;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs485Cfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwTriggerPicTimes;	/* ГїёцНЁµАТ»ґОґҐ·ўЕДХХґОКэ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAlarmInPicChanTriggered; /*±ЁѕЇґҐ·ўЧҐЕДНЁµА,°ґО»ЙиЦГЈ¬ґУµЪ1О»їЄКј*/
        }

        //ЧҐЕДґҐ·ўЗлЗуЅб№№(±ЈБф)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUALSNAP
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SPRCFG    
        {
            public uint dwSize; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHJC_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDefaultCHN; /*Йи±ёФЛРРКЎ·ЭµДєєЧЦјтРґ*/
            public byte byPlateOSD;    /*0:І»·ўЛНіµЕЖІКЙ«Нј,1:·ўЛНіµЕЖІКЙ«Нј*/
            public byte bySendJPEG1;   /*0-І»ґ«ЛНЅьѕ°JPEGНј,1-ґ«ЛНЅьѕ°JPEGНј*/
            public byte bySendJPEG2;   /*0-І»ґ«ЛНФ¶ѕ°JPEGНј,1-ґ«ЛНФ¶ѕ°JPEGНј*/
            public ushort wDesignedPlateWidth;   /*іµЕЖЙијЖїн¶И*/
            public byte byTotalLaneNum;  /*К¶±рµДіµµАКэ*/
            public byte byRes1;      /*±ЈБф*/
            public ushort wRecognizedLane;  /*К¶±рµДіµµАєЕЈ¬°ґО»±нКѕЈ¬bit0±нКѕіµµА1КЗ·сК¶±рЈ¬0-І»К¶±рЈ¬1-К¶±р*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANERECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect;  /*іµµАК¶±рЗшУт*/
            public uint dwRecogMode;  /*К¶±рµДАаРНЈ¬
	        bit0-±іПтК¶±рЈє0-ХэПтіµЕЖК¶±рЈ¬1-±іПтК¶±р(ОІЕЖК¶±р) Ј» 
		    bit1-ґуіµЕЖК¶±р»тРЎіµЕЖК¶±рЈє0-РЎіµЕЖК¶±рЈ¬1-ґуіµЕЖК¶±р Ј»
		    bit2-іµЙнСХЙ«К¶±рЈє0-І»ІЙУГіµЙнСХЙ«К¶±рЈ¬ФЪ±іПтК¶±р»тРЎіµЕЖК¶±рК±ЅыЦ№ЖфУГЈ¬1-іµЙнСХЙ«К¶±рЈ»
		    bit3-Е©УГіµК¶±рЈє0-І»ІЙУГЕ©УГіµК¶±рЈ¬1-Е©УГіµК¶±рЈ» 
		    bit4-ДЈєэК¶±рЈє0-І»ІЙУГДЈєэК¶±рЈ¬1-ДЈєэК¶±рЈ»
		    bit5-ЦЎ¶ЁО»»тіЎ¶ЁО»Јє0-ЦЎ¶ЁО»Ј¬1-іЎ¶ЁО»Ј»
		    bit6-ЦЎК¶±р»тіЎК¶±рЈє0-ЦЎК¶±рЈ¬1-іЎК¶±рЈ» 
		    bit7-НнЙП»т°ЧМмЈє0-°ЧМмЈ¬1-НнЙП */
            public byte bySendPRRaw;       	//КЗ·с·ўЛНФ­НјЈє0-І»·ўЛНЈ¬1-·ўЛН 
            public byte bySendBinImage;  	//КЗ·с·ўЛНіµЕЖ¶юЦµНјЈє0-І»·ўЛНЈ¬1-·ўЛН 
            public byte byDelayCapture;  //СУК±ЧҐЕДїШЦЖ,µҐО»ЈєЦЎ
            public byte byUseLED;    //К№УГLEDїШЦЖЈ¬0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLCCFG
        {
            public uint dwSize;
            public byte byPlcEnable;	//КЗ·сЖфУГіµЕЖББ¶ИІ№іҐЈЁД¬ИПЖфУГЈ©Јє0-№Ш±ХЈ¬1-ЖфУГ 
            public byte byPlateExpectedBright;	//іµЕЖµДФ¤ЖЪББ¶ИЈЁД¬ИПЦµ50Ј©, ·¶О§[0, 100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±ЈБф 
            public byte byTradeoffFlash;     //КЗ·сїјВЗЙБ№вµЖµДУ°Пм: 0 - ·с;  1 - КЗ(Д¬ИП); 
	        //К№УГЙБ№вµЖІ№№вК±, Из№ыїјВЗјхИхЙБ№вµЖµДББ¶ИФцЗїР§У¦, ФтРиТЄЙиОЄ1;·сФтОЄ0
            public byte byCorrectFactor;     //ѕАХэПµКэ, ·¶О§[0, 100], Д¬ИПЦµ50 (ФЪtradeoff_flashЗР»»К±,»ЦёґД¬ИПЦµЈ©
            public ushort wLoopStatsEn;  //КЗ·сёГПЯИ¦µДББ¶ИЈ¬°ґО»±нКѕЈ¬0-І»НіјЖЈ¬1-НіјЖ
            public byte byPlcBrightOffset;// іµЕЖББ¶ИІ№іҐБйГф¶И(РйДвПЯИ¦ДЈКЅЖрР§)Ј¬ИЎЦµ·¶О§1~100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICESTATECFG
        {
            public uint dwSize;
            public ushort wPreviewNum; //Ф¤ААБ¬ЅУёцКэ
            public ushort wFortifyLinkNum; //Іј·АБ¬ЅУёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struPreviewIP;  //Ф¤ААµДУГ»§IPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struFortifyIP; //Іј·АБ¬ЅУµДУГ»§IPµШЦ·
            public uint dwVideoFrameRate;	//ЦЎВКЈє0-И«Ії; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
            public byte byResolution;  	//·Ц±жВК0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5ЈЁ±ЈБфЈ©,16-VGAЈЁ640*480Ј©, 17-UXGAЈЁ1600*1200Ј©, 18-SVGA ЈЁ800*600Ј©,19-HD720pЈЁ1280*720Ј©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte bySnapResolution;  	//ЧҐЕД·Ц±жВК0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5ЈЁ±ЈБфЈ©,16-VGAЈЁ640*480Ј©, 17-UXGAЈЁ1600*1200Ј©, 18-SVGA ЈЁ800*600Ј©,19-HD720pЈЁ1280*720Ј©,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte byStreamType; //ґ«КдАаРНЈє0-ЦчВлБчЈ»1-ЧУВлБч
            public byte byTriggerType; //ґҐ·ўДЈКЅЈє0-КУЖµґҐ·ўЈ»1-ЖХНЁґҐ·ў
            public uint dwSDVolume;  //SDїЁИЭБї
            public uint dwSDFreeSpace; //SDїЁКЈУаїХјд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DRIVECHAN_NUM * MAX_COIL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDetectorState;  //іµјмЖчЧґМ¬Јє0-ОґК№УГЈ»1-ХэіЈЈ»2-ТміЈ
            public byte byDetectorLinkState; //іµјмЖчБ¬ЅУЧґМ¬Јє0-ОґБ¬ЅУЈ»1-Б¬ЅУ
            public byte bySDStatus;    //SDїЁЧґМ¬ 0Ј­»о¶ЇЈ»1Ј­РЭГЯЈ»2Ј­ТміЈЈ¬3-ОЮsdїЁ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFortifyLevel; //Іј·АµИј¶Ј¬0-ОЮЈ¬1-Т»µИј¶ЈЁёЯЈ©Ј¬2-¶юµИј¶ЈЁЦРЈ©Ј¬3-ИэµИј¶ЈЁµНЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSTEPOLICECFG
        {
            public uint dwSize;
            public uint dwDistance;//ПЯИ¦ѕаАл,µҐО»cmЈ¬ИЎЦµ·¶О§[0,20000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SIGNALLIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLightChan;	//РЕєЕµЖНЁµАєЕ
            public byte byCapSpeed;//±кЦѕПЮЛЩЈ¬µҐО»km/hЈ¬ИЎЦµ·¶О§[0,255]
            public byte bySpeedLimit;//ПЮЛЩЦµЈ¬µҐО»km/hЈ¬ИЎЦµ·¶О§[0,255]
            public byte byTrafficDirection;//іµБч·ЅПтЈ¬0-УЙ¶«ПтОчЈ¬1-УЙОчПт¶«Ј¬2-УЙДППт±±Ј¬3-УЙ±±ПтДП
            public byte byRes1; //±ЈБф
            public ushort wLoopPreDist;        /*ґҐ·ўСУіЩѕаАл Ј¬µҐО»Јє·ЦГЧ*/
            public ushort wTrigDelay;             /*ґҐ·ўУІСУК±К±јд Ј¬µҐО»ЈєєБГл*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЧЦЅЪ
        }
        /***************************** end *********************************************/
        public const int IPC_PROTOCOL_NUM = 50;  //ipc Р­ТйЧоґуёцКэ

        //Р­ТйАаРН
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE
        {
            public uint dwType;               /*ipcР­ТйЦµ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Р­ТйГиКцЧЦ¶О*/
        }

        //Р­ТйБР±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST
        {    
            public uint dwSize; 
            public uint dwProtoNum;           /*УРР§µДipcР­ТйКэДї*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IPC_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struProto;   /*УРР§µДipcР­Тй*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_ALERTLINE_NUM = 8; //ЧоґуѕЇЅдПЯМхКэ	
        
        //ФЅЅзХмІвІйСЇМхјю
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRAVERSE_PLANE_SEARCHCOND
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struVcaTraversePlane;  //ґ©ФЅѕіЅзГжІОКэ
            public uint dwPreTime;   /*ЦЗДЬ±ЁѕЇМбЗ°К±јд µҐО»:Гл*/
            public uint dwDelayTime; /*ЦЗДЬ±ЁѕЇСУіЩК±јд µҐО»:Гл*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        } 

        public const int MAX_INTRUSIONREGION_NUM = 8; //ЧоґуЗшУтКэКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INTRUSION_SEARCHCOND  
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTRUSIONREGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_INTRUSION[] struVcaIntrusion; //ИлЗЦЗшУт
            public uint dwPreTime;   /*ЦЗДЬ±ЁѕЇМбЗ°К±јд µҐО»:Гл*/
            public uint dwDelayTime; /*ЦЗДЬ±ЁѕЇСУіЩК±јд µҐО»:Гл*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }


        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_AREA_SMARTSEARCH_COND_UNION
        {  
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;  //Ѕб№№Меі¤¶И
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope; //ХмІвЗшУт 0-96О»±нКѕ64РРЈ¬№ІУР96*64ёцРЎєкїйЈ¬1-КЗТЖ¶ЇХмІвЗшУтЈ¬0-·ЗТЖ¶ЇХмІвЗшУт 
            [FieldOffsetAttribute(0)]
            public NET_DVR_TRAVERSE_PLANE_SEARCHCOND struTraversPlaneCond; //ФЅЅзХмІв
            [FieldOffsetAttribute(0)]
            public NET_DVR_INTRUSION_SEARCHCOND struIntrusionCond; //ЗшУтИлЗЦ
        }

        //ЦЗДЬЛСЛчІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_PARAM
        {
            public byte byChan;					//НЁµАєЕ
            public byte bySearchCondType; //ЦЗДЬІйХТБЄєПМеNET_DVR_AREA_SMARTSEARCH_COND_UNIONµДЛчТэ     
	        /*0-ТЖ¶ЇХмІвЗшУт Ј¬1-ФЅЅзХмІвЈ¬ 2-ЗшУтИлЗЦ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struStartTime;		//ВјПсїЄКјµДК±јд
            public NET_DVR_TIME struEndTime;		//ВјПсНЈЦ№µДК±јд
            public NET_DVR_AREA_SMARTSEARCH_COND_UNION uSmartSearchCond;  //ЦЗДЬІйХТМхјю
            public byte bySensitivity;   			//ТЖ¶ЇХмІвЛСЛчБйГф¶И,1	>80%  2 40%~80%  3 1%~40%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
    
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_RET
        {
            public NET_DVR_TIME struStartTime;	//ТЖ¶ЇХмІв±ЁѕЇїЄКјµДК±јд
            public NET_DVR_TIME struEndTime;   //КВјюНЈЦ№µДК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPSAN ОДјюДїВјІйХТ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_PARAM
        {
            public NET_DVR_IPADDR  struIP;     // IPSAN IPµШЦ·
            public ushort wPort;      // IPSAN  ¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectory;  // ·µ»ШµДОДјюДїВј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVRЙи±ёІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName; //DVRГыіЖ
            public uint dwDVRID;				//DVR ID,УГУЪТЈїШЖч //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;		//КЗ·сС­»·ВјПс,0:І»КЗ; 1:КЗ
            //ТФПВІ»їЙёьёД
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber; //РтБРєЕ
            public uint dwSoftwareVersion;			//Инјю°ж±ѕєЕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwSoftwareBuildDate;			//ИнјюЙъіЙИХЖЪ,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;		    //DSPИнјю°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwDSPSoftwareBuildDate;		// DSPИнјюЙъіЙИХЖЪ,0xYYYYMMDD
            public uint dwPanelVersion;				// З°Гж°е°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public uint dwHardwareVersion;	// УІјю°ж±ѕ,ёЯ16О»КЗЦч°ж±ѕ,µН16О»КЗґО°ж±ѕ
            public byte byAlarmInPortNum;		//DVR±ЁѕЇКдИлёцКэ
            public byte byAlarmOutPortNum;		//DVR±ЁѕЇКдіцёцКэ
            public byte byRS232Num;			//DVR 232ґ®їЪёцКэ
            public byte byRS485Num;			//DVR 485ґ®їЪёцКэ 
            public byte byNetworkPortNum;		//НшВзїЪёцКэ
            public byte byDiskCtrlNum;			//DVR УІЕМїШЦЖЖчёцКэ
            public byte byDiskNum;				//DVR УІЕМёцКэ
            public byte byDVRType;				//DVRАаРН, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				//DVR НЁµАёцКэ
            public byte byStartChan;			//ЖрКјНЁµАєЕ,АэИзDVS-1,DVR - 1
            public byte byDecordChans;			//DVR ЅвВлВ·Кэ
            public byte byVGANum;				//VGAїЪµДёцКэ 
            public byte byUSBNum;				//USBїЪµДёцКэ
            public byte byAuxoutNum;			//ёЁїЪµДёцКэ
            public byte byAudioNum;			//УпТфїЪµДёцКэ
            public byte byIPChanNum;			//ЧоґуКэЧЦНЁµАКэ µН8О»Ј¬ёЯ8О»јыbyHighIPChanNum 
            public byte byZeroChanNum;			//БгНЁµА±аВлёцКэ
            public byte bySupport;        //ДЬБ¦Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦЈ¬
            //bySupport & 0x1, ±нКѕКЗ·сЦ§іЦЦЗДЬЛСЛч
            //bySupport & 0x2, ±нКѕКЗ·сЦ§іЦ±ё·Э
            //bySupport & 0x4, ±нКѕКЗ·сЦ§іЦС№ЛхІОКэДЬБ¦»сИЎ
            //bySupport & 0x8, ±нКѕКЗ·сЦ§іЦ¶аНшїЁ
            //bySupport & 0x10, ±нКѕЦ§іЦФ¶іМSADP
            //bySupport & 0x20, ±нКѕЦ§іЦRaidїЁ№¦ДЬ
            //bySupport & 0x40, ±нКѕЦ§іЦIPSANЛСЛч
	        //bySupport & 0x80, ±нКѕЦ§іЦrtp over rtsp
            public byte byEsataUseage;		//EsataµДД¬ИПУГНѕЈ¬0-Д¬ИП±ё·ЭЈ¬1-Д¬ИПВјПс
            public byte byIPCPlug;			//0-№Ш±ХјґІејґУГЈ¬1-ґтїЄјґІејґУГ
            public byte byStorageMode;		//0-ЕМЧйДЈКЅ,1-ґЕЕМЕд¶о, 2ійЦЎДЈКЅ
            public byte bySupport1;		//ДЬБ¦Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦ
	        //bySupport1 & 0x1, ±нКѕКЗ·сЦ§іЦsnmp v30
	        //bySupport1 & 0x2, Ц§іЦЗш·Ц»Ш·ЕєНПВФШ
	        //bySupport1 & 0x4, КЗ·сЦ§іЦІј·АУЕПИј¶	
	        //bySupport1 & 0x8, ЦЗДЬЙи±ёКЗ·сЦ§іЦІј·АК±јд¶ОА©Х№
	        //bySupport1 & 0x10, ±нКѕКЗ·сЦ§іЦ¶аґЕЕМКэЈЁі¬№э33ёцЈ©
	        //bySupport1 & 0x20, ±нКѕКЗ·сЦ§іЦrtsp over http	
            public ushort wDevType;//Йи±ёРНєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEV_TYPE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevTypeName;//Йи±ёРНєЕГыіЖ 
            public byte bySupport2; //ДЬБ¦јЇА©Х№Ј¬О»УлЅб№ыОЄ0±нКѕІ»Ц§іЦЈ¬1±нКѕЦ§іЦ
	        //bySupport2 & 0x1, ±нКѕКЗ·сЦ§іЦА©Х№µДOSDЧЦ·ыµюјУ(ЦХ¶ЛєНЧҐЕД»ъА©Х№Зш·Ц)
            public byte byAnalogAlarmInPortNum; //ДЈДв±ЁѕЇКдИлёцКэ
            public byte byStartAlarmInNo;    //ДЈДв±ЁѕЇКдИлЖрКјєЕ
            public byte byStartAlarmOutNo;  //ДЈДв±ЁѕЇКдіцЖрКјєЕ
            public byte byStartIPAlarmInNo;  //IP±ЁѕЇКдИлЖрКјєЕ  0-ОЮР§
            public byte byStartIPAlarmOutNo; //IP±ЁѕЇКдіцЖрКјєЕ 0-ОЮР§
            public byte byHighIPChanNum;     //КэЧЦНЁµАёцКэЈ¬ёЯ8О» 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±ЈБф
        }

        public const int MAX_ZEROCHAN_NUM = 16;
        //БгНЁµАС№ЛхЕдЦГІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZEROCHANCFG
        {
            public uint dwSize;			    //Ѕб№№і¤¶И
            public byte byEnable;			//0-НЈЦ№БгНЁµА±аВлЈ¬1-±нКѕЖфУГБгНЁµА±аВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±ЈБф
            public uint dwVideoBitrate; 	/*КУЖµВлВК 0-±ЈБф 1-16K(±ЈБф) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
                                             * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
                                             * 23-2048K
                                             * ЧоёЯО»(31О»)ЦГіЙ1±нКѕКЗЧФ¶ЁТеВлБч, 0-30О»±нКѕВлБчЦµ(MIN-32K MAX-8192K) */
            public uint dwVideoFrameRate;	//ЦЎВК 0-И«Ії; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
                                            //V2.0ФцјУ14-15, 15-18, 16-22;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;        //±ЈБф
        }

        //БгНЁµАЛх·ЕІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZERO_ZOOMCFG
        {
            public uint dwSize;			    //Ѕб№№і¤¶И
            public NET_VCA_POINT struPoint;	//»­ГжЦРµДЧш±кµг
            public byte byState;		 //ПЦФЪµДЧґМ¬Ј¬0-ЛхРЎЈ¬1-·Еґу  
            public byte byPreviewNumber;       //Ф¤ААКэДї,0-1»­Гж,1-4»­Гж,2-9»­Гж,3-16»­Гж ёГІОКэЦ»¶Б
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPreviewSeq;//»­ГжНЁµАРЕПў ёГІОКэЦ»¶Б
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				//±ЈБф 
        }

        public const int DESC_LEN_64 = 64;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG
        {
            public uint dwSize;			//Ѕб№№і¤¶И
            public byte byEnable;			//0-ЅыУГSNMPЈ¬1-±нКѕЖфУГSNMP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//±ЈБф
            public ushort wVersion;		//snmp °ж±ѕ  v1 = 1, v2 =2, v3 =3Ј¬Йи±ёДїЗ°І»Ц§іЦ v3
            public ushort wServerPort; //snmpПыПўЅУКХ¶ЛїЪЈ¬Д¬ИП 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity; //¶Б№ІН¬МеЈ¬Чо¶а31,Д¬ИП"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;//Рґ№ІН¬Ме,Чо¶а31 ЧЦЅЪ,Д¬ИП "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;	//ЧФПЭЦч»ъipµШЦ·ГиКцЈ¬Ц§іЦIPV4 IPV6єНУтГыГиКц    
            public ushort wTrapHostPort;   //trapЦч»ъ¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPv3_USER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;			// УГ»§Гы				
            public byte bySecLevel;	//°ІИ«ј¶±р 1-ОЮРЈСй 2-ОЮКЪИЁРЈСй 3-КЪИЁРЈСй
            public byte byAuthtype;	//ИПЦ¤АаРН 0-MD5ИПЦ¤ 1-SHAИПЦ¤ 2: none
            public byte byPrivtype;	//0: DES; 1: AES; 2: none;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuthpass;	//ИПЦ¤ГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivpass;	//јУГЬГЬВл
        }
        
        //snmpv30
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG_V30
        {
            public uint dwSize;			//Ѕб№№і¤¶И
            public byte byEnableV1;		//0-ЅыУГSNMP V1Ј¬1-±нКѕЖфУГSNMP V1
            public byte byEnableV2;		//0-ЅыУГSNMP V2Ј¬1-±нКѕЖфУГSNMP V2
            public byte byEnableV3;		//0-ЅыУГSNMP V3Ј¬1-±нКѕЖфУГSNMP V3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wServerPort;					//snmpПыПўЅУКХ¶ЛїЪЈ¬Д¬ИП 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity;		//¶Б№ІН¬МеЈ¬Чо¶а31,Д¬ИП"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;		//Рґ№ІН¬Ме,Чо¶а31 ЧЦЅЪ,Д¬ИП "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;		//ЧФПЭЦч»ъipµШЦ·ГиКцЈ¬Ц§іЦIPV4 IPV6єНУтГыГиКц    
            public ushort wTrapHostPort;					// trapЦч»ъ¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       
            public NET_DVR_SNMPv3_USER struRWUser;    // ¶БРґУГ»§
            public NET_DVR_SNMPv3_USER struROUser;    // Ц»¶БУГ»§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
        }
        
        public const int PROCESSING = 0;    //ХэФЪґ¦Ан
        public const int PROCESS_SUCCESS = 100;   //№эіМНкіЙ
        public const int PROCESS_EXCEPTION = 400;   //№эіМТміЈ
        public const int PROCESS_FAILED = 500;   //№эіМК§°Ь
        public const int PROCESS_QUICK_SETUP_PD_COUNT = 501; //Т»јьЕдЦГЦБЙЩ3їйУІЕМ

        public const int SOFTWARE_VERSION_LEN = 48;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO
        {
            public NET_DVR_IPADDR struIP;     // Йи±ёIPµШЦ·
            public ushort wPort;      // Йи±ё¶ЛїЪєЕ
            public ushort wFactoryType;   // Йи±ёі§јТАаРН
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = SOFTWARE_VERSION_LEN)]
            public string chSoftwareVersion;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chSerialNo; // РтБРєЕ
            public ushort wEncCnt;   // ±аВлНЁµАёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;		// MAC µШЦ·
            public NET_DVR_IPADDR struSubDVRIPMask;   // DVR IPµШЦ·СЪВл
            public NET_DVR_IPADDR struGatewayIpAddr;  // Нш№Ш
            public NET_DVR_IPADDR struDnsServer1IpAddr;	/* УтГы·юОсЖч1µДIPµШЦ· */
            public NET_DVR_IPADDR struDnsServer2IpAddr;	/* УтГы·юОсЖч2µДIPµШЦ· */
            public byte byDns;
            public byte byDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ±ЈБфЧЦЅЪ
        }

        public const int MAX_SADP_NUM = 256;  //ЛСЛчµЅЙи±ёЧоґуКэДї
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO_LIST
        {
            public uint dwSize;   //  Ѕб№№ґуРЎ
            public ushort wSadpNum;   // ЛСЛчµЅЙи±ёКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SADP_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SADPINFO[] struSadpInfo; // ЛСЛч
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADP_VERIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string chPassword;
            public NET_DVR_IPADDR struOldIP;
            public ushort wOldPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************** end *********************************************/

        /*******************************±ё·ЭЅб№№ begin********************************/
        //»сИЎ±ё·ЭЙи±ёРЕПўЅУїЪ¶ЁТе
        public const int DESC_LEN_32 = 32;   //ГиКцЧЦі¤¶И
        public const int MAX_NODE_NUM = 256;  //ЅЪµгёцКэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DESC_NODE
        { 
            public int iValue; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; //ГиКцЧЦ¶О 
            public uint dwFreeSpace; //»сИЎґЕЕМБР±нЧЁУГ,µҐО»ОЄM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			  //±ЈБф  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKABILITY_LIST
        { 
            public uint dwSize;            //Ѕб№№і¤¶И
            public uint dwNodeNum;		 //ДЬБ¦ЅбµгёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //ГиКцІОКэ  
        }

        //±ё·ЭЅш¶ИБР±н
        public const int BACKUP_SUCCESS            =    100;  //±ё·ЭНкіЙ
        public const int BACKUP_CHANGE_DEVICE      =    101;  //±ё·ЭЙи±ёТСВъЈ¬ёь»»Йи±ёјМРш±ё·Э

        public const int BACKUP_SEARCH_DEVICE      =    300;  //ХэФЪЛСЛч±ё·ЭЙи±ё
        public const int BACKUP_SEARCH_FILE        =    301;  //ХэФЪЛСЛчВјПсОДјю
        public const int BACKUP_SEARCH_LOG_FILE    =    302;  //ХэФЪЛСЛчИХЦѕОДјю

        public const int BACKUP_EXCEPTION		   =    400;  //±ё·ЭТміЈ
        public const int BACKUP_FAIL			   =	500;  //±ё·ЭК§°Ь

        public const int BACKUP_TIME_SEG_NO_FILE   =    501;  //К±јд¶ОДЪОЮВјПсОДјю
        public const int BACKUP_NO_RESOURCE        =    502;  //ЙкЗлІ»µЅЧКФґ
        public const int BACKUP_DEVICE_LOW_SPACE   =    503;  //±ё·ЭЙи±ёИЭБїІ»Чг
        public const int BACKUP_DISK_FINALIZED     =    504;  //їМВј№вЕМ·вЕМ
        public const int BACKUP_DISK_EXCEPTION     =    505;  //їМВј№вЕМТміЈ
        public const int BACKUP_DEVICE_NOT_EXIST   =    506;  //±ё·ЭЙи±ёІ»ґжФЪ
        public const int BACKUP_OTHER_BACKUP_WORK  =    507;  //УРЖдЛы±ё·ЭІЩЧчФЪЅшРР
        public const int BACKUP_USER_NO_RIGHT      =    508;  //УГ»§Г»УРІЩЧчИЁПЮ
        public const int BACKUP_OPERATE_FAIL       =    509;  //ІЩЧчК§°Ь
        public const int BACKUP_NO_LOG_FILE        =    510;  //УІЕМЦРОЮИХЦѕ

        //±ё·Э№эіМЅУїЪ¶ЁТе
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_NAME_PARAM
        {
            public uint dwFileNum;   //ОДјюёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_FILE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FINDDATA_V30[] struFileList; //ОДјюБР±н
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;   //±ё·ЭґЕЕМГиКц
            public byte byWithPlayer;      //КЗ·с±ё·ЭІҐ·ЕЖч
            public byte byContinue;    /*КЗ·сјМРш±ё·Э 0І»јМРш 1јМРш*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_TIME_PARAM
        {
            public int lChannel;        //°ґК±јд±ё·ЭµДНЁµА
            public NET_DVR_TIME struStartTime;   //±ё·ЭµДЖрКјК±јд
            public NET_DVR_TIME struStopTime;    //±ё·ЭµДЦХЦ№К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;     //±ё·ЭґЕЕМГиКц
            public byte byWithPlayer;               //КЗ·с±ё·ЭІҐ·ЕЖч
            public byte byContinue;                 //КЗ·сјМРш±ё·Э 0І»јМРш 1јМРш
            public byte byDrawFrame;			     //0 І»ійЦЎ  1 ійЦЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					 // ±ЈБфЧЦЅЪ 
        }
        /********************************* end *******************************************/
        public enum COMPRESSION_ABILITY_TYPE
        {
            COMPRESSION_STREAM_ABILITY = 0, //ВлБчС№ЛхАаРН
	        MAIN_RESOLUTION_ABILITY = 1,	//ЦчВлБчС№Лх·Ц±жВК
	        SUB_RESOLUTION_ABILITY  = 2,	//ЧУВлБчС№Лх·Ц±жВК
	        EVENT_RESOLUTION_ABILITY =  3,  //КВјюС№ЛхІОКэ·Ц±жВК
	        FRAME_ABILITY = 4,				//ЦЎВКДЬБ¦
	        BITRATE_TYPE_ABILITY = 5,		//О»ВКАаРНДЬБ¦
	        BITRATE_ABILITY = 6,			//О»ВКЙППЮ
	        THIRD_RESOLUTION_ABILITY = 7,   //ИэВлБчС№Лх·Ц±жВК
	        STREAM_TYPE_ABILITY = 8,        //ВлБчАаРН
	        PIC_QUALITY_ABILITY = 9,         //НјПсЦКБї
	        INTERVAL_BPFRAME_ABILITY = 10,  //BPЦЎјдёф
	        VIDEO_ENC_ABILITY = 11,           //КУЖµ±аВлДЬБ¦
	        AUDIO_ENC_ABILITY = 12,           //ТфЖµ±аВлДЬБ¦
	        VIDEO_ENC_COMPLEXITY_ABILITY = 13, //КУЖµ±аВлёґФУ¶ИДЬБ¦
	        FORMAT_ABILITY = 14, //·вЧ°ёсКЅДЬБ¦
        }

        //ДЬБ¦БР±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ABILITY_LIST
        { 
            public uint dwAbilityType;	//ДЬБ¦АаРН COMPRESSION_ABILITY_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±ЈБфЧЦЅЪ
            public uint dwNodeNum;		//ДЬБ¦ЅбµгёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[]  struDescNode;  //ГиКцІОКэ  
        }

        public const int MAX_ABILITYTYPE_NUM = 12;   //ЧоґуДЬБ¦По

        // С№ЛхІОКэДЬБ¦БР±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_ABILITY
        { 
            public uint dwSize;            //Ѕб№№і¤¶И
            public uint dwAbilityNum;		//ДЬБ¦АаРНёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ABILITYTYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ABILITY_LIST[] struAbilityNode; //ГиКцІОКэ  
        }

        //ДЈКЅA 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEA
        {
            public byte byStartMonth;	// їЄКјФВ ґУ1їЄКј
            public byte byStartDay;		// їЄКјИХ ґУ1їЄКј
            public byte byEndMonth;		// ЅбКшФВ 
            public byte byEndDay;		// ЅбКшИХ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEB
        {
            public byte byStartMonth;	// ґУ1їЄКј
            public byte byStartWeekNum;	// µЪјёёцРЗЖЪ ґУ1їЄКј 
            public byte byStartWeekday;	// РЗЖЪјё
            public byte byEndMonth;		// ґУ1їЄКј
            public byte byEndWeekNum;	// µЪјёёцРЗЖЪ ґУ1їЄКј 
            public byte byEndWeekday;	// РЗЖЪјё
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEC
        {
            public ushort wStartYear;		// Дк
            public byte byStartMon;		// ФВ
            public byte byStartDay;		// ИХ
            public ushort wEndYear;		// Дк
            public byte byEndMon;		// ФВ
            public byte byEndDay;		// ИХ
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_HOLIDATE_UNION
        {	
            //БЄєПМеґуРЎ 12ЧЦЅЪ
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwSize;
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEA	struModeA;	// ДЈКЅA
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEB	struModeB;	// ДЈКЅB
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEC	struModeC;	// ДЈКЅC
        }

        public enum HOLI_DATE_MODE
        {
            HOLIDATE_MODEA = 0,
            HOLIDATE_MODEB,
            HOLIDATE_MODEC
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM
        {
            public byte byEnable;			// КЗ·сЖфУГ
            public byte byDateMode;			// ИХЖЪДЈКЅ 0-ДЈКЅA 1-ДЈКЅB 2-ДЈКЅC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±ЈБфЧЦЅЪ
            public NET_DVR_HOLIDATE_UNION uHolidate;	// јЩИХИХЖЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;	// јЩИХГыіЖ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±ЈБфЧЦЅЪ
        }

        public const int MAX_HOLIDAY_NUM = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM_CFG
        {
            public uint dwSize;			// Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HOLIDAY_PARAM[] struHolidayParam;	// јЩИХІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфІОКэ
        }

        //јЩИХ±ЁѕЇґ¦Ан·ЅКЅ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_HANDLE
        {
            public uint dwSize;				// Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;	// Іј·АК±јд¶О
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_RECORD
        {
            public uint dwSize;
            public NET_DVR_RECORDDAY struRecDay;     // ВјПсІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched; // ВјПсК±јд¶О
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //  ±ЈБфЧЦЅЪ
        }

        public const int MAX_LINK_V30 = 128;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LINK
        {
            public NET_DVR_IPADDR  struIP;     // їН»§¶ЛIP
            public int lChannel;   // НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINK_STATUS
        {
            public uint dwSize;      // Ѕб№№МеґуРЎ
            public ushort wLinkNum;    // Б¬ЅУµДКэДї
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LINK[] struOneLink;   // Б¬ЅУµДїН»§¶ЛРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // ±ЈБфЧЦЅЪ
        }

        public const int MAX_BOND_NUM = 2;

                //µҐBONDINGНшїЁЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ONE_BONDING
        {
            public byte byMode;
            public byte byUseDhcp;
            public byte byMasterCard;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.I1)]
            public byte[] byBond;
            public NET_DVR_ETHERNET_V30 struEtherNet;
            public NET_DVR_IPADDR struGatewayIpAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //BONDINGНшїЁЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETWORK_BONDING
        {  
            public uint dwSize;  
            public byte byEnable;
            public byte byNum;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BOND_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_BONDING[] struOneBond;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }


        //ґЕЕМЕд¶о
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA 
        {
            public byte byQuotaType;	 // ґЕЕМЕд¶оАаРН,1 - °ґИЭБї 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // ±ЈБфЧЦЅЪ
            public uint dwHCapacity;     // ·ЦЕдµДґЕЕМИЭБїёЯ32О» µҐО»MB
            public uint dwLCapacity;     // ·ЦЕдµДґЕЕМИЭБїµН32О» µҐО»MB
            public uint dwHUsedSpace;    // ТСК№УГµДґЕЕМґуРЎёЯ32О» µҐО»MB
            public uint dwLUsedSpace;    // ТСК№УГµДґЕЕМґуРЎµН32О» µҐО»MB
            public byte byQuotaRatio;    //	·ЦЕдµДґЕЕМ±ИАэ,µҐО»:%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA_CFG
        {
            public uint dwSize;         // Ѕб№№МеґуРЎ
            public NET_DVR_DISK_QUOTA struPicQuota;    //  НјЖ¬Ед¶о
            public NET_DVR_DISK_QUOTA struRecordQuota;    //  ВјПсЕд¶о
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMING_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ¶ЁК±ЧҐНјНјЖ¬ЦКБї
            public uint dwPicInterval; //¶ЁК±ЧҐНјК±јдјдёф,µҐО»s   1-1s 2-2s 3-3s 4-4s 5-5s 
                                       //6-10m 7-30m 8-1h 9-12h 10-24h
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;    // °ґО»±нКѕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          // ±ЈБфЧЦЅЪ
        }

        public const int MAX_PIC_EVENT_NUM = 32;
        public const int MAX_ALARMIN_CAPTURE = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN_V40
        {
            public uint dwMaxRelCaptureChanNum;  //ЧоґуїЙґҐ·ўµД№ШБЄНЁµАКэ-Ц»¶БКфРФ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo; //ґҐ·ўµД№ШБЄЧҐНјНЁµАєЕЈ¬°ґЦµ±нКѕЈ¬ІЙУГЅфґХРНЕЕБР,0xffffffff±нКѕєуРшОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE_V40
        {
            public NET_DVR_JPEGPARA struJpegPara;   // КВјюЧҐНјНјЖ¬ЦКБї
            public uint dwPicInterval;   // КВјюЧҐНјК±јдјдёф  µҐО»ОЄГл 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struRelCaptureChan;   // КэЧйПВ±к 0 ТЖ¶ЇХмІвґҐ·ўЧҐНј 1 КУЖµХЪµІґҐ·ўЧҐНј 2 КУЖµ¶ЄК§ґҐ·ўЧҐНј,КэЧй3±нКѕPIR±ЁѕЇЧҐНјЈ¬КэЧй4±нКѕОЮПЯ±ЁѕЇЧҐНјЈ¬КэЧй5±нКѕєфѕИ±ЁѕЇЧҐНј,КэЧй6±нКѕЦЗДЬЧҐНј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struAlarmInCapture;    // ±ЁѕЇКдИлґҐ·ўЧҐНјЈ¬ПВ±к0 ґъ±н±ЁѕЇКдИл1 ТАґОАаНЖ
            public uint dwMaxGroupNum;  //Йи±ёЦ§іЦµДЧоґу±ЁѕЇКдИлЧйКэЈ¬ГїЧй16ёц±ЁѕЇКдИл
            public byte byCapTimes; //ЧҐНјХЕКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE
        {
            public NET_DVR_JPEGPARA  struJpegPara;   // КВјюЧҐНјНјЖ¬ЦКБї
            public uint dwPicInterval;  /*КВјюЧҐНјК±јдјдёф  µҐО»ОЄГл  1-1s 2-2s 3-3s 4-4s 5-5s 
                                             * 6-10m 7-30m 8-1h 9-12h 10-24h*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struRelCaptureChan; /* КэЧйПВ±к 0 ТЖ¶ЇХмІвґҐ·ўЧҐНј 1 КУЖµХЪµІґҐ·ўЧҐНј,
                                                                   * 2 КУЖµ¶ЄК§ґҐ·ўЧҐНј,КэЧй3±нКѕPIR±ЁѕЇЧҐНјЈ¬КэЧй4±нКѕОЮПЯ±ЁѕЇЧҐНјЈ¬
                                                                   * КэЧй5±нКѕєфѕИ±ЁѕЇЧҐНј,КэЧй6±нКѕЦЗДЬЧҐНјЈ¬ КэЧй7±нКѕИЛБіХмІв*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struAlarmInCapture;  //±ЁѕЇКдИлґҐ·ўЧҐНјЈ¬ПВ±к0 ґъ±н±ЁѕЇКдИл1 ТАґОАаНЖ
            public byte byCapTimes; //ЧҐНјХЕКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG_V40
        {
            public uint dwSize;               //Ѕб№№Меі¤¶И
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE_V40 struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG
        {
            public uint dwSize;         // Ѕб№№МеґуРЎ
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_DAY
        {
            public byte byAllDayCapture;	// КЗ·сИ«МмЧҐНј
            public byte byCaptureType;		// ЧҐНјАаРНЈє0-¶ЁК±ЧҐНјЈ¬1-ТЖ¶ЇХмІвЧҐНјЈ¬2-±ЁѕЇЧҐНјЈ¬3-ТЖ¶ЇХмІв»т±ЁѕЇЧҐНјЈ¬4-ТЖ¶ЇХмІвєН±ЁѕЇЧҐНјЈ¬6-ЦЗДЬ±ЁѕЇЧҐНј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_SCHED
        {
            public NET_DVR_SCHEDTIME struCaptureTime;        // ЧҐНјК±јд¶О
            public byte byCaptureType;       // ЧҐНјАаРНЈє0-¶ЁК±ЧҐНјЈ¬1-ТЖ¶ЇХмІвЧҐНјЈ¬2-±ЁѕЇЧҐНјЈ¬3-ТЖ¶ЇХмІв»т±ЁѕЇЧҐНјЈ¬4-ТЖ¶ЇХмІвєН±ЁѕЇЧҐНјЈ¬6-ЦЗДЬ±ЁѕЇЧҐНј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // ±ЈБфЧЦЅЪ
        }

        //НЁµАЧҐНјјЖ»®
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHED_CAPTURECFG
        {
            public uint dwSize;     //Ѕб№№Ме
            public byte byEnable;	//КЗ·сЧҐНј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_DAY[] struCaptureDay;//И«МмЧҐНјјЖ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struCaptureSched;//К±јд¶ОЧҐНјІј·АјЖ»®
            public NET_DVR_CAPTURE_DAY	struCaptureHoliday;	//јЩИХЧҐНјјЖ»®
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struHolidaySched;	//К±јд¶ОјЩИХЧҐНјІј·АјЖ»®
            public uint dwRecorderDuration;	//ЧҐНј±ЈґжЧоі¤К±јд 0xffffffff±нКѕёГЦµОЮР§ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			//±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_TEST_PARAM
        {
            public uint dwSize;              //Ѕб№№ґуРЎ
            public int lCardIndex;         //НшїЁЛчТэ
            public uint dwInterval;         //Йи±ёЙПґ«БчБїК±јдјдёф, µҐО»:100ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_INFO
        {
            public uint dwSize;             //Ѕб№№ґуРЎ
            public uint dwSendFlowSize;     //·ўЛНБчБїґуРЎ,µҐО»kbps
            public uint dwRecvFlowSize;     //ЅУКХБчБїґуРЎ,µҐО»kbps
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //±ЈБф 
        }

        //ВјПс±кЗ©
        public const int LABEL_NAME_LEN = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_LABEL
        {
            public uint dwSize;					// Ѕб№№МеґуРЎ
            public NET_DVR_TIME struTimeLabel;			// ±кЗ©µДК±јд 
            public byte byQuickAdd;				// КЗ·сїмЛЩМнјУ їмЛЩМнјУК±±кЗ©ГыіЖОЮР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				// ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±кЗ©µДГыіЖ і¤¶ИОЄ40ЧЦЅЪ  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±ЈБфЧЦЅЪ
        }

        public const int LABEL_IDENTIFY_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LABEL_IDENTIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_IDENTIFY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelIdentify;    // 64ЧЦЅЪ±кК¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;               // ±ЈБфЧЦЅЪ
        }

        public const int MAX_DEL_LABEL_IDENTIFY = 20;// ЙѕіэµДЧоґу±кЗ©±кК¶ёцКэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEL_LABEL_PARAM
        {
            public uint dwSize;       // Ѕб№№МеґуРЎ
            public byte byMode;   // °ґО»±нКѕ,0x01±нКѕ°ґ±кК¶Йѕіэ
            public byte byRes1;
            public ushort wLabelNum;      // ±кЗ©КэДї   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEL_LABEL_IDENTIFY, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LABEL_IDENTIFY[] struIndentify; // ±кЗ©±кК¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //±ЈБфЧЦЅЪ    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOD_LABEL_PARAM
        {
            public NET_DVR_LABEL_IDENTIFY struIndentify; //ТЄРЮёДµД±кЗ©±кК¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//РЮёДєуµД±кЗ©ГыіЖ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				
        }

        //±кЗ©ЛСЛчЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_LABEL
        {
            public uint dwSize;          // Ѕб№№МеґуРЎ
            public int lChannel;		// ІйХТµДНЁµА
            public NET_DVR_TIME	struStartTime;	// їЄКјК±јд
            public NET_DVR_TIME	struStopTime;	// ЅбКшК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//  ВјПс±кЗ©ГыіЖ Из№ы±кЗ©ГыіЖОЄїХЈ¬ФтЛСЛчЖрЦ№К±јдЛщУР±кЗ©
            public byte byDrawFrame;		//0:І»ійЦЎЈ¬1ЈєійЦЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }

        //±кЗ©РЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINDLABEL_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ±кЗ©ГыіЖ
            public NET_DVR_TIME struTimeLabel;		// ±кЗ©К±јд
            public NET_DVR_LABEL_IDENTIFY struLabelIdentify; // ±кЗ©±кК¶
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// ±ЈБфЧЦЅЪ
        }

        public const int CARDNUM_LEN_V30 = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_PARAM
        {
            public uint dwSize;        //Ѕб№№МеґуРЎ 
            public int lChannel;       //НЁµАєЕ
            public byte byFileType;   /* ІйХТµДНјЖ¬АаРН:0¶ЁК±ЧҐНј1 ТЖ¶ЇХмІвЧҐНј 2 ±ЁѕЇЧҐНј3  ±ЁѕЇ | ТЖ¶ЇХмІвЧҐНј 4 ±ЁѕЇ & ТЖ¶ЇХмІвЧҐНј
                                       * 6 КЦ¶ЇЧҐНј ,9-ЦЗДЬНјЖ¬,10- PIR±ЁѕЇЈ¬11- ОЮПЯ±ЁѕЇЈ¬12- єфѕИ±ЁѕЇ,0xa Ф¤ААК±ЅШНјЈ¬0xd ИЛБіХмІв, 
                                       * 0xe ФЅЅзХмІвЈ¬0xf ИлЗЦЗшУтХмІвЈ¬0x10 іЎѕ°±дёьХмІв, 0x11-Йи±ё±ѕµШ»Ш·ЕК±ЅШНј, 0x12-ЦЗДЬХмІвЈ¬
                                       * 0xff- И«ІїАаРН 2013-07-16*/  
            public byte byNeedCard;     //КЗ·сРиТЄїЁєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // ±ЈБфЧЦЅЪ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;     // їЁєЕ
            public NET_DVR_TIME  struStartTime;//ІйХТНјЖ¬µДїЄКјК±јд
            public NET_DVR_TIME  struStopTime;// ІйХТНјЖ¬µДЅбКшК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     // ±ЈБфЧЦЅЪ
        }

        public const int PICTURE_NAME_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PICTURE_NAME_LEN)]
            public string sFileName;//НјЖ¬Гы
            public NET_DVR_TIME struTime;//НјЖ¬µДК±јд
            public uint dwFileSize;//НјЖ¬µДґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = CARDNUM_LEN_V30)]
            public string sCardNum;	//їЁєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		//  ±ЈБфЧЦЅЪ
        }

        public const int MAX_RECORD_PICTURE_NUM = 50;   //Чоґу±ё·ЭНјЖ¬ХЕКэ  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_PICTURE_PARAM
        {
            public uint dwSize;         // Ѕб№№МеґуРЎ   
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FIND_PICTURE[] struPicture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;
            public byte byWithPlayer;
            public byte byContinue;    /*КЗ·сјМРш±ё·Э 0І»јМРш 1јМРш*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_LIMIT
        {	
            public uint dwSize;           //Ѕб№№МеґуРЎ
            public uint dwChannel;        //НЁµАєЕ
            public byte byCompressType;   //ґэ»сИЎµДС№ЛхІОКэАаРН1,ЦчВлБч2,ЧУВлБч3,КВјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±ЈБф
            public NET_DVR_COMPRESSIONCFG_V30  struCurrentCfg; //µ±З°С№ЛхІОКэЕдЦГ
        }

        public const int STEP_READY      = 0;    //Чј±ёЙэј¶
        public const int STEP_RECV_DATA  = 1;    //ЅУКХЙэј¶°ьКэѕЭ
        public const int STEP_UPGRADE    = 2;    //Йэј¶ПµНі
        public const int STEP_BACKUP     = 3;    //±ё·ЭПµНі
        public const int STEP_SEARCH     = 255;  //ЛСЛчЙэј¶ОДјю

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_EFFECT
        {
            public uint dwBrightValue;      //ББ¶И[0,255]
            public uint dwContrastValue;    //¶Ф±И¶И[0,255]
            public uint dwSaturationValue;  //±ҐєН¶И[0,255]
            public uint dwHueValue;         //Й«µч[0,255]
            public uint dwSharpness;		  //Ис¶И[0,255]
            public uint dwDenoising;		  //ИҐФл[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_INPUT_EFFECT
        {	
            public uint dwSize;				//Ѕб№№МеґуРЎ
            public ushort wEffectMode;        //ДЈКЅ 0-±кЧј 1-КТДЪ 2-Их№в 3-КТНв  255-ЧФ¶ЁТе
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //±ЈБф
            public NET_DVR_VIDEO_EFFECT struVideoEffect;	//КУЖµР§№ыІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPARA_V40
        {
            public uint dwChannel;			// НЁµАєЕ
            public uint dwVideoParamType;  	// КУЖµІОКэАаРН 0-ББ¶И 1-¶Ф±И¶И 2-±ҐєН¶И 3-Й«¶И 4-Ис¶И 5-ИҐФл
            public uint dwVideoParamValue;  //¶ФУ¦µДКУЖµІОКэЦµЈ¬·¶О§ТАѕЭДЬБ¦јЇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFAULT_VIDEO_COND
        {
            public uint dwSize;			// Ѕб№№МеґуРЎ
            public uint dwChannel;		// НЁµАєЕ
            public uint dwVideoMode;	// ДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENCODE_JOINT_PARAM
        {
            public uint dwSize;			// Ѕб№№МеґуРЎ
            public byte byJointed;		//  0 Г»УР№ШБЄ 1 ТСѕ­№ШБЄ
            public byte byDevType;		// ±»№ШБЄµДЙи±ёАаРН  1 ґъ±нЦЗДЬЙи±ё
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		// ±ЈБфЧЦЅЪ
            public NET_DVR_IPADDR	struIP;			// №ШБЄµД±»ИЎБчЙи±ёIPµШЦ·
            public ushort wPort;			// №ШБЄµД±»ИЎБчЙи±ё¶ЛїЪєЕ
            public ushort wChannel;		// №ШБЄµД±»ИЎБчЙи±ёНЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CHAN_WORKSTATUS
        {
            public byte byJointed;				// 0-Г»УР№ШБЄ  1-ТСѕ­№ШБЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR	struIP;					// №ШБЄµДИЎБчЙи±ёIPµШЦ·
            public ushort wPort;					// №ШБЄµДИЎБчЙи±ё¶ЛїЪєЕ
            public ushort wChannel;				// №ШБЄµДИЎБчЙи±ёНЁµАєЕ
            public byte byVcaChanStatus;		// 0 - ОґЖфУГ 1 - ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_DEV_WORKSTATUS
        {
            public uint dwSize;			// Ѕб№№МеґуРЎ
            public byte byDeviceStatus;	// Йи±ёµДЧґМ¬0 - ХэіЈ№¤Чч 1- І»ХэіЈ№¤Чч
            public byte byCpuLoad;		// CPUК№УГВК0-100 ·Ц±рґъ±нК№УГ°Щ·ЦВК
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VCA_CHAN_WORKSTATUS[] struVcaChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM_V40
        {
            /*ёчёцЧУґ°їЪ¶ФУ¦ЅвВлНЁµАЛщ¶ФУ¦µДЅвВлЧУПµНіµДІЫО»єЕ(¶ФУЪКУЖµЧЫєПЖЅМЁЦРЅвВлЧУПµНіУРР§)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            //ПФКѕґ°їЪЛщЅвКУЖµ·Ц±жВКЈ¬1-D1,2-720P,3-1080PЈ¬Йи±ё¶ЛРиТЄёщѕЭґЛ//·Ц±жВКЅшРРЅвВлНЁµАµД·ЦЕдЈ¬Из1·ЦЖБЕдЦГіЙ1080PЈ¬ФтЙи±ё»б°С4ёцЅвВлНЁ
            //µА¶ј·ЦЕдёшґЛЅвВлНЁµА
            public byte byDecResolution;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG_V40
        {        
            public uint dwSize; 
            public byte byAudio;			/*ТфЖµКЗ·сїЄЖф*/
            public byte byAudioWindowIdx;      /*ТфЖµїЄЖфЧУґ°їЪ*/
            public byte byVgaResolution;      /*·Ц±жВКЈ¬ґУДЬБ¦јЇ»сИЎ*/
            public byte byVedioFormat;         /*1:NTSC,2:PALЈ¬0-NULL*/
            public uint dwWindowMode;		/*»­ГжДЈКЅЈ¬ДЬБ¦јЇ»сИЎ*/       
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*ёчёцЧУґ°їЪ№ШБЄµДЅвВлНЁµА*/
            public byte byEnlargeStatus;          /*КЗ·сґ¦УЪ·ЕґуЧґМ¬Ј¬0ЈєІ»·ЕґуЈ¬1Јє·Еґу*/
            public byte byEnlargeSubWindowIndex;//·ЕґуµДЧУґ°їЪєЕ
            public byte byScale; /*ПФКѕДЈКЅЈ¬0---ХжКµПФКѕЈ¬1---Лх·ЕПФКѕ( Хл¶ФBNC )*/
	        /*Зш·Ц№ІУГМеЈ¬0-КУЖµЧЫєПЖЅМЁДЪІїЅвВлЖчПФКѕНЁµАЕдЦГЈ¬1-ЖдЛыЅвВлЖчПФКѕНЁµАЕдЦГ*/
            public byte byUnionType;
	
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
		        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM_V40 struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM_V40 struNotVideoPlatform;
	        }
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_V6SUBSYSTEMPARAM
        {
            public byte bySerialTrans;//КЗ·сНёґ«Ј¬0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_V6PSUBSYSTEMARAM_GET = 1501;//»сИЎV6ЧУПµНіЕдЦГ
        public const int NET_DVR_V6PSUBSYSTEMARAM_SET = 1502;//ЙиЦГV6ЧУПµНіЕдЦГ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRECT_DEADPIXEL_PARAM
        {
            public uint dwSize;
            public uint dwCommand; //ГьБоЈє0-ЅшИл»µµгДЈКЅЈ¬1-МнјУ»µµгЈ¬2-±Јґж»µµгЈ¬3-НЛіц»µµг
            public uint dwDeadPixelX; //»µµгXЧш±к
            public uint dwDeadPixelY; //»µµгYЧш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        public const int MAX_REDAREA_NUM = 6;   //ЧоґуємВМµЖЗшУтёцКэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REDAREACFG
        {
            public uint dwSize;
            public uint dwCorrectEnable; //КЗ·сїЄЖфРЈХэ№¦ДЬЈ¬0-№Ш±ХЈ¬1-їЄЖф
            public uint dwCorrectLevel; //РЈХэј¶±рЈ¬1(РЈХэ¶ИЧоµН)-10(РЈХэ¶ИЧоёЯ),Д¬ИПОЄ5
            public uint dwAreaNum; //РЈХэЗшУтёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REDAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect; //РЈХэЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HISTORICDATACFG
        {
            public uint dwSize;
            public uint dwTotalNum;  //АъК·КэѕЭёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int INQUEST_MESSAGE_LEN  = 44;    //ЙуС¶ЦШµг±кјЗРЕПўі¤¶И
        public const int INQUEST_MAX_ROOM_NUM = 2;    //ЧоґуЙуС¶КТёцКэ
        public const int MAX_RESUME_SEGMENT   = 2;     //Ц§іЦН¬К±»ЦёґµДЖ¬¶ОКэДї

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM
        {
            public byte byRoomIndex;     //ЙуС¶КТ±аєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_MESSAGE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = INQUEST_MESSAGE_LEN)]
            public string sMessage; //ЦШµг±кјЗРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                     //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_DEVICE
        {
            public ushort wDeviceType;	//КэѕЭІЙјЇЙи±ёРНєЕ:0-ОЮ 1-ГЧАЦ 2-АШІК 3-УЕБ¦ 4-јСГЛ 5-УАїШЎў6-ЫвЙПЎў7-О¬ДЙЛ№ґп
            public ushort wDeviceAddr;	//КэѕЭІЙјЇЙи±ёµШЦ·	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_SENSOR_DEVICE[] struSensorDevice;
            public uint  dwSupportPro;      //Ц§іЦР­ТйАаРН,°ґО»±нКѕ, РВ°ж±ѕЧЯДЬБ¦јЇЈ¬І»ФЩА©Х№ґЛЧЦ¶О
							   //0x1:ГЧАЦ 0x2:АШІК 0x4:УЕБ¦
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szCDName;	//№вЕМГыіЖЈ¬µҐКТЛ«їМ№вЕМГыіЖКЗТ»СщµД
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uCalcMode
	        {
                [FieldOffsetAttribute(0)]
                public byte byBitRate;	// byCalcTypeОЄ0К±УРР§Ј¬(0-32Ўў1-48Ўў2-64Ўў3-80Ўў4-96Ўў5-128Ўў
								//6-160Ўў7-192Ўў8-224Ўў9-256Ўў10-320Ўў11-384Ўў12-448Ўў
								//13-512Ўў14-640Ўў15-768Ўў16-896З°16ёцЦµ±ЈБф)17-1024Ўў18-1280Ўў19-1536Ўў
								//20-1792Ўў21-2048Ўў22-3072Ўў23-4096Ўў24-8192
                [FieldOffsetAttribute(0)]
                public byte byInquestTime;  // byCalcTypeОЄ1К±УРР§Ј¬0-1РЎК±, 1-2РЎК±,2-3РЎК±,3-4РЎК±, 4-6РЎК±,5-8РЎК±
		                        //8-16РЎК±, 9-20РЎК±,10-22РЎК±,11-24РЎК±
	        }
            public byte byCalcType;			//їМВјјЖЛгАаРН0-°ґВлВК 1-°ґК±јд
            public byte byAutoDelRecord;	// КЗ·сЧФ¶ЇЙѕіэВјПсЈ¬0-І»ЙѕіэЈ¬јґЅбКшК±±ЈґжВјПс 1-Йѕіэ
            public byte byAlarmThreshold;		// ЙщТф±ЁѕЇ·§Цµ
            public byte byInquestChannelResolution;     //ЙуС¶НЁµА·Ц±жВКЈ¬0:720P  1:1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SYSTEM_INFO
        {
            public uint dwRecordMode;         //їМВјДЈКЅ:1 µҐКТЛ«їМДЈКЅ 2 µҐКТВЦїМДЈКЅ 3 Л«КТЛ«їМДЈКЅЈЁРЮёДРиТЄЦШЖфЙи±ёЈ©
            public uint  dwWorkMode;           //№¤ЧчДЈКЅ:0 ±кЧјДЈКЅ 1 НЁУГДЈКЅ(±ЈБфЈ¬ДїЗ°Ц»УР±кЧјДЈКЅ)
            public uint dwResolutionMode;     //Йи±ё·Ц±жВКЈ¬0:±кЗе 1:D1 2:720P 3:1080PЈЁёЯЗеЙуС¶»ъІ»УГґЛЧЦ¶ОЈ©
            public NET_DVR_INQUEST_SENSOR_INFO struSensorInfo;  //ОВКЄ¶Иґ«ёРЖчЕдЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_ROOM_INFO[] struInquestRoomInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_SEGMENT
        {
            public NET_DVR_TIME  struStartTime; //КВјюЖрКјК±јд
            public NET_DVR_TIME  struStopTime;  //КВјюЦХЦ№К±јд
            public byte byRoomIndex;         //ЙуС¶КТ±аєЕ,ґУ1їЄКј
            public byte byDriveIndex;        //їМВј»ъ±аєЕ,ґУ1їЄКј
            public ushort wSegmetSize;         //±ѕЖ¬¶ПµДґуРЎ, µҐО»M 
            public uint dwSegmentNo;         //±ѕЖ¬¶ПФЪ±ѕґОЙуС¶ЦРµДРтєЕ,ґУ1їЄКј 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_EVENT
        {
            public uint  dwResumeNum;       //Ри»ЦёґµДКВјюёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESUME_SEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_RESUME_SEGMENT[] struResumeSegment;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_DEVICE_VERSION
        {
            public byte byMainVersion;         /*»щПЯЦч°ж±ѕ.
								   0 : ОґЦЄ
								   1 : 8000ЙуС¶DVR
								       ґО°ж±ѕ: 1 : 8000HD-S
								   2 : 8100ЙуС¶DVR 
									   ґО°ж±ѕ: 1 : ЙуС¶81SNL
											   2 : ЙуС¶81SH
											   3 : ЙуС¶81SFH
								   3 : 8608ёЯЗеЙуС¶»ъNVR 
									   ґО°ж±ѕ: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
            public byte bySubVersion;          //»щПЯґО°ж±ѕ
            public byte byUpgradeVersion;      //Йэј¶°ж±ѕ,ОґЙэј¶ОЄ0
            public byte byCustomizeVersion;     //¶ЁЦЖ°ж±ѕ,·З¶ЁЦЖОЄ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_RAID_INFO 
        {
            public uint dwSize;   //Ѕб№№МеґуРЎ
            public byte byEnable;  //ґЕЕМRaidКЗ·сЅыУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYNCHRONOUS_IPC
        {
            public uint dwSize;    //Ѕб№№МеґуРЎ
            public byte byEnable;  //КЗ·сЖфУГЈєОЄЗ°¶ЛIPCН¬ІЅЙи±ёІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PASSWD
        {
            public uint dwSize;    //Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sOldPasswd;  //IPCµДѕЙГЬВлЈ¬ґ«ёшDVRИГDVRСйЦ¤
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sNewPasswd;  //IPCµДРВГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //НЁ№э»сИЎDVRµДНшВзЧґМ¬ЈєµҐО»bps
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DEVICE_NET_USING_INFO 
        {
            public uint dwSize;    //Ѕб№№МеґуРЎ
            public uint dwPreview;   //Ф¤АА
            public uint dwPlayback;  //»Ш·Е
            public uint dwIPCModule; //IPCЅУИл
            public uint dwNetDiskRW; //НшЕМ¶БРґ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //НЁ№эDVRЙиЦГЗ°¶ЛIPCµДIPµШЦ·
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_NETCFG
        {
            public uint dwSize;      //Ѕб№№МеґуРЎ
            public NET_DVR_IPADDR struIP;       //IPCµДIPµШЦ·
            public ushort wPort;       //IPCµД¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 126)]
            public string res;  
        }

        //°ґК±јдЛш¶Ё
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_LOCK
        {
            public uint dwSize;      //Ѕб№№МеґуРЎ
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            public uint dwChannel;        //НЁµАєЕ, 0xff±нКѕЛщУРНЁµА
            public uint dwRecordType;     //ВјПсАаРН:  0xffffffffЈ­И«ІїЈ¬0Ј­¶ЁК±ВјПсЈ¬1-ТЖ¶ЇХмІвЈ¬2Ј­±ЁѕЇґҐ·ўЈ¬3-±ЁѕЇґҐ·ў»тТЖ¶ЇХмІвЈ¬4-±ЁѕЇґҐ·ўєНТЖ¶ЇХмІвЈ¬5-ГьБоґҐ·ўЈ¬6-КЦ¶ЇВјПсЈ¬7-ЦЗДЬВјПс(Н¬ОДјюІйХТ)
            public uint dwLockDuration;   //Лш¶ЁіЦРшК±јд,µҐО»Гл,0xffffffff±нКѕУАѕГЛш¶Ё
            public NET_DVR_TIME_EX strUnlockTimePoint;	//јУЛшК±УРР§Ј¬µ±dwLockDurationІ»ОЄУАѕГЛш¶ЁК±Ј¬Лш¶ЁіЦРшµДК±јдµЅґЛК±јдµгѕНЧФ¶ЇЅвЛш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCK_RETURN
        {
            public uint dwSize;      //Ѕб№№МеґуРЎ
            public NET_DVR_TIME strBeginTime; 
            public NET_DVR_TIME strEndTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //67DVS
        //Ц¤КйПВФШАаРН
        public enum NET_SDK_UPLOAD_TYPE 
        {
            UPGRADE_CERT_FILE = 0, 
	        UPLOAD_CERT_FILE = 1,
	        TRIAL_CERT_FILE = 2,
            CONFIGURATION_FILE = 3
        }

        public enum NET_SDK_DOWNLOAD_TYPE
        {
	        NET_SDK_DOWNLOAD_CERT = 0,		//ПВФШЦ¤Кй
	        NET_SDK_DOWNLOAD_IPC_CFG_FILE = 1,//ПВФШIPCЕдЦГОДјю
            NET_SDK_DOWNLOAD_BASELINE_SCENE_PIC = 2, //ПВФШ»щЧјіЎѕ°НјЖ¬
	        NET_SDK_DOWNLOAD_VQD_ALARM_PIC = 3,       //ПВФШVQD±ЁѕЇНјЖ¬
            NET_SDK_DOWNLOAD_CONFIGURATION_FILE=4   //ПВФШЕдЦГОДјю
        }

        //ПВФШЧґМ¬
       public enum NET_SDK_DOWNLOAD_STATUS
       {
	        NET_SDK_DOWNLOAD_STATUS_SUCCESS = 1,	//ПВФШіЙ№¦
	        NET_SDK_DOWNLOAD_STATUS_PROCESSING,		//ХэФЪПВФШ
	        NET_SDK_DOWNLOAD_STATUS_FAILED,			//ПВФШК§°Ь
	        NET_SDK_DOWNLOAD_STATUS_UNKOWN_ERROR	//ОґЦЄґнОу 
       }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BONJOUR_CFG
        {
            public uint dwSize;				// Ѕб№№МеґуРЎ
            public byte byEnableBonjour;		// BonjourК№ДЬ 0 ЈєїЄЖф 1Јє№Ш±Х
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendlyName; 	// ·юОсГы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SOCKS_CFG
        {
            public uint dwSize;				// Ѕб№№МеґуРЎ
            public byte byEnableSocks;  		// К№ДЬ 0Јє№Ш±Х 1ЈєїЄЖф
            public byte byVersion;  			// SOCKS°ж±ѕ 4ЈєSOCKS4   5ЈєSOCKS5
            public ushort wProxyPort;				// ґъАн¶ЛїЪЈ¬Д¬ИП1080
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byProxyaddr;  	// ґъАнIPµШЦ·Ј¬їЙТФКЗУтГы
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; 	// УГ»§Гы SOCKSІЕУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;			// ГЬВлSOCKS5ІЕУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCAL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalAddr;  //І»К№УГsocksґъАнµДНш¶ОЈ¬ёсКЅОЄ"ip/netmask;ip/netmask;Ў­"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_QOS_CFG
        {
            public uint dwSize;
            public byte byManageDscp;   // №ЬАнКэѕЭµДDSCPЦµ [0-63]
            public byte byAlarmDscp;    // ±ЁѕЇКэѕЭµДDSCPЦµ [0-63]
            public byte byVideoDscp;    // КУЖµКэѕЭµДDSCPЦµ [0-63]Ј¬byFlagОЄ0К±Ј¬±нКѕТфКУЖµ
            public byte byAudioDscp;    // ТфЖµКэѕЭµДDSCPЦµ [0-63]Ј¬byFlagОЄ1К±УРР§
            public byte byFlag;			// 0ЈєТфКУЖµєПТ»Ј¬1ЈєТфКУЖµ·ЦїЄ
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HTTPS_CFG
        {
            public uint dwSize;
            public ushort wHttpsPort;		// HTTPS¶ЛїЪ
            public byte byEnable;		// К№ДЬ 0Јє№Ш±Х 1ЈєїЄЖф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Ц¤КйПа№Ш
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_COUNTRY_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCountry;  			//№ъјТґъєЕ CNµИ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byState;				//ЦЮ»тКЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocality;			//µШЗш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byOrganization;		//ЧйЦЇ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnit;				//µҐО»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byCommonName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmail;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_PARAM
        {
            public uint dwSize;
            public ushort wCertFunc; //Ц¤КйЦЦАаЈ¬0-802.1x,1-HTTPS
            public ushort wCertType; //Ц¤КйАаРНЈ¬0-CAЈ¬1-Certificate,2-ЛЅФїОДјю
            public byte byFileType; //Ц¤КйОДјюАаРНЈ¬0-PEM,1-PFX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        public const int UPLOAD_CERTIFICATE = 1; //ЙПґ«Ц¤Кй

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_INFO
        {
            public uint dwSize;
            public NET_DVR_CERT_PARAM struCertParam;	//Ц¤КйІОКэ
            public uint dwValidDays;   //УРР§МмКэЈ¬АаРНОЄЧФЗ©ГыК±УРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPasswd;   //ЛЅФїГЬВл
            public NET_DVR_CERT_NAME struCertName;    // Ц¤КйГыіЖ
            public NET_DVR_CERT_NAME struIssuerName;    // Ц¤Кй·ўРРХЯГыіЖЈЁЧФЗ©ГыЦ¤КйРЕПў»сИЎК±УРР§Ј©
            public NET_DVR_TIME_EX struBeginTime;   //Ц¤КйґґЅЁК±јдЈЁЧФЗ©ГыЦ¤КйРЕПў»сИЎК±УРР§Ј©
            public NET_DVR_TIME_EX struEndTime;   //Ц¤КйЅШЦ№К±јдЈЁЧФЗ©ГыЦ¤КйРЕПў»сИЎК±УРР§Ј©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] serialNumber;   //Ц¤Кй±кК¶ВлЈЁЧФЗ©ГыЦ¤КйРЕПў»сИЎК±УРР§Ј©
            public byte byVersion; 
            public byte byKeyAlgorithm;			//јУГЬАаРН 0-RSA  1-DSA
            public byte byKeyLen;				//јУГЬі¤¶И 0-512  1-1024Ўў 2-2048
            public byte bySignatureAlgorithm; //З©ГыЛг·ЁАаРНЈЁЧФЗ©ГыЦ¤КйРЕПў»сИЎК±УРР§Ј©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //channel record status
        //***НЁµАВјПсЧґМ¬*****//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANS_RECORD_STATUS
        {
            public byte byValid;       //КЗ·сУРР§
            public byte byRecord;      /*(Ц»¶Б)ВјПсАаРН, °ґО»±нКѕ:0: І»ФЪВјПсЈ»1ЈєФЪВјПс 2-їХПР 
						3-ОЮБ¬ЅУ 4-ОЮКдИлКУЖµ 5-ОґјУФШ 6-ґжµµЦР
							7-»Шґ«ЦР 8-УГ»§Гы»тГЬВлґн 9-ОґСйЦ¤
							10-ґжµµЦРєНВјПсЦР 11-ВјПс»Шґ«ЦРєНВјПсЦР*/
            public ushort wChannelNO;   //НЁµАєЕ
            public uint dwRelatedHD;  //№ШБЄґЕЕМ
            public byte byOffLineRecord;  //¶ПНшВјПс№¦ДЬ 0-№Ш±Х 1-їЄЖф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IP_ALARM_GROUP_NUM
        {
            public uint dwSize; 
            public uint dwIPAlarmInGroup;      //IPНЁµА±ЁѕЇКдИлЧйКэ
            public uint dwIPAlarmInNum;       //IPНЁµА±ЁѕЇКдИлёцКэ
            public uint dwIPAlarmOutGroup;     //IPНЁµА±ЁѕЇКдіцЧйКэ
            public uint dwIPAlarmOutNum;      //IPНЁµА±ЁѕЇКдіцёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }
        
        //****NVR end***//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_GROUP_RECORD_STATUS
        {
            public uint dwSize; //Ѕб№№МеґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANS_RECORD_STATUS[] struChanStatus; //Т»Чй64ёц
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG
        {
            public ushort wXCoordinate; /*ѕШРОЧуЙПЅЗЖрКјµгXЧш±к*/
            public ushort wYCoordinate; /*ѕШРОЧуЙПЅЗYЧш±к*/
            public ushort wWidth;       /*ѕШРОїн¶И*/
            public ushort wHeight;      /*ѕШРОёЯ¶И*/
        }

        /*ґ°їЪРЕПў*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputIdx;          /*КдИлФґЛчТэ*/
            public byte byLayerIdx;          /*НјІгЈ¬0ОЄЧоµЧІг*/
            public byte byTransparency; //НёГч¶ИЈ¬0Ў«100 
            public NET_DVR_RECTCFG  struWin;//ДїµДґ°їЪ(Па¶ФПФКѕЗЅ)
            public ushort wScreenHeight;//ґуЖБёЯ
            public ushort wScreenWidth;//ґуЖБїн
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLWINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENZOOM
        {
            public uint dwSize;
            public uint dwScreenNum;//ґуЖБєЕ
            public NET_DVR_POINT_FRAME struPointFrame;
            public byte byLayer;//НјІгєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2011-04-18
        /*ЙгПс»ъРЕПў,Чо¶а9999ёцЈ¬ґУ1їЄКј */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_CAMERAINFO
        {  
            public uint dwGlobalCamId;      /* camµДИ«ѕЦ±аєЕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName; /*camµДГыіЖ*/
            public uint dwMatrixId;          /*cam¶ФУ¦ѕШХуµД±аєЕ*/
            public uint dwLocCamId;         /*cam¶ФУ¦ѕШХуµДДЪІї±аєЕ*/ 
            public byte byValid;    /*КЗ·сУРР§Ј¬0-·сЈ¬1-КЗ*/
            public byte byPtzCtrl; /* КЗ·сїЙїШЈ¬0-·сЈ¬1-КЗ*/
            public byte byUseType; //*К№УГАаРНЈ¬0-І»ЧчОЄёЙПЯК№УГЈ¬1-BNCЈ¬2-SP3,3-V6№вПЛЈ¬4-ЖдЛы№вПЛ*/ 
            public byte byUsedByTrunk;//µ±З°К№УГЧґМ¬Ј¬0-Г»УР±»К№УГЈ¬1-±»ёЙПЯК№УГ 
            public byte byTrunkReq; /*ЙгПс»ъ·Ц±жВК,ТФD1ОЄµҐО»Јє1 - 1ёцD1Ј¬2- 2ёцD1Ј¬ЧчОЄёЙПЯК№УГК±Ј¬ЦёµДКЗёЙПЯµДґшїн*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struInstallTime;//°ІЧ°К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*УГНѕГиКц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  
        }

        /*јаКУЖчРЕПўЈ¬Чо¶а2048ёц*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MONITORINFO 
        {
            public uint dwGloalMonId; /*mon µДНіТ»±аєЕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sMonName;
            public uint dwMatrixId;  /*monЛщФЪѕШХуµД±аєЕ*/
            public uint dwLocalMonId; /*monµДДЪІї±аєЕ*/
            public byte byValid;    /*КЗ·сУРР§Ј¬0-·сЈ¬1-КЗ*/
            public byte byTrunkType; /*К№УГАаРНЈ¬0-І»ЧчОЄёЙПЯК№УГЈ¬1-BNCЈ¬2-SP3,3-V6№вПЛЈ¬4-ЖдЛы№вПЛ*/ 
            public byte byUsedByTrunk;//µ±З°К№УГЧґМ¬Ј¬0-Г»УР±»К№УГЈ¬1-±»ёЙПЯК№УГ 
            public byte byTrunkReq; /*·Ц±жВК, ТФD1ОЄµҐО»Јє1- 1ёцD1Ј¬2- 2ёцD1Ј¬ЧчОЄёЙПЯК№УГК±Ј¬ЦёµДКЗёЙПЯµДґшїн*/
            public NET_DVR_TIME struInstallTime;//°ІЧ°К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*УГНѕГиКц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_DIGITALMATRIX
        {
            public NET_DVR_IPADDR struAddress; /*Йи±ёОЄКэЧЦЙи±ёК±µДIPРЕПў*/
            public ushort wPort;
            public byte byNicNum; /*0 - eth0, 1 - eth1, їјВЗЛ«НшїЪИзєОНЁРЕјУИл°у¶ЁµДНшїЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_ANALOGMATRIX
        {
            public byte bySerPortNum;   /*Б¬ЅУµДґ®їЪєЕ*/
            public byte byMatrixSerPortType;/* ѕШХуЅУИлНш№ШµДґ®їЪУлДЈДвѕШХуµДјьЕМїЪ(јьЕМР­Тй)Б¬ЅУ»№КЗУлѕШХуНЁРЕїЪЈЁѕШХуР­ТйЈ©Б¬ЅУ Ј¬0 --- ѕШХуР­ТйНЁС¶їЪ 1 --- јьЕМНЁС¶їЪ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SINGLE_RS232 struRS232;	//232ґ®їЪІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_MATRIX_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_DIGITALMATRIX struDigitalMatrix;
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_ANALOGMATRIX struAnalogMatrix;
        }
        
        /*ѕШХуЕдЦГРЕПўЈ¬Чо¶а20ёц*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MATRIXINFO 
        {
            public uint dwSize;
            public uint dwMatrixId;  /*ѕШХу±аєЕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;
            public byte byCtrlType; /*ЦёНЁС¶·ЅКЅКЗґ®їЪНЁРЕ, »№КЗНшВзНЁРЕ*/
            public byte byProtocolType;/*ЙиЦГНЁРЕїШЦЖР­Тй*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   /*Ф¤Бф*/
            public NET_MATRIX_UNION struMatrixUnion;
            public uint dwMaxPortsIn; /*ѕШХуКдИлКэ*/
            public uint dwMaxPortsOut;/*ѕШХуКдіцКэ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;   /*µЗВјУГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;  /*µЗВјГЬВл*/        
            public NET_DVR_TIME struInstallTime;//°ІЧ°К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*УГНѕГиКц*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   /*Ф¤Бф*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMatrixNum;//Йи±ё·µ»ШµДѕШХуКэБї
            public IntPtr pBuffer;//ѕШХуРЕПў»єіеЗш
            public uint dwBufLen;//Лщ·ЦЕдЦёХлі¤¶ИЈ¬КдИлІОКэ
        }
 
        /*ґ®їЪЕдЦГРЕПў*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_UARTPARAM
        {	
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPortName;
            public ushort wUserId; /*УГ»§±аєЕЈ¬µ±Б¬ЅУЙи±ёОЄјьЕМК±Ј¬°у¶ЁТ»ёцУГ»§Ј¬УГУЪИЁПЮ№ЬАн*/
            public byte byPortType;    /*ґ®їЪАаРНЈ¬ИэЦЦ0-RS232/1-RS485/2-RS422*/
            public byte byFuncType; /*ґ®їЪБ¬ЅУµДЙи±ёµДАаРН0-їХПРЈ¬1-јьЕМЈ¬2-УГЧчНёГчНЁµА(485ґ®їЪІ»їЙЕдЦГіЙНёГчНЁµА),3-ДЈДвѕШХу*/     
            public byte byProtocolType;  /*ґ®їЪЦ§іЦµДР­ТйАаРН, µ±Б¬ЅУјьЕМЙи±ёК±РиТЄёГРЕПў,»сИЎјьЕМЦ§іЦР­ТйµД±аєЕј°ГиКц·ы*/
            public byte byBaudRate;
            public byte byDataBits;
            public byte byStopBits;   /*НЈЦ№О»*/
            public byte byParity;      /*РЈСй*/
            public byte byFlowCtrl;   /*БчїШЈ¬ИнјюБчїШЈ¬ОЮБчїШ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     /*Ф¤Бф*/
        }

        //Чо¶а256ёцУГ»§Ј¬1Ў«256
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERPARAM 
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public byte byRole;/*УГ»§ЅЗЙ«:0-№ЬАнФ±,1-ІЩЧчФ±Ј»Ц»УРТ»ёцПµНі№ЬАнФ±Ј¬255ёцІЩЧчФ±*/
            public byte byLevel;  /*НіТ»ј¶±рЈ¬УГУЪІЩЧчј¶±р№ЬАн,1- 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Чо¶а255ёцЧКФґЧй
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_RESOURSEGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName;
            public byte byGroupType;/*0-ЙгПс»ъCAMЧйЈ¬1-јаКУЖчMONЧй*/
            public byte byRes1;
            public ushort wMemNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] dwGlobalId; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Чо¶а255ёцУГ»§Чй
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wUserMember;  /*°ьє¬µДУГ»§іЙФ±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wResorceGroupMember; /*°ьє¬µДЧКФґЧйіЙФ±*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byPermission;//ИЁПЮЈ¬КэЧй0-ptzИЁПЮЎўЗР»»ИЁПЮЎўІйСЇИЁПЮ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_TRUNKPARAM
        {
            public uint dwSize;
            public uint dwTrunkId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sTrunkName;
            public uint dwSrcMonId;
            public uint dwDstCamId;
            public byte byTrunkType;  /*К№УГАаРН  1-BNCЈ¬2-SP3№вПЛёЯЗеЈ¬3-SP3№вПЛD1Ј¬ 4-V6№вПЛЈ¬5-ЖдЛы№вПЛ*/
            public byte byAbility;     /*±нКѕ№вПЛµДґшїнЈ¬їЙТФґ«КдјёВ·*/
            public byte bySubChan;   /*Хл¶Ф№вПЛёЙПЯ¶шСФЈ¬±нКѕЧУНЁµАєЕ*/
            public byte byLevel;		/* ёЙПЯј¶±р 1-255*/
            public ushort wReserveUserID;	//Ф¤БфµДУГ»§IDЈє 1~256 Ј¬0±нКѕКН·ЕФ¤Бф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRUNKLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwTrunkNum;//Йи±ё·µ»ШµДёЙПЯКэБї
            public IntPtr pBuffer;//ёЙПЯРЕПў»єіеЗш
            public uint dwBufLen;//Лщ·ЦЕдЦёХлі¤¶ИЈ¬КдИлІОКэ
        }

        public const int MATRIX_PROTOCOL_NUM   = 20;    //Ц§іЦµДЧоґуѕШХуР­ТйКэ
        public const int KEYBOARD_PROTOCOL_NUM = 20;    //Ц§іЦµДЧоґујьЕМР­ТйКэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE_EX
        { 
            public ushort wType;               /*ipcР­ТйЦµ*/  
            public ushort wCommunitionType;		/*0ЈєДЈДв 1ЈєКэЧЦ 2ЈєјжИЭДЈДвЎўКэЧЦ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Р­ТйГиКцЧЦ¶О*/    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXMANAGE_ABIILITY
        {
            public uint dwSize;
            public uint dwMaxCameraNum;//ЧоґуCameraКэБї
            public uint dwMaxMonitorNum;//ЧоґујаКУЖчКэБї
            public ushort wMaxMatrixNum;//ЧоґуѕШХуКэБї
            public ushort wMaxSerialNum;//ґ®їЪКэБї
            public ushort wMaxUser;//ЧоґуУГ»§Кэ
            public ushort wMaxResourceArrayNum;//ЧоґуЧКФґЧйКэ
            public ushort wMaxUserArrayNum;//ЧоґуУГ»§ЧйКэ
            public ushort wMaxTrunkNum;//ЧоґуёЙПЯКэ
            public byte nStartUserNum;//ЖрКјУГ»§єЕ
            public byte nStartUserGroupNum;//ЖрКјУГ»§ЧйєЕ
            public byte nStartResourceGroupNum;//ЖрКјЧКФґЧйєЕ
            public byte nStartSerialNum;//ЖрКјґ®їЪєЕ
            public uint  dwMatrixProtoNum;     /*УРР§µДѕШХуР­ТйКэДїЈ¬ґУ0їЄКј*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struMatrixProto;/*ЧоґуР­ТйБР±ні¤¶И*/ 
            public uint dwKeyBoardProtoNum;     /*УРР§µДјьЕМР­ТйКэДїЈ¬ґУ0їЄКј*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struKeyBoardProto;/*ЧоґуР­ТйБР±ні¤¶И*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ИЛБіЧҐЕД№жФт(µҐМх)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_FACESNAPCFG
        {
            public byte byActive;				//КЗ·сј¤»о№жФтЈє0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
            public NET_VCA_SIZE_FILTER struSizeFilter;   //іЯґз№эВЛЖч
            public NET_VCA_POLYGON struVcaPolygon;		//ИЛБіК¶±рЗшУт
        }

        //ИЛБіЧҐЕД№жФтІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAPCFG
        {
            public uint dwSize;
            public byte bySnapTime;					//µҐёцДї±кИЛБіµДЧҐЕДґОКэ0-10
            public byte bySnapInterval;                 //ЧҐЕДјдёфЈ¬µҐО»ЈєЦЎ
            public byte bySnapThreshold;               //ЧҐЕДгРЦµЈ¬0-100
            public byte byGenerateRate; 		//Дї±кЙъіЙЛЩ¶И,·¶О§[1, 5]	
            public byte bySensitive;			//Дї±кјмІвБйГф¶ИЈ¬·¶О§[1, 5]
            public byte byReferenceBright; //2012-3-27ІОїјББ¶И[0,100]
            public byte byMatchType;         //2012-5-3±И¶Ф±ЁѕЇДЈКЅЈ¬0-Дї±кПыК§єу±ЁѕЇЈ¬1-КµК±±ЁѕЇ
            public byte byMatchThreshold;  //2012-5-3КµК±±И¶ФгРЦµЈ¬0~100
            public NET_DVR_JPEGPARA struPictureParam; //НјЖ¬№жёсЅб№№
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_FACESNAPCFG[] struRule; //ИЛБіЧҐЕД№жФт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //ИЛБіЧҐЕДЅб№ы±ЁѕЇЙПґ«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_RESULT
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwFacePicID;
            public uint dwFaceScore;
            public NET_VCA_TARGET_INFO struTargetInfo;
            public NET_VCA_RECT struRect;
            public NET_VCA_DEV_INFO struDevInfo;
            public uint dwFacePicLen;
            public uint dwBackgroundPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
            public IntPtr pBuffer1;//ЦёПтИЛБіЧУНјµДНјЖ¬КэѕЭ
            public IntPtr pBuffer2;//±іѕ°НјµДНјЖ¬КэѕЭЈЁ±ЈБфЈ¬НЁ№эІйХТ±іѕ°НјЅУїЪїЙТФ»сИЎ±іѕ°НјЈ©
        }

        //РйЅ№ХмІвЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOCUS_ALARM
        {
            public uint dwSize;     /*Ѕб№№і¤¶И*/
            public NET_VCA_DEV_INFO struDevInfo;/*Йи±ёРЕПў*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOEXCEPTION_ALARM
        {
            public uint    dwSize;     /*Ѕб№№і¤¶И*/
            public byte byAlarmType;//±ЁѕЇАаРНЈ¬1-ТфЖµКдИлТміЈЈ¬2-ТфЖµКдИлН»±д
            public byte byRes1;
            public ushort wAudioDecibel;//ЙщТфЗї¶ИЈЁТфЖµКдИлН»±дК±УГµЅЈ©
            public NET_VCA_DEV_INFO struDevInfo;/*Йи±ёРЕПў*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_BUTTON_DOWN_EXCEPTION_ALARM
        {
            public uint dwSize;     /*Ѕб№№і¤¶И*/
            public NET_VCA_DEV_INFO struDevInfo;/*Йи±ёРЕПў*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_IMAGE_CFG
        {
            public uint dwWidth;                  //»Т¶ИНјПсКэѕЭїн¶И
            public uint dwHeight;                 //»Т¶ИНјПсёЯ¶И
            public uint dwImageLen;  //»Т¶ИНјПсКэѕЭі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
            public IntPtr pImage;    //»Т¶ИНјПсКэѕЭ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_CFG
        {
            public uint  dwSize;           //Ѕб№№ґуРЎ
            public byte byEnable;         //КЗ·сј¤»о№жФт;
            public byte bySensitivity;      //јмІвБйГф¶ИЈ¬[0,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //±ЈБфЧЦЅЪ 
            public NET_VCA_SIZE_FILTER struSizeFilter;  //іЯґз№эВЛЖч
            public NET_VCA_POLYGON  struPolygon;    //¶а±ЯРО
            public NET_VCA_FD_IMAGE_CFG struFDImage;  //НјЖ¬РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_PROCIMG
        {
            public uint dwImageLen;  //НјЖ¬КэѕЭі¤¶И
            public uint dwFaceScore;		//ИЛБіЖА·Ц,0-100
            public NET_VCA_RECT struVcaRect; //ИЛБіЧУНјЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
            public IntPtr pImage;  //НјЖ¬КэѕЭ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_RESULT
        {
            public uint dwSize;   //Ѕб№№ґуРЎ
            public uint dwImageId; //ґуНјID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
            public uint dwSubImageNum;  //ИЛБіЧУНјХЕКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SUB_PROCIMG[] struProcImg;  //µҐХЕЧУНјРЕПў
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PICMODEL_RESULT
        {
            public uint dwImageLen;  //НјЖ¬КэѕЭі¤¶И
            public uint dwModelLen;  //ДЈРНКэѕЭі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
            public IntPtr pImage;  //ИЛБіНјЖ¬КэѕЭЦёХл
            public IntPtr pModel;  //ДЈРНКэѕЭЦёХл
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REGISTER_PIC
        {
            public uint dwImageID; //ґуНјID
            public uint dwFaceScore;		//ИЛБіЖА·Ц,0-100
            public NET_VCA_RECT struVcaRect;  //ИЛБіЧУНјЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        //ј®№бІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AREAINFOCFG
        {
            public ushort wNationalityID;//№ъј®
            public ushort wProvinceID;//КЎ
            public ushort wCityID;//КР
            public ushort wCountyID;//ПШ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //ИЛФ±РЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ATTRIBUTE
        {
            public byte bySex;//РФ±рЈє0-ДРЈ¬1-Е®
            public byte byCertificateType;//Ц¤јюАаРНЈє0-Йн·ЭЦ¤Ј¬1-ѕЇ№ЩЦ¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBirthDate;//іцЙъДкФВЈ¬ИзЈє201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //РХГы
            public NET_DVR_AREAINFOCFG struNativePlace;//ј®№бІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber; //Ц¤јюєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMANATTRIBUTE_COND
        {
            public byte bySex; //РФ±рЈє0-І»ЖфУГЈ¬1-ДРЈ¬2-Е®
            public byte byCertificateType; //Ц¤јюАаРНЈє0-І»ЖфУГЈ¬1-Йн·ЭЦ¤Ј¬2-ѕЇ№ЩЦ¤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStartBirthDate; //ЖрКјіцЙъДкФВЈ¬ИзЈє201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEndBirthDate; //ЅШЦ№іцЙъДкФВЈ¬Из201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //РХГы
            public NET_DVR_AREAINFOCFG struNativePlace; //ј®№бІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber;  //Ц¤јюєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //єЪГыµҐРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO
        {
            public uint dwSize;//Ѕб№№ґуРЎ
            public uint dwRegisterID;//ГыµҐЧўІбIDєЕЈЁЦ»¶БЈ©
            public uint dwGroupNo;//·ЦЧйєЕ
            public byte byType;//єЪ°ЧГыµҐ±кЦѕЈє0-И«ІїЈ¬1-°ЧГыµҐЈ¬2-єЪГыµҐ
            public byte byLevel;//єЪГыµҐµИј¶Ј¬0-И«ІїЈ¬1-µНЈ¬2-ЦРЈ¬3-ёЯ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute;//ИЛФ±РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemark;//±ёЧўРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PARA
        {
            public uint dwSize;   //Ѕб№№ґуРЎ
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //єЪГыµҐ»щ±ѕІОКэ
            public uint dwRegisterPicNum;  //єЪГыµҐНјёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struRegisterPic;  //єЪГыµҐНјЖ¬РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_COND
        {
            public Int32 lChannel; //НЁµАєЕ
            public uint dwGroupNo; //·ЦЧйєЕ
            public byte byType; //єЪ°ЧГыµҐ±кЦѕЈє0-И«ІїЈ¬1-°ЧГыµҐЈ¬2-єЪГыµҐ
            public byte byLevel; //єЪГыµҐµИј¶Ј¬0-И«ІїЈ¬1-µНЈ¬2-ЦРЈ¬3-ёЯ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //±ЈБф
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute; //ИЛФ±РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PIC
        {
            public uint dwSize;   //Ѕб№№ґуРЎ
            public uint dwFacePicNum;  //ИЛБіНјёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struBlackListPic;  //µҐХЕХХЖ¬РЕПў
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND
        {
            public Int32 lChannel;//НЁµАєЕ
            public NET_DVR_TIME struStartTime;//їЄКјК±јд
            public NET_DVR_TIME struStopTime;//ЅбКшК±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        public const int MAX_FACE_PIC_LEN = 6144;   //ЧоґуИЛБіНјЖ¬КэѕЭі¤¶И
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_SNAPPIC_DATA
        {
            public uint dwFacePicID; //ИЛБіНјID
            public uint dwFacePicLen;  //ИЛБіНјКэѕЭі¤¶И
            public NET_DVR_TIME struSnapTime;  //ЧҐЕДК±јд
            public uint dwSimilarity; //ПаЛЖ¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_FACE_PIC_LEN)]
            public string sPicBuf;  //НјЖ¬КэѕЭ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADVANCE_FIND
        {
            public uint dwFacePicID; //ИЛБіНјЖ¬ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_NORMAL_FIND
        {
            public uint dwImageID; //ґуНјID
            public uint dwFaceScore;  //ИЛБіЖА·Ц
            public NET_VCA_RECT struVcaRect; //ИЛБіЧУНјЗшУт
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_FIND_SNAPPIC_UNION
        {
            //БЄєПМеґуРЎОЄ44ЧЦЅЪ
            [FieldOffsetAttribute(0)]
            public NET_VCA_NORMAL_FIND  struNormalFind; //ЖХНЁјмЛч
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADVANCE_FIND struAdvanceFind; //ёЯј¶јмЛч
        }

        public enum VCA_FIND_SNAPPIC_TYPE
        {
            VCA_NORMAL_FIND  = 0x00000000,   //ЖХНЁјмЛч
	        VCA_ADVANCE_FIND  = 0x00000001  //ёЯј¶јмЛч
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND_ADVANCE
        {
            public Int32 lChannel;//НЁµАєЕ
            public NET_DVR_TIME struStartTime;//їЄКјК±јд
            public NET_DVR_TIME struStopTime;//ЅбКшК±јд
            public byte byThreshold;  //гРЦµЈ¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
            public VCA_FIND_SNAPPIC_TYPE dwFindType;//јмЛчАаРНЈ¬ПкјыVCA_FIND_SNAPPIC_TYPE
            public NET_VCA_FIND_SNAPPIC_UNION uFindParam; //јмЛчІОКэ
        }

        //ИЛБіЧҐЕДРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM
        {
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwSnapFacePicID;
            public uint dwSnapFacePicLen;
            public NET_VCA_DEV_INFO struDevInfo;//ИЛБіЧҐЕДЙПґ«РЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
            public IntPtr pBuffer1;//ЦёПтНјЖ¬µДЦёХл
        }
        //єЪГыµҐ±ЁѕЇРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;
            public uint dwBlackListPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
            public IntPtr pBuffer1;//ЦёПтНјЖ¬µДЦёХл
        }

        //єЪГыµҐ±И¶ФЅб№ы±ЁѕЇЙПґ«
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM
        {
            public uint dwSize;
            public float fSimilarity;//ПаЛЖ¶ИЈ¬ИЎЦµ·¶О§Јє[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM struSnapInfo;//ИЛБіЧҐЕДЙПґ«РЕПў
            public NET_VCA_BLACKLIST_INFO_ALARM struBlackListInfo;//єЪГыµҐ±ЁѕЇРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }   
   
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM_LOG
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo; //єЪГыµҐ»щ±ѕРЕПў
            public uint dwBlackListPicID;       //єЪГыµҐИЛБіЧУНјIDЈ¬УГУЪІйХТНјЖ¬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM_LOG
        {
            public uint dwRelativeTime;     // Па¶ФК±±к
            public uint dwAbsTime;			// ѕш¶ФК±±к
            public uint dwSnapFacePicID;       //ЧҐЕДИЛБіНјID
            public NET_VCA_DEV_INFO struDevInfo;		//З°¶ЛЙи±ёРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM_LOG
        {
            public uint dwSize;     		// Ѕб№№ґуРЎ
            public float fSimilarity; //ПаЛЖ¶ИЈ¬[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM_LOG  struSnapInfoLog; //ЧҐЕДРЕПў
            public NET_VCA_BLACKLIST_INFO_ALARM_LOG struBlackListInfoLog; //єЪГыµҐРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICCOND
        {
            public uint dwSize;     		// Ѕб№№ґуРЎ
            public uint dwSnapFaceID; //ЧҐЕДИЛБіЧУНјID
            public uint dwBlackListID; //ЖҐЕдµДєЪГыµҐID
            public uint dwBlackListFaceID; //±И¶ФµДєЪГыµҐИЛБіЧУНјID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // ±ЈБфЧЦЅЪ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICTURE
        {
            public uint dwSize;     		// Ѕб№№ґуРЎ
            public uint dwSnapFaceLen; //ЧҐЕДИЛБіЧУНјі¤¶И
            public uint dwBlackListFaceLen; //±И¶ФµДєЪГыµҐИЛБіЧУНјі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              //±ЈБфЧЦЅЪ
            public IntPtr pSnapFace;  //ЧҐЕДИЛБіЧУНјµДНјЖ¬КэѕЭ
            public IntPtr pBlackListFace;  //±И¶ФµДєЪГыµҐИЛБіЧУНјКэѕЭ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_FASTREGISTER_PARA
        {
            public uint dwSize;   //Ѕб№№ґуРЎ
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //єЪГыµҐ»щ±ѕІОКэ
            public uint dwImageLen;  //НјПсКэѕЭі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
            public IntPtr pImage;    //НјПсКэѕЭ
        }

        //µҐёц·ЦЗшЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_PATH
        {
            public byte byActive;  // КЗ·сїЙУГ,0-·с,1-КЗ 
            public byte byType;   //0-ґжґўЧҐЕДЈ¬1-ґжґўєЪГыµҐ±И¶Ф±ЁѕЇЈ¬2-ґжґўЧҐЕДєНєЪГыµҐ±И¶Ф±ЁѕЇЈ¬0xff-ОЮР§
            public byte bySaveAlarmPic; //КЗ·сУГУЪ±Јґж¶ПНшµД±ЁѕЇНјЖ¬Ј¬0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //±ЈБф
            public uint dwDiskDriver;   //ЕМ·ыєЕЈ¬ґУ0їЄКј
            public uint dwLeftSpace;   //Ф¤БфИЭБїЈЁµҐО»ОЄGЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //±ЈБф
        }

        //ґжґўВ·ѕ¶ЙиЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SAVE_PATH_CFG
        { 
            public uint dwSize;   //Ѕб№№ґуРЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_PATH[] struPathInfo; //µҐёц·ЦЗш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_ACCESS_CFG
        {
            public uint   dwSize;
            public NET_DVR_IPADDR struIP;		//ЅУИлЙи±ёµДIPµШЦ·
            public ushort wDevicePort;			 	//¶ЛїЪєЕ
            public byte byEnable;		         //КЗ·сЖфУГЈ¬0-·сЈ¬1-КЗ
            public byte byRes1;				//±ЈБф
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//ЅУИлЙи±ёµДµЗВјХКєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//ЅУИлЙи±ёµДµЗВјГЬВл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        /********************************ЦЗДЬИЛБіК¶±р end****************************/
        //·Ц±жВК
        public const int NOT_AVALIABLE = 0;
        public const int SVGA_60HZ = 52505660;
        public const int SVGA_75HZ = 52505675;
        public const int XGA_60HZ = 67207228;
        public const int XGA_75HZ = 67207243;
        public const int SXGA_60HZ = 84017212;
        public const int SXGA2_60HZ = 84009020;
        public const int _720P_60HZ = 83978300;
        public const int _720P_50HZ = 83978290;
        public const int _1080I_60HZ = 394402876;
        public const int _1080I_50HZ = 394402866;
        public const int _1080P_60HZ = 125967420;
        public const int _1080P_50HZ = 125967410;
        public const int _1080P_30HZ = 125967390;
        public const int _1080P_25HZ = 125967385;
        public const int _1080P_24HZ = 125967384;
        public const int UXGA_60HZ = 105011260;
        public const int UXGA_30HZ = 105011230;
        public const int WSXGA_60HZ = 110234940;
        public const int WUXGA_60HZ = 125982780;
        public const int WUXGA_30HZ = 125982750;
        public const int WXGA_60HZ = 89227324;
        public const int SXGA_PLUS_60HZ = 91884860;

        //ПФКѕНЁµА»­Гж·ЦёоДЈКЅ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPWINDOWMODE
        {
            public byte byDispChanType;//ПФКѕНЁµААаРНЈє0-VGA, 1-BNC, 2-HDMI, 3-DVI
            public byte byDispChanSeq;//ПФКѕНЁµАРтєЕ,ґУ1їЄКјЈ¬Из№ыАаРНКЗVGAЈ¬Фт±нКѕµЪјёёцVGA
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispMode;
        }

        //ПФКѕНЁµАРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPINFO
        {
            public byte byChanNums;//НЁµАёцКэ
            public byte byStartChan;//ЖрКјНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUPPORT_RES, ArraySubType = UnmanagedType.U1)]
            public uint[] dwSupportResolution;//Ц§іЦµД·Ц±жВК
        }

        //ґуЖБЖґЅУРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINFO
        {
            public byte bySupportBigScreenNums;//Чо¶аґуЖБЖґЅУКэБї
            public byte byStartBigScreenNum;//ґуЖБЖґЅУЖрКјєЕ
            public byte byMaxScreenX;//ґуЖБЖґЅУДЈКЅ
            public byte byMaxScreenY;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY_V41
        {
            public uint dwSize;
            public byte byDspNums;//DSPёцКэ  
            public byte byDecChanNums;//ЅвВлНЁµАКэ
            public byte byStartChan;//ЖрКјЅвВлНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public NET_DVR_DISPINFO struVgaInfo;//VGAПФКѕНЁµАРЕПў
            public NET_DVR_DISPINFO struBncInfo;//BNCПФКѕНЁµАРЕПў
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIПФКѕНЁµАРЕПў
            public NET_DVR_DISPINFO struDviInfo;//DVIПФКѕНЁµАРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPWINDOWMODE[] struDispMode;
            public NET_DVR_SCREENINFO struBigScreenInfo;
            public byte bySupportAutoReboot; //КЗ·сЦ§іЦЧФ¶ЇЦШЖфЈ¬0-І»Ц§іЦЈ¬1-Ц§іЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_WINDOWS = 16;//Чоґуґ°їЪКэ
        public const int MAX_WINDOWS_V41 = 36;
        
        public const int STARTDISPCHAN_VGA = 1;
        public const int STARTDISPCHAN_BNC = 9;
        public const int STARTDISPCHAN_HDMI	= 25;
        public const int STARTDISPCHAN_DVI = 29;

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_PLATFORM
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public VideoPlatform struVideoPlatform;
            [FieldOffsetAttribute(0)]
            public NotVideoPlatform struNotVideoPlatform;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public NET_DVR_RECTCFG struPosition; //ПФКѕНЁµАФЪµзКУЗЅЦРО»ЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NotVideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*ПФКѕНЁµАЕдЦГЅб№№Ме*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_VOUTCFG
        {
            public uint dwSize;
            public byte byAudio;			/*ТфЖµКЗ·сїЄЖф*/
            public byte byAudioWindowIdx;      /*ТфЖµїЄЖфЧУґ°їЪ*/
            public byte byDispChanType;      /*ПФКѕНЁµААаРНЈє0-BNCЈ¬1-VGAЈ¬2-HDMIЈ¬3-DVIЈ¬4-YPbPr(ЅвВлїЁ·юОсЖчDECODER_SERVERЧЁУГ)*/
            public byte byVedioFormat;         /*1:NTSC,2:PALЈ¬0-NULL*/
            public uint dwResolution;//·Ц±жВК
            public uint dwWindowMode;		/*»­ГжДЈКЅЈ¬ДЬБ¦јЇ»сИЎ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*ёчёцЧУґ°їЪ№ШБЄµДЅвВлНЁµА,Йи±ёЦ§іЦЅвВлЧКФґЧФ¶Ї·ЦЕдК±ґЛІОКэІ»УГМоід*/
            public byte byEnlargeStatus;          /*КЗ·сґ¦УЪ·ЕґуЧґМ¬Ј¬0ЈєІ»·ЕґуЈ¬1Јє·Еґу*/
            public byte byEnlargeSubWindowIndex;//·ЕґуµДЧУґ°їЪєЕ
            public byte byScale; /*ПФКѕДЈКЅЈ¬0---ХжКµПФКѕЈ¬1---Лх·ЕПФКѕ( Хл¶ФBNC )*/
            public byte byUnionType;/*Зш·Ц№ІУГМе,0-КУЖµЧЫєПЖЅМЁДЪІїЅвВлЖчПФКѕНЁµАЕдЦГЈ¬1-ЖдЛыЅвВлЖчПФКѕНЁµАЕдЦГ*/
            public NET_DVR_VIDEO_PLATFORM struDiff;
            public uint dwDispChanNum; //ПФКѕКдіцєЕЈ¬ґЛІОКэФЪИ«Ії»сИЎК±УРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        } 

        /*ЅвВлЖчЙи±ёЧґМ¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS_V41
        {
            public byte byDispStatus;      /*ПФКѕЧґМ¬Јє0ЈєОґПФКѕЈ¬1ЈєЖф¶ЇПФКѕ*/
            public byte byBVGA;              /*0-BNCЈ¬1-VGAЈ¬ 2-HDMIЈ¬3-DVIЈ¬0xff-ОЮР§*/
            public byte byVideoFormat;     /*КУЖµЦЖКЅЈ¬1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;       /*»­ГжДЈКЅ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;   /*ёчёцЧУ»­Гж№ШБЄµДЅвВлНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;        /*ГїёцЧУ»­ГжµДПФКѕЦЎВК*/
            public byte byScreenMode;		/*ЖБД»ДЈКЅ0-ЖХНЁ 1-ґуЖБ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDispChan; /*»сИЎИ«ІїПФКѕНЁµАЧґМ¬К±УРР§Ј¬ЙиЦГК±їЙМо0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }

        /*ЅвВлЖчЙи±ёЧґМ¬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS_V41
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;     /*ЅвВлНЁµАЧґМ¬*/
	        /*ПФКѕНЁµАЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS_V41[] struDispChanStatus;     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;         /*±ЁѕЇКдИлЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatus;       /*±ЁѕЇКдіцЧґМ¬*/
            public byte byAudioInChanStatus;          /*УпТф¶ФЅІЧґМ¬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************ОДјю»Ш·Е-Ф¶іМ»Ш·ЕЙиЦГ*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_V41
        {
            public uint dwSize;
            public NET_DVR_IPADDR	struIP;		/* DVR IPµШЦ· */	
            public ushort wDVRPort;			/* ¶ЛїЪєЕ */	
            public byte byChannel;			/* НЁµАєЕ */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* УГ»§Гы */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ГЬВл */
            public uint dwPlayMode;   	/* 0Ј­°ґОДјю 1Ј­°ґК±јд*/        	
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		/*±ЈБф*/
        }

        public const int MAX_BIGSCREENNUM_SCENE = 100;

        //ПФКѕНЁµАЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_SCENE
        {
            public ushort wXCoordinate; /*ѕШРОЧуЙПЅЗЖрКјµгXЧш±к*/
            public ushort wYCoordinate; /*ѕШРОЧуЙПЅЗYЧш±к*/
            public ushort wWidth;       /*ѕШРОїн¶И*/
            public ushort wHeight;      /*ѕШРОёЯ¶И*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENEDISPCFG
        {
            public byte byEnable;//КЗ·сЖфУГЈ¬0-І»ЖфУГЈ¬1-ЖфУГ
            public byte bySoltNum;//ІЫО»єЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDispChanNum;
            public byte byAudio;				/*ТфЖµКЗ·сїЄЖф,0-·сЈ¬1-КЗ*/
            public byte byAudioWindowIdx;      /*ТфЖµїЄЖфЧУґ°їЪ*/
            public byte byVedioFormat;          /*1:NTSC,2:PALЈ¬0-NULL*/
            public byte byWindowMode;			/*»­ГжДЈКЅЈ¬ґУДЬБ¦јЇ»сИЎ*/
            public byte byEnlargeStatus;         /*КЗ·сґ¦УЪ·ЕґуЧґМ¬Ј¬0ЈєІ»·ЕґуЈ¬1Јє·Еґу*/
            public byte byEnlargeSubWindowIndex;//·ЕґуµДЧУґ°їЪєЕ    
            public byte byScale; /*ПФКѕДЈКЅЈ¬0-ХжКµПФКѕЈ¬1-Лх·ЕПФКѕ( Хл¶ФBNC )*/
            public uint dwResolution;//·Ц±жВК
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*ёчёцЧУґ°їЪ№ШБЄµДЅвВлНЁµА*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;/*ІЫО»єЕ*/
            //ПФКѕґ°їЪЛщЅвКУЖµ·Ц±жВКЈ¬1-D1,2-720P,3-1080PЈ¬Йи±ё¶ЛРиТЄёщѕЭґЛ//·Ц±жВКЅшРРЅвВлНЁµАµД·ЦЕдЈ¬Из1·ЦЖБЕдЦГіЙ1080PЈ¬ФтЙи±ё»б°С4ёцЅвВлНЁµА¶ј·ЦЕдёшґЛЅвВлНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public byte byRow;//ґуЖБЛщФЪµДРРµДРтєЕ
            public byte byColumn;//ґуЖБЛщФЪµДБРµДРтєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_RECTCFG struDisp; //µзКУЗЅПФКѕО»ЦГ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_SCENE
        {
            public NET_DVR_IPADDR struIP;				/* DVR IPµШЦ· */
            public ushort wDVRPort;			 	/* ¶ЛїЪєЕ */
            public byte byChannel;		/* НЁµАєЕЈ¬¶ФУЪ9000µИЙи±ёµДIPCЅУИлЈ¬НЁµАєЕґУ33їЄКј */
            public byte byTransProtocol;		/* ґ«КдР­ТйАаРН0-TCPЈ¬1-UDP Ј¬2-MCASTЈ¬3-RTP*/
            public byte byTransMode;			/* ґ«КдВлБчДЈКЅ 0Ј­ЦчВлБч 1Ј­ЧУВлБч*/
            public byte byFactoryType;				/*З°¶ЛЙи±ёі§јТАаРН*/
            public byte byDeviceType;			//Йи±ёАаРНЈ¬1-IPCЈ¬2- ENCODER
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/* јаїШЦч»ъµЗВЅХКєЕ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/* јаїШЦч»ъГЬВл */
        }

        /*БчГЅМе·юОсЖч»щ±ѕЕдЦГ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE
        {
            public byte byValid;			/*КЗ·сЖфУГБчГЅМе·юОсЖчИЎБч,0±нКѕОЮР§*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;	/*БчГЅМе·юОсЖчµШЦ·*/
            public ushort wDevPort;			/*БчГЅМе·юОсЖч¶ЛїЪ*/
            public byte byTransmitType;		/*ґ«КдР­ТйАаРН0-TCPЈ¬1-UDP */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_SCENE
        {
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE				struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYC_SUR_CHAN_ELE_SCENE
        {
            public byte byEnable;	/* КЗ·сЖфУГ 0Ј­·с 1Ј­ЖфУГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	struStreamMediaSvrCfg;	
            public NET_DVR_DEV_CHAN_INFO_SCENE			struDecChanInfo;	/*ВЦСІЅвВлНЁµАРЕПў*/
        }

        //ВЦСІЅвВлЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_SCENE
        {
            public ushort wPoolTime;		/*ВЦСЇјдёф*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYC_SUR_CHAN_ELE_SCENE[] struChanArray;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //µҐёцЅвВлНЁµАЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODECHANCFG_SCENE
        {
            public byte byDecodeEnable;//ЅвВлЖрНЈ±кЦѕЈ¬0-НЈЦ№Ј¬1-ЖфУГ¶ЇМ¬ЅвВлЈ¬2-ЖфУГВЦСІЅвВл
            public byte bySlotNum;//ІЫО»єЕ
            public byte byDecChan;
            public byte byJointAllDecodeChan;		//КЗ·с№ШБЄНтДЬЅвВлНЁµА 0-І»№ШБЄЈ¬1-№ШБЄ
            public byte byJointSlotNum;			//№ШБЄµДІЫО»єЕЈЁНтДЬЅвВл°еµДІЫО»єЕЈ©
            public byte byJointChanNum;		//№ШБЄµДНЁµАєЕЈЁНтДЬЅвВл°еНЁµАєЕЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public STRUDECCFG struDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct STRUDECCFG
        {
            //[FieldOffsetAttribute(0)]
            //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5480, ArraySubType = UnmanagedType.I1)]
            //public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public NET_DVR_PU_STREAM_CFG_SCENE struSceneDynamicDecCfg;
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_LOOP_DECINFO_SCENE struSceneCycDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG_SCENE
        {
            public byte byAllValid; /*ВюУОК№ДЬ±кЦѕ */
            public byte byAssociateBaseMap;//№ШБЄµДµЧНјРтєЕЈ¬0ґъ±нІ»№ШБЄ
            public byte byEnableSpartan;//ґуЖБі©ПФК№ДЬЈ¬1-їЄЈ¬0-№Ш
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            public NET_DVR_BIGSCREENCFG struBigScreen;

            public void Init()
            {
                struBigScreen = new NET_DVR_BIGSCREENCFG();
                struWinCfg = new NET_DVR_WINCFG[MAX_LAYERNUMS];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_SCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;
            public byte byBigScreenNums;//ґуЖБµДёцКэЈ¬ЧоґуЦµНЁ№эДЬБ¦јЇ»сИЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wDecChanNums;//іЎѕ°ЦРЅвВлНЁµАµДёцКэ
            public ushort wDispChanNums;//іЎѕ°ЦРПФКѕНЁµАµДёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public IntPtr pBigScreenBuffer;//ґуЖБЕдЦГ»єіеЗш, byBigScreenNumsЎБsizeof(NET_DVR_BIGSCREENCFG_SCENE)
            public IntPtr pDecChanBuffer;//ЅвВлНЁµАЕдЦГ»єіеЗш, wDecChanNumsЎБsizeof(NET_DVR_DECODECHANCFG_SCENE)
            public IntPtr pDispChanBuffer;//ПФКѕНЁµАЕдЦГ»єіеЗш, wDispChanNumsЎБsizeof(NET_DVR_SCENEDISPCFG)
            public void Init()
            {
                sSceneName = new byte[NAME_LEN];
                byRes1 = new byte[3];
                byRes1 = new byte[12];
            }
        }
        public const int NET_DVR_GET_ALLWINCFG = 1503; //ґ°їЪІОКэ»сИЎ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENASSOCIATECFG
        {
            public uint dwSize;
            public byte byEnableBaseMap;//К№ДЬµЧНјПФКѕ
            public byte byAssociateBaseMap;//№ШБЄµДµЧНјРтєЕЈ¬0ґъ±нІ»№ШБЄ
            public byte byEnableSpartan;//ґуЖБі©ПФК№ДЬЈ¬1-їЄЈ¬0-№Ш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        /*******************************ґ°їЪЙиЦГ*******************************/
        public const int MAX_WIN_COUNT = 224; //Ц§іЦµДЧоґуїЄґ°Кэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_WINCFG{
            public uint dwSize;
            public byte byVaild;
            public byte byInputType;		//јыCAM_MDOE
            public ushort wInputIdx;			/*КдИлФґЛчТэ*/
            public uint dwLayerIdx;			/*НјІгЈ¬0ОЄЧоµЧІг*/
            public NET_DVR_RECTCFG struWin;	//ДїµДґ°їЪ(Па¶ФПФКѕЗЅ)
            public byte byWndIndex;			//ґ°їЪєЕ
            public byte byCBD;				//0-ОЮЈ¬1-ґш±іѕ°Ј¬2-І»ґш±іѕ°
            public byte bySubWnd;			//0І»КЗЈ¬1КЗ
            public byte byRes1;
            public uint dwDeviceIndex;//Йи±ёРтєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINLIST
        {
            public uint dwSize;
            public ushort wScreenSeq;	//Йи±ёРтєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwWinNum;	//Йи±ё·µ»ШµДґ°їЪКэБї
            public IntPtr pBuffer;	//ґ°їЪРЕПў»єіеЗшЈ¬ЧоґуОЄ224*sizeof(NET_DVR_WINCFG)
            public uint dwBufLen;	//Лщ·ЦЕдЦёХлі¤¶И
        }

        public const int MAX_LAYOUT_COUNT = 16;		//ЧоґуІјѕЦКэ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUTCFG
        {
            public uint dwSize;
            public byte byValid;								//ІјѕЦКЗ·сУРР§
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLayoutName;			//ІјѕЦГыіЖ			
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WIN_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCREEN_WINCFG[] struWinCfg;	//ІјѕЦДЪґ°їЪІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUT_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYOUT_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LAYOUTCFG[] struLayoutInfo;   //ЛщУРІјѕЦ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_CAM_COUNT = 224;

        public enum NET_DVR_CAM_MODE
        {
	        NET_DVR_UNKNOW  = 0,//ОЮР§
	        NET_DVR_CAM_BNC,
	        NET_DVR_CAM_VGA,
	        NET_DVR_CAM_DVI,
	        NET_DVR_CAM_HDMI,
	        NET_DVR_CAM_IP,
	        NET_DVR_CAM_RGB,
            NET_DVR_CAM_DECODER,
	        NET_DVR_CAM_MATRIX,
	        NET_DVR_CAM_YPBPR,
	        NET_DVR_CAM_USB,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG
        {
            public uint dwSize ;
            public byte byValid ;
            public byte byCamMode;						//РЕєЕКдИлФґАаРНЈ¬јыNET_DVR_CAM_MODE
            public ushort wInputNo;						//РЕєЕФґРтєЕ0-224
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName;			//РЕєЕКдИлФґГыіЖ
            public NET_DVR_VIDEOEFFECT struVideoEffect;	//КУЖµІОКэ
            public NET_DVR_PU_STREAM_CFG struPuStream;	//ipКдИлК±К№УГ
            public ushort wBoardNum ;						//РЕєЕФґЛщФЪµД°еїЁєЕ
            public ushort wInputIdxOnBoard;				//РЕєЕФґФЪ°еїЁЙПµДО»ЦГ
            public ushort wResolutionX;					//·Ц±жВК
            public ushort wResolutionY;
            public byte byVideoFormat;					//КУЖµЦЖКЅЈ¬0-ОЮЈ¬1-NTSCЈ¬2-PAL
            public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp ЎЈНшВзРЕєЕФґµД·Ц±жВКЈ¬ФЪМнјУНшВзРЕєЕФґК±ґ«ёшЙи±ёЈ¬Йи±ёёщѕЭХвёц·Ц±жВКАґ·ЦЕдЅвВлЧКФґЎЈ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;	//НшВзРЕєЕФґ·ЦЧй ЧйГы
            public byte byJointMatrix;			//  №ШБЄѕШХу Ј¬0-І»№ШБЄ  1-№ШБЄ
            public byte byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAM_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CAM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INPUTSTREAMCFG[] struInputStreamInfo; //ЛщУРРЕєЕФґ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************КдіцІОКэЕдЦГ*******************************/
        /*КдіцНЁµА№ЬАн*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTPARAM
        {
            public uint  dwSize;
            public byte byMonMode;		/*КдіцБ¬ЅУДЈКЅ,1-BNC,2-VGA,3-DVI,4-HDMI*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint  dwResolution;	/*·Ц±жВКЈ¬ёщѕЭДЬБ¦јЇ»сИЎЛщЦ§іЦµДЅшРРЙиЦГ*/
            public NET_DVR_VIDEOEFFECT  struVideoEffect;	/*КдіцНЁµАКУЖµІОКэЕдЦГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTCFG
        {
            public uint dwSize;
            public byte byScreenLayX;						//ґуЖБІјѕЦ-єбЧш±к
            public byte byScreenLayY;						//ґуЖБІјѕЦ-ЧЭЧш±к
            public ushort wOutputChanNum;					//КдіцНЁµАёцКэЈ¬0±нКѕЙи±ёЦ§іЦµДЧоґуКдіцНЁµАёцКэЈ¬ЧоґуёцКэґУДЬБ¦јЇ»сИЎЈ¬ЖдЛыЦµ±нКѕКµјККдіцНЁµАёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_OUTPUTPARAM struOutputParam;	/*КдіцНЁµАКУЖµІОКэЕдЦГ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sWallName;					//µзКУЗЅГыіЖ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ДЬБ¦јЇ*******************************/
        public const int SCREEN_PROTOCOL_NUM = 20;   //Ц§іЦµДЧоґуґуЖБїШЦЖЖчР­ТйКэ
        
        //¶аЖБ·юОсЖчДЬБ¦јЇ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENSERVER_ABILITY
        {
            public uint dwSize;   			/*Ѕб№№і¤¶И*/
            public byte byIsSupportScreenNum; /*ЛщЦ§іЦґуЖБїШЦЖЖчµДКэДї*/
            public byte bySerialNums;			//ґ®їЪёцКэ
            public byte byMaxInputNums;
            public byte byMaxLayoutNums;
            public byte byMaxWinNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byMaxScreenLayX;//ґуЖБІјѕЦ-ЧоґуєбЧш±кґуЖБКэ
            public byte byMaxScreenLayY;//ґуЖБІјѕЦ-ЧоґуЧЭЧш±кґуЖБКэ
            public ushort wMatrixProtoNum; /*УРР§µДґуЖБР­ТйКэДї*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SCREEN_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struScreenProto;/*ЧоґуР­ТйБР±н*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //¶аЖБїШЦЖЖчДЬБ¦јЇ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENCONTROL_ABILITY
        {
            public uint dwSize;   		/*Ѕб№№і¤¶И*/
            public byte byLayoutNum; 		/* ІјѕЦёцКэ*/
            public byte byWinNum; 			/*ЖБД»ґ°їЪёцКэ*/
            public byte byOsdNum;  		/*OSDёцКэ*/
            public byte byLogoNum; 		/*LogoёцКэ*/
            public byte byInputStreamNum;  //КдИлФґёцКэ ---Йи±ёЦ§іЦЧоґуКдИлНЁµАёцКэЈЁ°ьАЁ±ѕµШКдИлФґєННшВзКдИлФґЈ©
            public byte byOutputChanNum;	//КдіцНЁµАёцКэ---Йи±ёЦ§іЦЧоґуКдіцНЁµАёцКэ
            public byte byCamGroupNum;		/*·ЦЧйёцКэ*/
            public byte byPlanNum;    		/*Ф¤°ёёцКэ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byIsSupportPlayBack;  /*КЗ·сЦ§іЦ»Ш·Е*/	
            public byte byMatrixInputNum;  //Ц§іЦКдИлѕШХуЧоґуёцКэ
            public byte byMatrixOutputNum; //Ц§іЦКдіцѕШХуЧоґуёцКэ
            public NET_DVR_DISPINFO struVgaInfo;//VGAКдіцРЕПў
            public NET_DVR_DISPINFO struBncInfo;//BNCКдіцРЕПў
            public NET_DVR_DISPINFO struHdmiInfo;//HDMIКдіцРЕПў
            public NET_DVR_DISPINFO struDviInfo;//DVIКдіцРЕПў
            public byte byMaxUserNums;//Ц§іЦУГ»§Кэ
            public byte byPicSpan;		//µЧНјїз¶ИЈ¬Т»ХЕµЧНјЧо¶аїЙёІёЗµДЖБД»Кэ
            public ushort wDVCSDevNum;	//·ЦІјКЅґуЖБїШЦЖЖчЧоґуЙи±ёКэ
            public ushort wNetSignalNum;	//ЧоґуНшВзКдИлФґёцКэ
            public ushort wBaseCoordinateX;//»щЧјЧш±к
            public ushort wBaseCoordinateY; 
            public byte byExternalMatrixNum;	//ЧоґуНвЅУѕШХуёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************КдИлРЕєЕЧґМ¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGINPUTSTATUS
        {
            public uint dwLostFrame;		/*КУЖµКдИл¶ЄЦЎКэ*/
            public byte byHaveSignal;		/*КЗ·сУРКУЖµРЕєЕКдИл*/
            public byte byVideoFormat;		/*КУЖµЦЖКЅЈ¬1ЈєNTSC,2ЈєPAL,0ЈєОЮ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } 

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_INPUTSTATUS_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_CHAN_STATUS struIpInputStatus;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGINPUTSTATUS struAnalogInputStatus;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTATUS
        {
            public ushort wInputNo;		/*РЕєЕФґРтєЕ*/
            public byte byInputType;	//јыNET_DVR_CAM_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_INPUTSTATUS_UNION struStatusUnion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINPUTSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwNums;		//Йи±ё·µ»ШµДКдИлФґЧґМ¬µДКэБї
            public IntPtr pBuffer;	//»єіеЗш
            public uint dwBufLen;	//Лщ·ЦЕдЦёХлі¤¶ИЈ¬КдИлІОКэ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENALARMCFG
        {
            public uint dwSize;
            public byte byAlarmType;	//±ЁѕЇАаРНЈ¬1-ЧУ°е°ОіцЈ¬2-ЧУ°еІеИлЈ¬3-ЧУПµНіЧґМ¬ТміЈЈ¬4-ЧУПµНі»Цёґ»Цёґ 5-КдИлФґТміЈ   6-ОВ¶И±ЁѕЇ 7-FPGA°ж±ѕІ»ЖҐЕд 8-Ф¤°ёїЄКј 9-Ф¤°ёЅбКш 10-ЅвВл°е¶ПНш 11-ЅвВл°еIPµШЦ·іеН»Ј¬12-·зЙИТміЈ
            public byte byBoardType;	// 1-КдИл°е 2-Кдіц°е Ј¬3-Цч°еЈ¬4-±і°еЈ¬±ЁѕЇАаРНОЄ1Ј¬2Ј¬3Ј¬6µДК±єтК№УГ 
            public byte bySubException;	//КдИлТміЈК±ѕЯМеЧУТміЈ 1- ·Ц±жВКХэіЈёД±д 2-КдИл¶ЛїЪАаРНёД±д3-·Ц±жВКґнОу4-·Ц±жВКёД±дµјЦВЅвВлЧКФґІ»ЧгЈ¬№Ш±ХёГКдИлФґ¶ФУ¦ґ°їЪЎЈ5-·Ц±жВКёД±дЈ¬µјЦВТСїЄґ°µДЛх·Е±ИАэІ»ФЪ1/8µЅ8±¶·¶О§ЎЈ6-·Ц±жВК»ЦёґХэіЈ,7-·Ц±жВКёД±дµјЦВКдіц°еКэѕЭБїі¬ПЮ,Йи±ё№Ш±Хґ°їЪ 
            public byte byRes1;
            public ushort wStartInputNum; // ТміЈКдИлФґЈЁТміЈЖрµгЈ© 
            public ushort wEndInputNum;	// ТміЈКдИлФґЈЁТміЈЦХµгЈ© 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CFG
        {
            public byte byValid;				//ЕР¶ПКЗ·сКЗДЈДвѕШХуЈЁКЗ·сУРР§Ј©
            public byte byCommandProtocol;	//ДЈДвѕШХуµДЦёБоЈЁ4ЦЦЈ©
            public byte byScreenType;			//±ЈБф	
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byScreenToMatrix;	//ДЈДвѕШХуµДКдіцУлЖБД»µД¶ФУ¦№ШПµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIGITALSCREEN
        {
            public NET_DVR_IPADDR  struAddress;/*Йи±ёОЄКэЧЦЙи±ёК±µДIPРЕПў*/
            public ushort wPort;		//НЁµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGSCREEN
        {
            public byte byDevSerPortNum;   /*Б¬ЅУЙи±ёµДґ®їЪєЕ*/
            public byte byScreenSerPort;  /*Б¬ЅУґуЖБµДґ®їЪєЕ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
            public NET_DVR_MATRIX_CFG struMatrixCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_DIGITALSCREEN struDigitalScreen;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGSCREEN struAnalogScreen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_SCREENINFO
        {
            public uint dwSize;
            public byte byValid;				//КЗ·сУРР§
            public byte nLinkMode;				//Б¬ЅУ·ЅКЅЈ¬0-ґ®їЪЈ¬1-НшїЪ
            public byte byDeviceType;			//Йи±ёРНєЕЈ¬ДЬБ¦јЇ»сИЎ
            public byte byScreenLayX;			//ґуЖБІјѕЦ-єбЧш±к
            public byte byScreenLayY;			//ґуЖБІјѕЦ-ЧЭЧш±к
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*µЗВјУГ»§Гы*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /*µЗВјГЬВл*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;	/*Йи±ёГыіЖ*/
            public NET_DVR_SCREEN_UNION struScreenUnion;
            public byte byInputNum;			// КдИлФґёцКэ
            public byte byOutputNum;			// КдіцФґёцКэ
            public byte byCBDNum;				//CBDёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************µЧНјЙПґ«*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASEMAP_CFG
        {	
            public byte byScreenIndex;         //ЖБД»µДРтєЕ
            public byte byMapNum;				/*±»·ЦёоіЙБЛ¶аЙЩїй*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
            public ushort wSourWidth;			/* Ф­НјЖ¬µДїн¶И */
            public ushort wSourHeight;			/* Ф­НјЖ¬µДёЯ¶И */
        }            

        /*******************************OSD*******************************/
        public const int MAX_OSDCHAR_NUM = 256;
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSDCFG
        {
            public uint dwSize;
            public byte byValid;    /*КЗ·сУРР§ 0ОЮР§ 1УРР§*/
            public byte byDispMode;  //ПФКѕДЈКЅЈ¬1-НёГчЈ¬2-°лНёГчЈ¬3-ёІёЗИэЦЦДЈКЅ
            public byte byFontColorY; /*ЧЦМеСХЙ«Y,0-255*/
            public byte byFontColorU; /*ЧЦМеСХЙ«U,0-255*/
            public byte byFontColorV; /*ЧЦМеСХЙ«V,0-255*/
            public byte byBackColorY; /*±іѕ°СХЙ«Y,0-255*/
            public byte byBackColorU; /*±іѕ°СХЙ«U,0-255*/
            public byte byBackColorV; /*±іѕ°СХЙ«V,0-255*/
            public ushort wXCoordinate;   /*OSDФЪЖБД»ЧуЙПЅЗО»ЦГx*/
            public ushort wYCoordinate;   /*OSDФЪЖБД»ЧуЙПЅЗО»ЦГy*/
            public ushort wWidth;       /*OSDїн¶И*/
            public ushort wHeight;      /*OSDёЯ¶И*/
            public uint dwCharCnt;     /*ЧЦ·ыµДёцКэ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSDCHAR_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOSDChar;       /*OSDЧЦ·ыДЪИЭ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************»сИЎґ®їЪРЕПў*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CONTROL
        { 
            public uint dwSize ;
            public byte bySerialNum;        // ґ®їЪёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] bySerial;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************ЖБД»їШЦЖ*******************************/
        //ЖБД»КдИлФґїШЦЖ
        public enum INPUT_INTERFACE_TYPE
        {
	        INTERFACE_VGA = 0,
	        INTERFACE_SVIDEO, // 2046NLІ»Ц§іЦЈ¬2046NHЦ§іЦ
	        INTERFACE_YPBPR,
	        INTERFACE_DVI ,
	        INTERFACE_BNC , 
	        INTERFACE_DVI_LOOP,//(»·НЁ) 2046NHІ»Ц§іЦЈ¬2046NLЦ§іЦ
	        INTERFACE_BNC_LOOP, //(»·НЁ) 2046NHІ»Ц§іЦЈ¬2046NL.Ц§іЦ
	        INTERFACE_HDMI,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_INTERFACE_CTRL
        {
            public byte byInputSourceType;	//јыINPUT_INTERFACE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //ПФКѕµҐФЄСХЙ«їШЦЖ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_COLOR_CTRL
        {
            public byte byColorType;		//1-ББ¶И 2-¶Ф±И¶И 3-±ҐєН¶И 4-ЗеОъ¶И
            public char	byScale;			//-1 Ўў0Ўў+1ИэёцЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ПФКѕµҐФЄО»ЦГїШЦЖ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_POSITION_CTRL
        {
            public byte byPositionType;	//1-Л®ЖЅО»ЦГ 2-ґ№Ц±О»ЦГЈ¬
            public char byScale;			//-1 Ўў0Ўў+1ИэёцЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_CONTROL_PARAM
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_INPUT_INTERFACE_CTRL struInputCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_COLOR_CTRL struDisplayCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_POSITION_CTRL struPositionCtrl;
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL
        { 	
            public uint dwSize;			 
            public uint dwCommand ;      /* їШЦЖ·Ѕ·Ё 1-їЄ 2-№Ш 3-ЖБД»КдИлФґСЎФс 4-ПФКѕµҐФЄСХЙ«їШЦЖ 5-ПФКѕµҐФЄО»ЦГїШЦЖ*/
            public byte byProtocol;      //ґ®їЪР­ТйАаРН,1:LCD-S1,2:LCD-S2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	
        }

        /*******************************ЖБД»їШЦЖV41*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL_V41
        { 	
            public uint dwSize;
            public byte bySerialNo;		//ґ®їЪєЕ
            public byte byBeginAddress;	//ЧуЙПЅЗЖБД»єЕЈ¬ґУ1їЄКј
            public byte byEndAddress;	//УТПВЅЗЖБД»єЕЈ¬ґУ1їЄКј
            public byte byProtocol;      	   // ґ®їЪР­ТйАаРН  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 Ј¬ 4-LCD-DLPЈ¬ 5-LCD-S3 , 6-LCD-H1 
            public uint dwCommand ;      /* їШЦЖ·Ѕ·Ё 1-їЄ 2-№Ш 3-ЖБД»КдИлФґСЎФс 4-ПФКѕµҐФЄСХЙ«їШЦЖ 5-ПФКѕµҐФЄО»ЦГїШЦЖ*/
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            public byte byWallNo;		// µзКУЗЅєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        /*******************************Ф¤°ё№ЬАн*******************************/
        public const int MAX_PLAN_ACTION_NUM = 32; 	//Ф¤°ё¶ЇЧчёцКэ
        public const int DAYS_A_WEEK = 7;	//Т»ЦЬ7Мм
        public const int MAX_PLAN_COUNT = 16;	//Ф¤°ёёцКэ

        public enum NET_DVR_PLAN_OPERATE_TYPE
        {
	        NET_DVR_SWITCH_LAYOUT = 1, 		// ІјѕЦЗР»» Д¬ИП
	        NET_DVR_SCREEN_POWER_OFF,  		// №Ш±ХґуЖБД»ПФКѕ
	        NET_DVR_SCREEN_POWER_ON,   		// ґтїЄґуЖБД»ПФКѕ
        }

        /*Ф¤°ёПоРЕПў*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_INFO
        {
            public byte byValid;      	// ёГПоКЗ·сУРР§
            public byte byType;       	// јы¶ЁТеNET_DVR_PLAN_OPERATE_TYPE
            public ushort wLayoutNo;  	// ІјѕЦєЕ
            public byte byScreenStyle;    //ЖБД»РНєЕЈ¬їЄ№Ш»ъЛщУГЈ¬1КЗµНББЈ¬2КЗёЯББ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDelayTime;  	// Т»ёцПоµДФЛРРК±јд, µҐО»Гл
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYCLE_TIME
        {
            public byte byValid; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_EX struTime;
        }

        /*Ф¤°ё№ЬАн*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_CFG
        {
            public uint dwSize;
            public byte byValid;      	// ёГФ¤°ёКЗ·сУРР§
            public byte byWorkMode;  	// Ф¤°ё№¤ЧчДЈКЅ 1±нКѕКЦ¶ЇЈ¬2ЧФ¶ЇЈ¬3Ф¤°ёС­»·
            public byte byWallNo;		//µзКУЗЅєЕЈ¬ґУ1їЄКј
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlanName; //Ф¤°ёГыіЖ
            public NET_DVR_TIME_EX struTime; // №¤ЧчДЈКЅОЄЧФ¶ЇК±К№УГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DAYS_A_WEEK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYCLE_TIME[] struTimeCycle; /*С­»·К±јдЈ¬ЦЬЖЪОЄТ»ёцРЗЖЪЈ¬ДкЎўФВЎўИХИэёцІОКэІ»К№УГЎЈИзЈєstruTimeCycle[0]ЦРµДbyValidµДЦµКЗ1Ј¬±нКѕРЗЖЪМмЦґРРёГФ¤°ёЎЈРЗЖЪИЎЦµЗшјдОЄ[0,6]Ј¬ЖдЦР0ґъ±нРЗЖЪМмЈ¬1ґъ±нРЗЖЪТ»Ј¬ТФґЛАаНЖ*/
            public uint dwWorkCount;  	// Ф¤°ёДЪИЭЦґРРґОКэЈ¬0ОЄТ»Ц±С­»·ІҐ·ЕЈ¬ЖдЛыЦµ±нКѕґОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLAN_ACTION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PLAN_INFO[] strPlanEntry;  // Ф¤°ёЦґРРµДДЪИЭ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»сИЎЙи±ёЧґМ¬*******************************/
        /*Ф¤°ёБР±н*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_LIST
        {
            public uint dwSize;
            public uint dwPlanNums;			//Йи±ёКдИлРЕєЕФґКэБї
            public IntPtr pBuffer;			//ЦёПтdwInputSignalNumsёцNET_DVR_PLAN_CFGЅб№№ґуРЎµД»єіеЗш
            public byte byWallNo;			//ЗЅєЕЈ¬ґУ1їЄКј
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//Лщ·ЦЕд»єіеЗші¤¶ИЈ¬КдИлІОКэЈЁґуУЪµИУЪdwInputSignalNumsёцNET_DVR_PLAN_CFGЅб№№ґуРЎЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************Ф¤°ёїШЦЖ*******************************/
        //ёГЅб№№МеїЙЧчОЄНЁУГїШЦЖЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_PARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceID; //±»їШЙи±ёµДЙи±ёID
            public ushort wChan;				 //±»їШНЁµА
            public byte byIndex;			 //їШЦЖЛчТэЈ¬ёщѕЭГьБоИ·¶ЁѕЯМе±нКѕКІГґЛчТэ
            public byte byRes1;
            public uint dwControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************»сИЎЙи±ёЧґМ¬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICE_RUN_STATUS
        {
            public uint dwSize;
            public uint dwMemoryTotal;		//ДЪґжЧЬБї	µҐО»Kbyte
            public uint dwMemoryUsage;		//ДЪґжК№УГБї µҐО»Kbyte
            public byte byCPUUsage;			//CPUК№УГВК 0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //91ПµБРHD-SDIёЯЗеDVR Па»ъРЕПў
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACCESS_CAMERA_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCameraInfo;		// З°¶ЛПа»ъРЕПў
            public byte  byInterfaceType;		// З°¶ЛЅУИлЅУїЪАаРНЈ¬1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_INPUT_PARAM
        {
            public byte byAudioInputType;  //ТфЖµКдИлАаРНЈ¬0-mic inЈ¬1-line in
            public byte byVolume; //volume,[0-100]
            public byte byEnableNoiseFilter; //КЗ·сїЄЖфЙщТф№эВЛ-№ШЈ¬-їЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_DEHAZE_CFG
        {
            public uint dwSize;
            public byte byDehazeMode; //0-І»ЖфУГЈ¬1-ЧФ¶ЇДЈКЅЈ¬2-їЄ
            public byte byLevel; //µИј¶Ј¬0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_SIGNAL_LIST
        {
            public uint dwSize;
            public uint dwInputSignalNums;	//Йи±ёКдИлРЕєЕФґКэБї
            public IntPtr pBuffer;			//ЦёПтdwInputSignalNumsёцNET_DVR_INPUTSTREAMCFGЅб№№ґуРЎµД»єіеЗш
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//Лщ·ЦЕд»єіеЗші¤¶ИЈ¬КдИлІОКэЈЁґуУЪµИУЪdwInputSignalNumsёцNET_DVR_INPUTSTREAMCFGЅб№№ґуРЎЈ©
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //°ІИ«°ОЕМЧґМ¬
        public const int PULL_DISK_SUCCESS = 1;     // °ІИ«°ОЕМіЙ№¦
        public const int PULL_DISK_FAIL = 2;        // °ІИ«°ОЕМК§°Ь
        public const int PULL_DISK_PROCESSING = 3;  // ХэФЪНЈЦ№ХуБР
        public const int PULL_DISK_NO_ARRAY = 4;	// ХуБРІ»ґжФЪ 
        public const int PULL_DISK_NOT_SUPPORT = 5; // І»Ц§іЦ°ІИ«°ОЕМ

        //ЙЁГиХуБРЧґМ¬
        public const int SCAN_RAID_SUC = 1; 	// ЙЁГиХуБРіЙ№¦
        public const int SCAN_RAID_FAIL = 2; 	// ЙЁГиХуБРК§°Ь
        public const int SCAN_RAID_PROCESSING = 3;	// ХэФЪЙЁГиХуБР
        public const int SCAN_RAID_NOT_SUPPORT = 4; // І»Ц§іЦХуБРЙЁГи

        //ЙиЦГЗ°¶ЛПа»ъАаРНЧґМ¬
        public const int SET_CAMERA_TYPE_SUCCESS = 1;  // іЙ№¦
        public const int SET_CAMERA_TYPE_FAIL = 2;  // К§°Ь
        public const int SET_CAMERA_TYPE_PROCESSING	= 3;   // ХэФЪґ¦Ан

        //9000 2.2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
        {
            public uint dwSize;    //Ѕб№№МеґуРЎ
            public byte byType;    //0 ХэіЈТфКУЖµВјПс, 1НјЖ¬НЁµАВјПс, 2ANRНЁµАВјПс, 3ійЦЎНЁµАВјПс
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN
        {
            public uint dwSize;        //Ѕб№№МеґуРЎ
            public NET_DVR_TIME strBeginTime;  //їЄКјК±јд
            public NET_DVR_TIME strEndTime;    //ЅбКшК±јд
            public byte byType;        //0 ХэіЈТфКУЖµВјПс, 1НјЖ¬НЁµАВјПс, 2ANRНЁµАВјПс, 3ійЦЎНЁµАВјПс
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DRAWFRAME_DISK_QUOTA_CFG
        {
            public uint dwSize;					//Ѕб№№МеґуРЎ
            public byte byPicQuota;				//НјЖ¬°Щ·Ц±И	 [0%,  30%]
            public byte byRecordQuota;				//ЖХНЁВјПс°Щ·Ц±И [20%, 40%]
            public byte byDrawFrameRecordQuota;	//ійЦЎВјПс°Щ·Ц±И [30%, 80%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					//±ЈБфЧЦЅЪ
        }

        //¶ЛїЪУіЙдЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_PORT
        {
            public ushort wEnable;
            public ushort wExtPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¶ЛїЪУіЙдЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_CFG
        {
            public uint dwSize;
            public ushort wEnableUpnp;
            public ushort wEnableNat;
            public NET_DVR_IPADDR struIpAddr;//ПДК±ЦЖНЈЦ№К±јд
            public NET_DVR_NAT_PORT struHttpPort;//ПДК±ЦЖНЈЦ№К±јд
            public NET_DVR_NAT_PORT struCmdPort;//ПДК±ЦЖНЈЦ№К±јд
            public NET_DVR_NAT_PORT struRtspPort;//ПДК±ЦЖНЈЦ№К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendName;
            public byte byNatType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_NAT_PORT struHttpsPort;//ПДК±ЦЖНЈЦ№К±јд
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Upnp¶ЛїЪУіЙдЧґМ¬Ѕб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_PORT_STATE
        {
            public uint dwEnabled;//ёГ¶ЛїЪКЗ·с±»К№ДЬУіЙд
            public ushort wInternalPort;//УіЙдЗ°µД¶ЛїЪ
            public ushort wExternalPort;//УіЙдєуµД¶ЛїЪ
            public uint dwStatus;//¶ЛїЪУіЙдЧґМ¬Јє0- ОґЙъР§Ј»1- ОґЙъР§ЈєУіЙдФґ¶ЛїЪУлДїµД¶ЛїЪРиТ»ЦВЈ»2- ОґЙъР§ЈєУіЙд¶ЛїЪєЕТС±»К№УГЈ»3- ЙъР§
            public NET_DVR_IPADDR struNatExternalIp;//УіЙдєуµДНвІїµШЦ·
            public NET_DVR_IPADDR struNatInternalIp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //Upnp¶ЛїЪУіЙдЧґМ¬Ѕб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_NAT_STATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_UPNP_PORT_STATE[] strUpnpPort;//¶ЛїЪУіЙдЧґМ¬:ЈєКэЧй0- web server¶ЛїЪЈ¬КэЧй1- №ЬАн¶ЛїЪЈ¬КэЧй2- rtsp¶Л
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAYCOND
        {
            public uint dwChannel;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame;  //0:І»ійЦЎЈ¬1ЈєійЦЎ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±ЈБф
        }

        //ВјПс»Ш·ЕЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOD_PARA
        {
            public uint dwSize; //Ѕб№№МеґуРЎ
            public NET_DVR_STREAM_INFO struIDInfo; //БчIDРЕПў
            public NET_DVR_TIME struBeginTime;//»Ш·ЕїЄКјК±јд
            public NET_DVR_TIME struEndTime;//»Ш·ЕЅбКшК±јд
            public IntPtr hWnd;//»Ш·Еґ°їЪ
            public byte byDrawFrame;//КЗ·сійЦЎЈє0- І»ійЦЎЈ¬1- ійЦЎ
            public byte byVolumeType;//0-ЖХНЁВјПсѕнЈ¬1-ґжµµѕнЈ¬ККУГУЪCVRЙи±ёЈ¬ЖХНЁѕнУГУЪНЁµАВјПсЈ¬ґжµµѕнУГУЪ±ё·ЭВјПс
            public byte byVolumeNum;//ґжµµѕнєЕ 
            public byte byRes1;//±ЈБф
            public uint dwFileIndex;//ґжµµѕнЙПµДВјПсОДјюЛчТэЈ¬ЛСЛчґжµµѕнВјПсК±·µ»ШµДЦµ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATMFINDINFO
        {
            public byte byTransactionType;       //Ѕ»ТЧАаРН 0-И«ІїЈ¬1-ІйСЇЈ¬ 2-ИЎїоЈ¬ 3-ґжїоЈ¬ 4-РЮёДГЬВлЈ¬5-ЧЄХЛЈ¬ 6-ОЮїЁІйСЇ 7-ОЮїЁґжїоЈ¬ 8-НМі® 9-НМїЁ 10-ЧФ¶ЁТе
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //±ЈБф
            public uint dwTransationAmount ;     //Ѕ»ТЧЅр¶о ;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SPECIAL_FINDINFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byLenth ;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ATMFINDINFO struATMFindInfo;	       //ATMІйСЇ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND_V40
        {
            public Int32 lChannel;
            public uint dwFileType;
            public uint dwIsLocked;
            public uint dwUseCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_OUT, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame; //0:І»ійЦЎЈ¬1ЈєійЦЎ
            public byte byFindType; //0:ІйСЇЖХНЁѕнЈ¬1ЈєІйСЇґжµµѕн
            public byte byQuickSearch; //0:ЖХНЁІйСЇЈ¬1ЈєїмЛЩЈЁИХАъЈ©ІйСЇ
            public byte bySpecialFindInfoType ;    //ЧЁУРІйСЇМхјюАаРН 0-ОЮР§Ј¬ 1-ґшATMІйСЇМхјю  
            public uint dwVolumeNum;  //ґжµµѕнєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWorkingDeviceGUID;    //№¤Чч»ъGUIDЈ¬НЁ№э»сИЎN+1µГµЅ
            public NET_DVR_SPECIAL_FINDINFO_UNION uSpecialFindInfo ;   //ЧЁУРІйСЇМхјю
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //±ЈБф
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AES_KEY_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sAESKey;  /*ВлБчјУГЬГЬФї*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  /*±ЈБфЧЦЅЪ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POE_CFG
        {
            public NET_DVR_IPADDR struIP;     //IPµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //±ЈБф
        }

        public const int MAX_PRO_PATH = 256; //ЧоґуР­ТйВ·ѕ¶і¤¶И

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CUSTOM_PROTOCAL
        {
            public uint dwSize;              //Ѕб№№МеґуРЎ
            public uint dwEnabled;           //КЗ·сЖфУГёГР­Тй0 І»ЖфУГ 1 ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string sProtocalName;   //ЧФ¶ЁТеР­ТйГыіЖ, 16О»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;          //±ЈБф,УГУЪР­ТйГыіЖА©Х№
            public uint dwEnableSubStream;   //ЧУВлБчКЗ·сЖфУГ0 І»ЖфУГ 1 ЖфУГ	
            public byte byMainProType;        //ЦчВлБчР­ТйАаРН 1 RTSP
            public byte byMainTransType;		//ЦчВлБчґ«КдАаРН 0ЈєAuto 1Јєudp 2Јєrtp over rtsp
            public ushort wMainPort;           //ЦчВлБч¶ЛїЪ	
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sMainPath;  //ЦчВлБчВ·ѕ¶	
            public byte bySubProType;         //ЧУВлБчР­ТйАаРН 1 RTSP
            public byte bySubTransType;		//ЧУВлБчґ«КдАаРН 0ЈєAuto 1Јєudp 2Јєrtp over rtsp
            public ushort wSubPort;   //ЧУВлБч¶ЛїЪ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sSubPath;   //ЧУВлБчВ·ѕ¶ 	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;          //±ЈБф
        }
     
        //Ф¤ААV40ЅУїЪ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWINFO
        {
            public Int32 lChannel;//НЁµАєЕ
            public uint dwStreamType;	// ВлБчАаРНЈ¬0-ЦчВлБчЈ¬1-ЧУВлБчЈ¬2-ВлБч3Ј¬3-ВлБч4 µИТФґЛАаНЖ
            public uint dwLinkMode;// 0ЈєTCP·ЅКЅ,1ЈєUDP·ЅКЅ,2Јє¶аІҐ·ЅКЅ,3 - RTP·ЅКЅЈ¬4-RTP/RTSP,5-RSTP/HTTP 
            public IntPtr hPlayWnd;//ІҐ·Еґ°їЪµДѕд±ъ,ОЄNULL±нКѕІ»ІҐ·ЕНјПу
            public bool bBlocked;  //0-·ЗЧиИыИЎБч, 1-ЧиИыИЎБч, Из№ыЧиИыSDKДЪІїconnectК§°ЬЅ«»бУР5sµДі¬К±ІЕДЬ№»·µ»Ш,І»ККєПУЪВЦСЇИЎБчІЩЧч.
            public bool bPassbackRecord; //0-І»ЖфУГВјПс»Шґ«,1ЖфУГВјПс»Шґ«
            public byte byPreviewMode;//Ф¤ААДЈКЅЈ¬0-ХэіЈФ¤ААЈ¬1-СУіЩФ¤АА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStreamID;//БчIDЈ¬lChannelОЄ0xffffffffК±ЖфУГґЛІОКэ
            public byte byProtoType; //У¦УГІгИЎБчР­ТйЈ¬0-ЛЅУРР­ТйЈ¬1-RTSPР­Тй
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        ///ЧҐЕД»ъ
        ///
        public const int MAX_OVERLAP_ITEM_NUM = 50;       //ЧоґуЧЦ·ыµюјУЦЦКэ
        public const int NET_ITS_GET_OVERLAP_CFG = 5072;//»сИЎЧЦ·ыµюјУІОКэЕдЦГЈЁПа»ъ»тITSЦХ¶ЛЈ©
        public const int NET_ITS_SET_OVERLAP_CFG = 5073;//ЙиЦГЧЦ·ыµюјУІОКэЕдЦГЈЁПа»ъ»тITSЦХ¶ЛЈ©

        //ЧЦ·ыµюјУЕдЦГМхјюІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAPCFG_COND
        {
            public uint dwSize;
            public uint dwChannel;//НЁµАєЕ 
            public uint dwConfigMode;//ЕдЦГДЈКЅЈє0- ЦХ¶ЛЈ¬1- З°¶Л(Ц±Б¬З°¶Л»тЦХ¶ЛЅУЗ°¶Л)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //µҐМхЧЦ·ыµюјУРЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_SINGLE_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            public byte byItemType;//АаРН
            public byte byChangeLineNum;//µюјУПоєуµД»»РРКэЈ¬ИЎЦµ·¶О§Јє[0,10]Ј¬Д¬ИПЈє0 
            public byte bySpaceNum;//µюјУПоєуµДїХёсКэЈ¬ИЎЦµ·¶О§Јє[0-255]Ј¬Д¬ИПЈє0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //ЧЦ·ыґ®ІОКэЕдЦГЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OVERLAP_ITEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_OVERLAP_SINGLE_ITEM_PARAM[] struSingleItem;//ЧЦ·ыґ®ДЪИЭРЕПў
            public uint dwLinePercent;
            public uint dwItemsStlye;
            public ushort wStartPosTop;
            public ushort wStartPosLeft;
            public ushort wCharStyle;
            public ushort wCharSize;
            public ushort wCharInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//±ЈБф
            public uint dwForeClorRGB;//З°ѕ°Й«µДRGBЦµЈ¬bit0~bit7: BЈ¬bit8~bit15: GЈ¬bit16~bit23: RЈ¬Д¬ИПЈєx00FFFFFF-°Ч
            public uint dwBackClorRGB;//±іѕ°Й«µДRGBЦµЈ¬Ц»¶ФНјЖ¬НвµюјУУРР§Ј¬bit0~bit7: BЈ¬bit8~bit15: GЈ¬bit16~bit23: RЈ¬Д¬ИПЈєx00000000-єЪ 
            public byte byColorAdapt;//СХЙ«КЗ·сЧФККУ¦Јє0-·сЈ¬1-КЗ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБф
        }

        //ЧЦ·ыµюјУДЪИЭРЕПўЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_INFO_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] bySite;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoadNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byInstrumentNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirection;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectionDesc;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneDes;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite1;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite2;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ 
        }

        //ЧЦ·ыµюјУЕдЦГМхјюІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_CFG
        {
            public uint dwSize;
            public byte byEnable;//КЗ·сЖфУГЈє0- І»ЖфУГЈ¬1- ЖфУГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ
            public NET_ITS_OVERLAP_ITEM_PARAM struOverLapItem;//ЧЦ·ыґ®ІОКэ
            public NET_ITS_OVERLAP_INFO_PARAM struOverLapInfo;//ЧЦ·ыґ®ДЪИЭРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ 
        }

        //±ЁѕЇІј·АІОКэЅб№№Ме
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SETUPALARM_PARAM
        {
            public uint dwSize;
            public byte byLevel;//Іј·АУЕПИј¶Јє0- Т»µИј¶ЈЁёЯЈ©Ј¬1- ¶юµИј¶ЈЁЦРЈ©Ј¬2- ИэµИј¶ЈЁµНЈ¬±ЈБфЈ©
            public byte byAlarmInfoType;//ЙПґ«±ЁѕЇРЕПўАаРНЈЁЦЗДЬЅ»НЁЙгПс»ъЦ§іЦЈ©Јє0- АП±ЁѕЇРЕПўЈЁNET_DVR_PLATE_RESULTЈ©Ј¬1- РВ±ЁѕЇРЕПў(NET_ITS_PLATE_RESULT) 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//ХвАп±ЈБфТфЖµµДС№ЛхІОКэ 
        }           
        /********************************ЅУїЪІОКэЅб№№(end)*********************************/


        /********************************SDKЅУїЪєЇКэЙщГч*********************************/

        /*********************************************************
        Function:	NET_DVR_Init
        Desc:		іхКј»ЇSDKЈ¬µчУГЖдЛыSDKєЇКэµДЗ°МбЎЈ
        Input:	
        Output:	
        Return:	TRUE±нКѕіЙ№¦Ј¬FALSE±нКѕК§°ЬЎЈ
        **********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();

        /*********************************************************
        Function:	NET_DVR_Cleanup
        Desc:		КН·ЕSDKЧКФґЈ¬ФЪЅбКшЦ®З°ЧоєуµчУГ
        Input:	
        Output:	
        Return:	TRUE±нКѕіЙ№¦Ј¬FALSE±нКѕК§°Ь
        **********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

        /*********************************************************
        Function:	EXCEPYIONCALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void EXCEPYIONCALLBACK(uint dwType, int lUserID, int lHandle, IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser);


        /*********************************************************
        Function:	MESSCALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACK(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack);

        /*********************************************************
        Function:	MESSCALLBACKEX
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKEX(int iCommand, int iUserID, string pBuf, uint dwBufLen);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX);

        /*********************************************************
        Function:	MESSCALLBACKNEW
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKNEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW);

        /*********************************************************
        Function:	MESSAGECALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSAGECALLBACK(int lCommand, System.IntPtr sDVRIP, System.IntPtr pBuf, uint dwBufLen, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser);


        /*********************************************************
        Function:	MSGCallBack
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);

        [DllImport("HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();

        [DllImport("HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKBuildVersion();

        [DllImport("HCNetSDK.dll")]
        public static extern Int32 NET_DVR_IsSupport();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartListen_V30(String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen_V30(Int32 lListenHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout(int iUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();

        [DllImport("HCNetSDK.dll")]
        public static extern string NET_DVR_GetErrorMsg(ref int pErrorNo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, byte[] sDVRName, ushort wDVRNameLen, byte[] sDVRSerialNumber, ushort wDVRSerialLen, byte[] sGetIP, ref uint dwPort);
        //Ф¤ААПа№ШЅУїЪ
        [DllImport("HCNetSDK.dll")]
        public static extern Int32 NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern Int32 NET_SDK_RealPlay(int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo);
        /*********************************************************
		Function:	REALDATACALLBACK
		Desc:		Ф¤АА»Шµч
		Input:	lRealHandle µ±З°µДФ¤ААѕд±ъ 
				dwDataType КэѕЭАаРН
				pBuffer ґж·ЕКэѕЭµД»єіеЗшЦёХл 
				dwBufSize »єіеЗшґуРЎ 
				pUser УГ»§КэѕЭ 
		Output:	
		Return:	void
		**********************************************************/
        public delegate void REALDATACALLBACK(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser);
        [DllImport("HCNetSDK.dll")]

        /*********************************************************
        Function:	NET_DVR_RealPlay_V30
        Desc:		КµК±Ф¤ААЎЈ
        Input:	lUserID [in] NET_DVR_Login()»тNET_DVR_Login_V30()µД·µ»ШЦµ 
                lpClientInfo [in] Ф¤ААІОКэ 
                cbRealDataCallBack [in] ВлБчКэѕЭ»ШµчєЇКэ 
                pUser [in] УГ»§КэѕЭ 
                bBlocked [in] ЗлЗуВлБч№эіМКЗ·сЧиИыЈє0Ј­·сЈ»1Ј­КЗ 
        Output:	
        Return:	1±нКѕК§°ЬЈ¬ЖдЛыЦµЧчОЄNET_DVR_StopRealPlayµИєЇКэµДѕд±ъІОКэ
        **********************************************************/
        public static extern int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked);

        /*********************************************************
        Function:	NET_DVR_RealPlay_V40
        Desc:		КµК±Ф¤ААА©Х№ЅУїЪЎЈ
        Input:	lUserID [in] NET_DVR_Login()»тNET_DVR_Login_V30()µД·µ»ШЦµ 
                lpPreviewInfo [in] Ф¤ААІОКэ 
                fRealDataCallBack_V30 [in] ВлБчКэѕЭ»ШµчєЇКэ 
                pUser [in] УГ»§КэѕЭ 
        Output:	
        Return:	1±нКѕК§°ЬЈ¬ЖдЛыЦµЧчОЄNET_DVR_StopRealPlayµИєЇКэµДѕд±ъІОКэ
        **********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser);

       // [DllImport("HCNetSDK.dll")]
       // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        /*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		НЈЦ№Ф¤ААЎЈ
		Input:	lRealHandle [in] Ф¤ААѕд±ъЈ¬NET_DVR_RealPlay»тХЯNET_DVR_RealPlay_V30µД·µ»ШЦµ 
		Output:	
		Return:	
		**********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

        /*********************************************************
        Function:	DRAWFUN
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void DRAWFUN(int lRealHandle, IntPtr hDc, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber(Int32 lRealHandle, uint dwBufNum);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame(Int32 lRealHandle, uint dwNum);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound(Int32 lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare(Int32 lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare(Int32 lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume(Int32 lRealHandle, ushort wVolume);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData(Int32 lRealHandle, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData(Int32 lRealHandle);

        /*********************************************************
        Function:	REALDATACALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SETREALDATACALLBACK(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser);

        /*********************************************************
        Function:	STDDATACALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void STDDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser);


        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture(Int32 lRealHandle, string sPicFileName);

        //¶ЇМ¬ЙъіЙIЦЎ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame(Int32 lUserID, Int32 lChannel);//ЦчВлБч

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrameSub(Int32 lUserID, Int32 lChannel);//ЧУВлБч

        //ФЖМЁїШЦЖПа№ШЅУїЪ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl(Int32 lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl_Other(Int32 lUserID, int lChannel);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl(Int32 lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other(Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ(Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        //ОДјюІйХТУл»Ш·Е
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V40(int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V40(int lUserID, ref NET_DVR_FILECOND_V40 pFindCond);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose_V30(int lFindHandle);

        //2007-04-16ФцјУІйСЇЅб№ыґшїЁєЕµДОДјюІйХТ
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pVodPara);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue);
        
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);

        /*********************************************************
        Function:	PLAYDATACALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void PLAYDATACALLBACK(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser);


        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);

        //Йэј¶
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);

        //Ф¶іМёсКЅ»ЇУІЕМ
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

        //±ЁѕЇ
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);

        //УпТф¶ФЅІ
        /*********************************************************
        Function:	VOICEDATACALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACK(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        /*********************************************************
        Function:	VOICEDATACALLBACKV30
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);


        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

        //УпТфЧЄ·ў
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

        //УпТф№гІҐ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();

        /*********************************************************
        Function:	VOICEAUDIOSTART
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEAUDIOSTART(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser);


        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);


        //НёГчНЁµАЙиЦГ
        /*********************************************************
        Function:	SERIALDATACALLBACK
        Desc:		(»ШµчєЇКэ)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SERIALDATACALLBACK(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser);

        //485ЧчОЄНёГчНЁµАК±Ј¬РиТЄЦёГчНЁµАєЕЈ¬ТтОЄІ»Н¬НЁµАєЕ485µДЙиЦГїЙТФІ»Н¬(±ИИзІЁМШВК)
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

        //ЅвВл nBitrate = 16000
        [DllImport("HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_InitG722Decoder(int nBitrate);

        [DllImport("HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

        //±аВл
        [DllImport("HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Encoder();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport("HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

        //Ф¶іМїШЦЖ±ѕµШПФКѕ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);

        //Ф¶іМїШЦЖЙи±ё¶ЛКЦ¶ЇВјПс
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);

        //ЅвВлїЁ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDevice_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDraw_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshSurface_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClearSurface_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreSurface_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetCardLastError_Card();

        [DllImport("HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);

        //»сИЎЅвВлїЁРтБРєЕґЛЅУїЪОЮР§Ј¬ёДУГGetBoardDetailЅУїЪ»сµГ(2005-12-08Ц§іЦ)
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

        //ИХЦѕ
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose(int lLogHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);

        //ЅШЦ№2004Дк8ФВ5ИХ,№І113ёцЅУїЪ
        //ATM DVR
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);


        //2005-09-15
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);

        //JPEGЧҐНјµЅДЪґж
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

        //2006-02-16
        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

        //2006-08-28 704-640 Лх·ЕЕдЦГ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        //2006-08-28 ATM»ъ¶ЛїЪЙиЦГ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort);

        //2006-11-10 Ц§іЦПФїЁёЁЦъКдіц
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDrawDevice();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDrawDevice();

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame);

        //ЅвВлЙи±ёDS-6001D/DS-6001F
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState);

        //2005-08-01
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus);

        //¶аВ·ЅвВлЖч
        //2007-11-30 V211Ц§іЦТФПВЅУїЪ //11
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);

        //2007-12-22 ФцјУЦ§іЦЅУїЪ //18
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);

        //2009-4-13 РВФц
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);


        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer);

        public const int NET_DVR_SHOWLOGO = 1;/*ПФКѕLOGO*/
        public const int NET_DVR_HIDELOGO = 2;/*ТюІШLOGO*/

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg);

        /*ПФКѕНЁµАГьБоВл¶ЁТе*/
        //ЙПєЈКАІ© ¶ЁЦЖ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);


        public const int DISP_CMD_ENLARGE_WINDOW = 1;	/*ПФКѕНЁµА·ЕґуДіёцґ°їЪ*/
        public const int DISP_CMD_RENEW_WINDOW = 2;	/*ПФКѕНЁµАґ°їЪ»№Ф­*/

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

        //end
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

        //»ЦёґД¬ИПЦµ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);

        //±ЈґжІОКэ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig(int lUserID);

        //ЦШЖф
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR(int lUserID);

        //№Ш±ХDVR
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);

        //ІОКэЕдЦГ begin
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAtmProtocol(int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);

        //»сИЎUPNP¶ЛїЪУіЙдЧґМ¬
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetUpnpNatState(int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState);

        //КУЖµІОКэµчЅЪ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        //ЕдЦГОДјю
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);

        //ЖфУГИХЦѕОДјюРґИлЅУїЪ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg);

        //З°Гж°еЛш¶Ё
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_LockPanel(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_UnLockPanel(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize);

        //КУЖµЧЫєПЖЅМЁ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);

        //SDK_V222
        //ЦЗДЬЙи±ёАаРН
        public const int DS6001_HF_B = 60;//РРОЄ·ЦОцЈєDS6001-HF/B
        public const int DS6001_HF_P = 61;//іµЕЖК¶±рЈєDS6001-HF/P
        public const int DS6002_HF_B = 62;//Л«»ъёъЧЩЈєDS6002-HF/B
        public const int DS6101_HF_B = 63;//РРОЄ·ЦОцЈєDS6101-HF/B
        public const int IDS52XX = 64;//ЦЗДЬ·ЦОцТЗIVMS
        public const int DS9000_IVS = 65;//9000ПµБРЦЗДЬDVR
        public const int DS8004_AHL_A = 66;//ЦЗДЬATM, DS8004AHL-S/A
        public const int DS6101_HF_P = 67;//іµЕЖК¶±рЈєDS6101-HF/P

        //ДЬБ¦»сИЎГьБо
        public const int VCA_DEV_ABILITY = 256;//Йи±ёЦЗДЬ·ЦОцµДЧЬДЬБ¦
        public const int VCA_CHAN_ABILITY = 272;//РРОЄ·ЦОцДЬБ¦
        public const int MATRIXDECODER_ABILITY = 512;//¶аВ·ЅвВлЖчПФКѕЎўЅвВлДЬБ¦
        //»сИЎ/ЙиЦГґуЅУїЪІОКэЕдЦГГьБо
        //іµЕЖК¶±рЈЁNET_VCA_PLATE_CFGЈ©
        public const int NET_DVR_SET_PLATECFG = 150;//ЙиЦГіµЕЖК¶±рІОКэ
        public const int NET_DVR_GET_PLATECFG = 151;//»сИЎіµЕЖК¶±рІОКэ
        //РРОЄ¶ФУ¦ЈЁNET_VCA_RULECFGЈ©
        public const int NET_DVR_SET_RULECFG = 152;//ЙиЦГРРОЄ·ЦОц№жФт
        public const int NET_DVR_GET_RULECFG = 153;//»сИЎРРОЄ·ЦОц№жФт

        //Л«ЙгПс»ъ±к¶ЁІОКэЈЁNET_DVR_LF_CFGЈ©
        public const int NET_DVR_SET_LF_CFG = 160;//ЙиЦГЛ«ЙгПс»ъµДЕдЦГІОКэ
        public const int NET_DVR_GET_LF_CFG = 161;//»сИЎЛ«ЙгПс»ъµДЕдЦГІОКэ

        //ЦЗДЬ·ЦОцТЗИЎБчЕдЦГЅб№№
        public const int NET_DVR_SET_IVMS_STREAMCFG = 162;//ЙиЦГЦЗДЬ·ЦОцТЗИЎБчІОКэ
        public const int NET_DVR_GET_IVMS_STREAMCFG = 163;//»сИЎЦЗДЬ·ЦОцТЗИЎБчІОКэ

        //ЦЗДЬїШЦЖІОКэЅб№№
        public const int NET_DVR_SET_VCA_CTRLCFG = 164;//ЙиЦГЦЗДЬїШЦЖІОКэ
        public const int NET_DVR_GET_VCA_CTRLCFG = 165;//»сИЎЦЗДЬїШЦЖІОКэ

        //ЖБ±ОЗшУтNET_VCA_MASK_REGION_LIST
        public const int NET_DVR_SET_VCA_MASK_REGION = 166;//ЙиЦГЖБ±ОЗшУтІОКэ
        public const int NET_DVR_GET_VCA_MASK_REGION = 167;//»сИЎЖБ±ОЗшУтІОКэ

        //ATMЅшИлЗшУт NET_VCA_ENTER_REGION
        public const int NET_DVR_SET_VCA_ENTER_REGION = 168;//ЙиЦГЅшИлЗшУтІОКэ
        public const int NET_DVR_GET_VCA_ENTER_REGION = 169;//»сИЎЅшИлЗшУтІОКэ

        //±к¶ЁПЯЕдЦГNET_VCA_LINE_SEGMENT_LIST
        public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;//ЙиЦГ±к¶ЁПЯ
        public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;//»сИЎ±к¶ЁПЯ

        // ivmsЖБ±ОЗшУтNET_IVMS_MASK_REGION_LIST
        public const int NET_DVR_SET_IVMS_MASK_REGION = 172;//ЙиЦГIVMSЖБ±ОЗшУтІОКэ
        public const int NET_DVR_GET_IVMS_MASK_REGION = 173;//»сИЎIVMSЖБ±ОЗшУтІОКэ
        // ivmsЅшИлјмІвЗшУтNET_IVMS_ENTER_REGION
        public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;//ЙиЦГIVMSЅшИлЗшУтІОКэ
        public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;//»сИЎIVMSЅшИлЗшУтІОКэ

        public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;//ЙиЦГЦЗДЬ·ЦОцТЗРРОЄ№жФтІОКэ
        public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;//»сИЎЦЗДЬ·ЦОцТЗРРОЄ№жФтІОКэ

        // IVMS »Ш·ЕјмЛч
        public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;//ЙиЦГIVMS»Ш·ЕјмЛчІОКэ
        public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;//»сИЎIVMS»Ш·ЕјмЛчІОКэ        

        //Ѕб№№ІОКэєк¶ЁТе 
        public const int VCA_MAX_POLYGON_POINT_NUM = 10;//јмІвЗшУтЧо¶аЦ§іЦ10ёцµгµД¶а±ЯРО
        public const int MAX_RULE_NUM = 8;//Чо¶а№жФтМхКэ
        public const int MAX_TARGET_NUM = 30;//Чо¶аДї±кёцКэ
        public const int MAX_CALIB_PT = 6;//Чоґу±к¶ЁµгёцКэ
        public const int MIN_CALIB_PT = 4;//ЧоРЎ±к¶ЁµгёцКэ
        public const int MAX_TIMESEGMENT_2 = 2;//ЧоґуК±јд¶ОКэ
        public const int MAX_LICENSE_LEN = 16;//іµЕЖєЕЧоґуі¤¶И
        public const int MAX_PLATE_NUM = 3;//іµЕЖёцКэ
        public const int MAX_MASK_REGION_NUM = 4;//Чо¶аЛДёцЖБ±ОЗшУт
        public const int MAX_SEGMENT_NUM = 6;//ЙгПс»ъ±к¶ЁЧоґуСщ±ѕПЯКэДї
        public const int MIN_SEGMENT_NUM = 3;//ЙгПс»ъ±к¶ЁЧоРЎСщ±ѕПЯКэДї        
        /*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE±нКѕіЙ№¦Ј¬FALSE±нКѕК§°ЬЎЈ
		**********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

        //ІОКэ№ШјьЧЦ
        public enum IVS_PARAM_KEY
        {
            OBJECT_DETECT_SENSITIVE = 1,//Дї±кјмІвБйГф¶И
            BACKGROUND_UPDATE_RATE = 2,//±іѕ°ёьРВЛЩ¶И
            SCENE_CHANGE_RATIO = 3,//іЎѕ°±д»ЇјмІвЧоРЎЦµ
            SUPPRESS_LAMP = 4,//КЗ·сТЦЦЖіµН·µЖ
            MIN_OBJECT_SIZE = 5,//ДЬјмІвіцµДЧоРЎДї±кґуРЎ
            OBJECT_GENERATE_RATE = 6,//Дї±кЙъіЙЛЩ¶И
            MISSING_OBJECT_HOLD = 7,//Дї±кПыК§єујМРшёъЧЩК±јд
            MAX_MISSING_DISTANCE = 8,//Дї±кПыК§єујМРшёъЧЩѕаАл
            OBJECT_MERGE_SPEED = 9,//¶аёцДї±кЅ»ґнК±Ј¬Дї±кµДИЪєПЛЩ¶И
            REPEATED_MOTION_SUPPRESS = 10,//ЦШёґФЛ¶ЇТЦЦЖ
            ILLUMINATION_CHANGE = 11,//№вУ°±д»ЇТЦЦЖїЄ№Ш
            TRACK_OUTPUT_MODE = 12,//№мјЈКдіцДЈКЅЈє0-КдіцДї±кµДЦРРДЈ¬1-КдіцДї±кµДµЧІїЦРРД
            ENTER_CHANGE_HOLD = 13,//јмІвЗшУт±д»ЇгРЦµ
            RESUME_DEFAULT_PARAM = 255,//»ЦёґД¬ИП№ШјьЧЦІОКэ
        }

        //ЙиЦГ/»сИЎІОКэ№ШјьЧЦ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue);

        //»сИЎ/ЙиЦГРРОЄ·ЦОцДї±кµюјУЅУїЪ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        //±к¶ЁІОКэЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CALIBRATION_PARAM
        {
            public byte byPointNum;//УРР§±к¶ЁµгёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint;//±к¶ЁµгЧй
        }

        //LFЛ«ЙгПс»ъЕдЦГЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CFG
        {
            public uint dwSize;//Ѕб№№і¤¶И	
            public byte byEnable;//±к¶ЁК№ДЬ
            public byte byFollowChan;// ±»їШЦЖµДґУНЁµА
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_LF_CALIBRATION_PARAM struCalParam;//±к¶ЁµгЧй
        }

        //L/FКЦ¶ЇїШЦЖЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //L/FДї±кёъЧЩЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_TARGET_INFO
        {
            public uint dwTargetID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_MODE
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public byte byTrackMode;//ёъЧЩДЈКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЦГ0
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                [FieldOffsetAttribute(0)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;//КЦ¶ЇёъЧЩЅб№№
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;//Дї±кёъЧЩЅб№№
            }
        }

        //Л«ЙгПс»ъёъЧЩДЈКЅЙиЦГЅУїЪ
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        //К¶±ріЎѕ°
        public enum VCA_RECOGNIZE_SCENE
        {
            VCA_LOW_SPEED_SCENE = 0,//µНЛЩНЁ№эіЎѕ°ЈЁКХ·СХѕЎўРЎЗшГЕїЪЎўНЈіµіЎЈ©
            VCA_HIGH_SPEED_SCENE = 1,//ёЯЛЩНЁ№эіЎѕ°ЈЁїЁїЪЎўёЯЛЩ№«В·ЎўТЖ¶Ї»ьІй)
            VCA_MOBILE_CAMERA_SCENE = 2,//ТЖ¶ЇЙгПс»ъУ¦УГЈ© 
        }

        //К¶±рЅб№ы±кЦѕ
        public enum VCA_RECOGNIZE_RESULT
        {
            VCA_RECOGNIZE_FAILURE = 0,//К¶±рК§°Ь
            VCA_IMAGE_RECOGNIZE_SUCCESS,//НјПсК¶±ріЙ№¦
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,//КУЖµК¶±рёьУЕЅб№ы
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,//КУЖµК¶±рµЅРВµДіµЕЖ
            VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE,//КУЖµК¶±ріµЕЖЅбКш
        }

        

        //КУЖµК¶±рґҐ·ўАаРН
        public enum VCA_TRIGGER_TYPE
        {
            INTER_TRIGGER = 0,// ДЈїйДЪІїґҐ·ўК¶±р
            EXTER_TRIGGER = 1,// НвІїОпАнРЕєЕґҐ·ўЈєПЯИ¦ЎўАЧґпЎўКЦ¶ЇґҐ·ўРЕєЕЈ»
        }

        public const int MAX_CHINESE_CHAR_NUM = 64;    // ЧоґуєєЧЦАа±рКэБї
        //іµЕЖїЙ¶ЇМ¬РЮёДІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_PARAM
        {
            public NET_VCA_RECT struSearchRect;//ЛСЛчЗшУт(№йТ»»Ї)
            public NET_VCA_RECT struInvalidateRect;//ОЮР§ЗшУтЈ¬ФЪЛСЛчЗшУтДЪІї (№йТ»»Ї)
            public ushort wMinPlateWidth;//іµЕЖЧоРЎїн¶И
            public ushort wTriggerDuration;//ґҐ·ўіЦРшЦЎКэ
            public byte byTriggerType;//ґҐ·ўДЈКЅ, VCA_TRIGGER_TYPE
            public byte bySensitivity;//БйГф¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЦГ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byCharPriority;// єєЧЦУЕПИј¶
        }

        /*wMinPlateWidth:ёГІОКэД¬ИПЕдЦГОЄ80ПсЛШЈ»ёГІОКэµДЕдЦГ¶ФУЪіµЕЖєЈїµНюКУіµЕЖК¶±рЛµГчОДµµ 
	    К¶±рУРУ°ПмЈ¬Из№ыЙиЦГ№эґуЈ¬ДЗГґИз№ыіЎѕ°ЦРіцПЦРЎіµЕЖѕН»бВ©К¶±рЈ»Из№ыіЎѕ°ЦРіµЕЖїн¶ИЖХ±йЅПґуЈ¬їЙТФ°СёГІОКэЙиЦГЙФґуЈ¬±гУЪјхЙЩ¶ФРйјЩіµЕЖµДґ¦АнЎЈФЪ±кЗеЗйїцПВЅЁТйЙиЦГОЄ80Ј¬ ФЪёЯЗеЗйїцПВЅЁТйЙиЦГОЄ120
        wTriggerDuration Ј­ НвІїґҐ·ўРЕєЕіЦРшЦЎКэБїЈ¬Ждє¬ТеКЗґУґҐ·ўРЕєЕїЄКјК¶±рµДЦЎКэБїЎЈёГЦµФЪµНЛЩіЎѕ°ЅЁТйЙиЦГОЄ50Ў«100Ј»ёЯЛЩіЎѕ°ЅЁТйЙиЦГОЄ15Ў«25Ј»ТЖ¶ЇК¶±рК±Из№ыТІУРНвІїґҐ·ўЈ¬ЙиЦГОЄ15Ў«25Ј»ѕЯМеїЙТФёщѕЭПЦіЎЗйїцЅшРРЕдЦГ
        */
        //іµЕЖК¶±рІОКэЧУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATEINFO
        {
            public VCA_RECOGNIZE_SCENE eRecogniseScene;//К¶±ріЎѕ°(µНЛЩєНёЯЛЩ)
            public NET_VCA_PLATE_PARAM struModifyParam;//іµЕЖїЙ¶ЇМ¬РЮёДІОКэ
        }

        //іµЕЖК¶±рЕдЦГІОКэ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATECFG
        {
            public uint dwSize;
            public byte byPicProType;//±ЁѕЇК±НјЖ¬ґ¦Ан·ЅКЅ 0-І»ґ¦Ан 1-ЙПґ«
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЙиЦГОЄ0
            public NET_DVR_JPEGPARA struPictureParam;//НјЖ¬№жёсЅб№№
            public NET_VCA_PLATEINFO struPlateInfo;//іµЕЖРЕПў
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//Іј·АК±јд
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//ґ¦Ан·ЅКЅ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//±ЁѕЇґҐ·ўµДВјПуНЁµА,ОЄ1±нКѕґҐ·ўёГНЁµА
        }

        //іµЕЖК¶±рЅб№ыЧУЅб№№
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_VCA_PLATE_INFO
        {
            public VCA_RECOGNIZE_RESULT eResultFlag;//К¶±рЅб№ы±кЦѕ 
            public VCA_PLATE_TYPE ePlateType;//іµЕЖАаРН
            public VCA_PLATE_COLOR ePlateColor;//іµЕЖСХЙ«
            public NET_VCA_RECT struPlateRect;//іµЕЖО»ЦГ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//±ЈБфЈ¬ЙиЦГОЄ0 
            public uint dwLicenseLen;//іµЕЖі¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;//іµЕЖєЕВл 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sBelieve;//ёчёцК¶±рЧЦ·ыµДЦГРЕ¶ИЈ¬ИзјмІвµЅіµЕЖ"ХгA12345", ЦГРЕ¶ИОЄ10,20,30,40,50,60,70Ј¬Фт±нКѕ"Хг"ЧЦХэИ·µДїЙДЬРФЦ»УР10%Ј¬"A"ЧЦµДХэИ·µДїЙДЬРФКЗ20%
        }

        //іµЕЖјмІвЅб№ы
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_RESULT
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public uint dwRelativeTime;//Па¶ФК±±к
            public uint dwAbsTime;//ѕш¶ФК±±к
            public byte byPlateNum;//іµЕЖёцКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PLATE_INFO[] struPlateInfo;//іµЕЖРЕПўЅб№№
            public uint dwPicDataLen;//·µ»ШНјЖ¬µДі¤¶И ОЄ0±нКѕГ»УРНјЖ¬Ј¬ґуУЪ0±нКѕёГЅб№№єуГжЅфёъНјЖ¬КэѕЭ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes2;//±ЈБфЈ¬ЙиЦГОЄ0 НјЖ¬µДёЯїн
            public System.IntPtr pImage;//ЦёПтНјЖ¬µДЦёХл
        }

        //ЦШЖфЦЗДЬїв
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_VCA_RestartLib(int lUserID, int lChannel);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEGMENT
        {
            public NET_VCA_POINT struStartPoint;//±нКѕёЯ¶ИПЯК±Ј¬±нКѕН·Іїµг
            public NET_VCA_POINT struEndPoint;//±нКѕёЯ¶ИПЯК±Ј¬±нКѕЅЕІїµг
            public float fValue;//ёЯ¶ИЦµЈ¬µҐО»ГЧ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //±к¶ЁПЯБґ±н
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEG_LIST
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public byte bySegNum;//±к¶ЁПЯМхКэ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;//±ЈБфЈ¬ЦГ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SEGMENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_LINE_SEGMENT[] struSeg;
        }

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength);        

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        //2009-7-22 end  

        //УКјю·юОсІвКФ 9000_1.1
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_EmailTest(int lUserID);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByEvent(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam);

        [DllImport("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET lpSearchEventRet);


        //2009-8-18 ЧҐЕД»ъ
        public const int PLATE_INFO_LEN = 1024;
        public const int PLATE_NUM_LEN = 16;
        public const int FILE_NAME_LEN = 256;

        //liscense plate result
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RET
        {
            public uint dwSize;//Ѕб№№і¤¶И
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlateNum;//іµЕЖєЕ
            public byte byVehicleType;// іµАаРН
            public byte byTrafficLight;//0-ВМµЖЈ»1-ємµЖ
            public byte byPlateColor;//іµЕЖСХЙ«
            public byte byDriveChan;//ґҐ·ўіµµАєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byTimeInfo;/*К±јдРЕПў*///plate_172.6.113.64_20090724155526948_197170484 
            //ДїЗ°КЗ17О»Ј¬ѕ«И·µЅms:20090724155526948
            public byte byCarSpeed;/*µҐО»km/h*/
            public byte byCarSpeedH;/*cm/sёЯ8О»*/
            public byte byCarSpeedL;/*cm/sµН8О»*/
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_INFO_LEN - 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byInfo;
            public uint dwPicLen;
        }
        /*ЧўЈєєуГжЅфёъ dwPicLen і¤¶ИµД НјЖ¬ РЕПў*/

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserID, int lChannel, string pPicFileName, ref NET_DVR_PLATE_RET pPlateRet, string pPicBuf, uint dwPicBufLen);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CCD_CFG
        {
            public uint dwSize;//Ѕб№№і¤¶И
            public byte byBlc;/*±і№вІ№іҐ0-off; 1-on*/
            public byte byBlcMode;/*blcАаРН0-ЧФ¶ЁТе1-ЙПЈ»2-ПВЈ»3-ЧуЈ»4-УТЈ»5-ЦРЈ»ЧўЈєґЛПоФЪblcОЄ on К±ІЕЖрР§*/
            public byte byAwb;/*ЧФ¶Ї°ЧЖЅєв0-ЧФ¶Ї1; 1-ЧФ¶Ї2; 2-ЧФ¶ЇїШЦЖ*/
            public byte byAgc;/*ЧФ¶ЇФцТж0-№Ш; 1-µН; 2-ЦР; 3-ёЯ*/
            public byte byDayNight;/*ИХТ№ЧЄ»»Ј»0 ІКЙ«Ј»1єЪ°ЧЈ»2ЧФ¶Ї*/
            public byte byMirror;/*ѕµПс0-№Ш;1-ЧуУТ;2-ЙППВ;3-ЦРРД*/
            public byte byShutter;/*їмГЕ0-ЧФ¶Ї; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
            public byte byIrCutTime;/*IRCUTЗР»»К±јдЈ¬5, 10, 15, 20, 25*/
            public byte byLensType;/*ѕµН·АаРН0-µзЧУ№вИ¦; 1-ЧФ¶Ї№вИ¦*/
            public byte byEnVideoTrig;/*КУЖµґҐ·ўК№ДЬЈє1-Ц§іЦЈ»0-І»Ц§іЦЎЈКУЖµґҐ·ўДЈКЅПВКУЖµїмГЕЛЩ¶И°ґХХbyShutterЛЩ¶ИЈ¬ЧҐЕДНјЖ¬µДїмГЕЛЩ¶И°ґХХbyCapShutterЛЩ¶ИЈ¬ЧҐЕДНкіЙєу»бЧФ¶ЇµчЅЪ»ШКУЖµДЈКЅ*/
            public byte byCapShutter;/*ЧҐЕДК±µДїмГЕЛЩ¶ИЈ¬1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
            public byte byEnRecognise;/*1-Ц§іЦК¶±рЈ»0-І»Ц§іЦК¶±р*/
        }

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagCAMERAPARAMCFG
        {
            public uint dwSize;
            public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
            public uint dwWhiteBalanceMode;/*0КЦ¶Ї°ЧЖЅєв; 1ЧФ¶Ї°ЧЖЅєв1ЈЁ·¶О§РЎЈ©; 2 ЧФ¶Ї°ЧЖЅєв2ЈЁ·¶О§їнЈ¬2200K-15000KЈ©;3ЧФ¶ЇїШЦЖ3*/
            public uint dwWhiteBalanceModeRGain;/*КЦ¶Ї°ЧЖЅєвК±УРР§Ј¬КЦ¶Ї°ЧЖЅєв RФцТж*/
            public uint dwWhiteBalanceModeBGain;/*КЦ¶Ї°ЧЖЅєвК±УРР§Ј¬КЦ¶Ї°ЧЖЅєв BФцТж*/
            public uint dwExposureMode;/*0 КЦ¶ЇЖШ№в 1ЧФ¶ЇЖШ№в*/
            public uint dwExposureSet;/* 0-USERSET, 1-ЧФ¶Їx2Ј¬2-ЧФ¶Ї4Ј¬3-ЧФ¶Ї81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
            public uint dwExposureUserSet;/* ЧФ¶ЇЧФ¶ЁТеЖШ№вК±јд*/
            public uint dwExposureTarget;/*КЦ¶ЇЖШ№вК±јд ·¶О§ЈЁManumalУРР§Ј¬ОўГлЈ©*/
            public uint dwIrisMode;/*0 ЧФ¶Ї№вИ¦ 1КЦ¶Ї№вИ¦*/
            public uint dwGainLevel;/*ФцТжЈє0-100*/
            public uint dwBrightnessLevel;/*0-100*/
            public uint dwContrastLevel;/*0-100*/
            public uint dwSharpnessLevel;/*0-100*/
            public uint dwSaturationLevel;/*0-100*/
            public uint dwHueLevel;/*0-100Ј¬ЈЁ±ЈБфЈ©*/
            public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
            public uint dwGammaCorrectionLevel;/*0-100*/
            public uint dwWDREnabled;/*їн¶ЇМ¬Јє0 dsibale  1 enable*/
            public uint dwWDRLevel1;/*0-F*/
            public uint dwWDRLevel2;/*0-F*/
            public uint dwWDRContrastLevel;/*0-100*/
            public uint dwDayNightFilterType;/*ИХТ№ЗР»»Јє0 day,1 night,2 auto */
            public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(±ЈБф)*/
            //ДЈКЅ1(±ЈБф)
            public uint dwBeginTime;	/*0-100*/
            public uint dwEndTime;/*0-100*/
            //ДЈКЅ2
            public uint dwDayToNightFilterLevel;//0-7
            public uint dwNightToDayFilterLevel;//0-7
            public uint dwDayNightFilterTime;//(60Гл)
            public uint dwBacklightMode;/*±і№вІ№іҐ:0 USERSET 1 UPЎў2 DOWNЎў3 LEFTЎў4 RIGHTЎў5MIDDLE*/
            public uint dwPositionX1;//ЈЁXЧш±к1Ј©
            public uint dwPositionY1;//ЈЁYЧш±к1Ј©
            public uint dwPositionX2;//ЈЁXЧш±к2Ј©
            public uint dwPositionY2;//ЈЁYЧш±к2Ј©
            public uint dwBacklightLevel;/*0x0-0xF*/
            public uint dwDigitalNoiseRemoveEnable; /*КэЧЦИҐФлЈє0 dsibale  1 enable*/
            public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
            public uint dwMirror; /* ѕµПсЈє0 Left;1 Right,;2 Up;3Down */
            public uint dwDigitalZoom;/*КэЧЦЛх·Е:0 dsibale  1 enable*/
            public uint dwDeadPixelDetect;/*»µµгјмІв,0 dsibale  1 enable*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        public const int NET_DVR_GET_CCDPARAMCFG = 1067;       //IPC»сИЎCCDІОКэЕдЦГ
        public const int NET_DVR_SET_CCDPARAMCFG = 1068;      //IPCЙиЦГCCDІОКэЕдЦГ

        //НјПсФцЗїТЗ
        //НјПсФцЗїИҐФпЗшУтЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEREGION
        {
            public uint dwSize;//ЧЬµДЅб№№і¤¶И
            public ushort wImageRegionTopLeftX;/* НјПсФцЗїИҐФпµДЧуЙПxЧш±к */
            public ushort wImageRegionTopLeftY;/* НјПсФцЗїИҐФпµДЧуЙПyЧш±к */
            public ushort wImageRegionWidth;/* НјПсФцЗїИҐФпЗшУтµДїн */
            public ushort wImageRegionHeight;/*НјПсФцЗїИҐФпЗшУтµДёЯ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //НјПсФцЗїЎўИҐФлј¶±рј°ОИ¶ЁРФК№ДЬЕдЦГ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGESUBPARAM
        {
            public NET_DVR_SCHEDTIME struImageStatusTime;//НјПсЧґМ¬К±јд¶О
            public byte byImageEnhancementLevel;//НјПсФцЗїµДј¶±рЈ¬0-7Ј¬0±нКѕ№Ш±Х
            public byte byImageDenoiseLevel;//НјПсИҐФлµДј¶±рЈ¬0-7Ј¬0±нКѕ№Ш±Х
            public byte byImageStableEnable;//НјПсОИ¶ЁРФК№ДЬЈ¬0±нКѕ№Ш±ХЈ¬1±нКѕґтїЄ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_GET_IMAGEREGION = 1062;       //НјПсФцЗїТЗНјПсФцЗїИҐФпЗшУт»сИЎ
        public const int NET_DVR_SET_IMAGEREGION = 1063;       //НјПсФцЗїТЗНјПсФцЗїИҐФпЗшУт»сИЎ
        public const int NET_DVR_GET_IMAGEPARAM = 1064;       // НјПсФцЗїТЗНјПсІОКэ(ИҐФлЎўФцЗїј¶±рЈ¬ОИ¶ЁРФК№ДЬ)»сИЎ
        public const int NET_DVR_SET_IMAGEPARAM = 1065;       // НјПсФцЗїТЗНјПсІОКэ(ИҐФлЎўФцЗїј¶±рЈ¬ОИ¶ЁРФК№ДЬ)ЙиЦГ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEPARAM
        {
            public uint dwSize;
            //НјПсФцЗїК±јд¶ОІОКэЕдЦГЈ¬ЦЬИХїЄКј	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public tagIMAGESUBPARAM[] struImageParamSched;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode);

        /*********************************************************
        Function:	NET_DVR_Login_V30
        Desc:		
        Input:	sDVRIP [in] Йи±ёIPµШЦ· 
                wServerPort [in] Йи±ё¶ЛїЪєЕ 
                sUserName [in] µЗВјµДУГ»§Гы 
                sPassword [in] УГ»§ГЬВл 
        Output:	lpDeviceInfo [out] Йи±ёРЕПў 
        Return:	-1±нКѕК§°ЬЈ¬ЖдЛыЦµ±нКѕ·µ»ШµДУГ»§IDЦµ
        **********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);

        /*********************************************************
        Function:	NET_DVR_Logout_V30
        Desc:		УГ»§ЧўІбЙи±ёЎЈ
        Input:	lUserID [in] УГ»§IDєЕ
        Output:	
        Return:	TRUE±нКѕіЙ№¦Ј¬FALSE±нКѕК§°Ь
        **********************************************************/
        [DllImport("HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30(Int32 lUserID);











        #region  ИЎБчДЈїйПа№ШЅб№№УлЅУїЪ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PLAY_INFO
        {
            public int iUserID;      //ЧўІбУГ»§ID
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strDeviceIP;
            public int iDevicePort;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string strDevAdmin;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string strDevPsd;
            public int iChannel;      //ІҐ·ЕНЁµАєЕ(ґУ0їЄКј)
            public int iLinkMode;   //ЧоёЯО»(31)ОЄ0±нКѕЦчВлБчЈ¬ОЄ1±нКѕЧУВлБчЈ¬0Ј­30О»±нКѕВлБчБ¬ЅУ·ЅКЅ: 0ЈєTCP·ЅКЅ,1ЈєUDP·ЅКЅ,2Јє¶аІҐ·ЅКЅ,3 - RTP·ЅКЅЈ¬4-ТфКУЖµ·ЦїЄ(TCP)
            public bool bUseMedia;     //КЗ·сЖфУГБчГЅМе
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strMediaIP; //БчГЅМеIPµШЦ·
            public int iMediaPort;   //БчГЅМе¶ЛїЪєЕ
        }


        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_Init();

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_UnInit();


        [DllImport("GetStream.dll")]
        public static extern int CLIENT_SDK_GetStream(PLAY_INFO lpPlayInfo); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SetRealDataCallBack(int iRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint lUser); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_StopStream(int iRealHandle);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_GetVideoEffect(int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_SetVideoEffect(int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_MakeKeyFrame(int iRealHandle);

        #endregion


        #region VODµгІҐ·Еїв

        public const int WM_NETERROR = 0x0400 + 102;          //НшВзТміЈПыПў
        public const int WM_STREAMEND = 0x0400 + 103;		  //ОДјюІҐ·ЕЅбКш

        public const int FILE_HEAD = 0;      //ОДјюН·
        public const int VIDEO_I_FRAME = 1;  //КУЖµIЦЎ
        public const int VIDEO_B_FRAME = 2;  //КУЖµBЦЎ
        public const int VIDEO_P_FRAME = 3;  //КУЖµPЦЎ
        public const int VIDEO_BP_FRAME = 4; //КУЖµBPЦЎ
        public const int VIDEO_BBP_FRAME = 5; //КУЖµBЦЎBЦЎPЦЎ
        public const int AUDIO_PACKET = 10;   //ТфЖµ°ь

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct BLOCKTIME
        {
            public ushort wYear;
            public byte bMonth;
            public byte bDay;
            public byte bHour;
            public byte bMinute;
            public byte bSecond;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODSEARCHPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VODїН»§¶Лѕд±ъ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµДНшВзµШЦ·
            public uint dvrPort;                                            //	[in]DVRµД¶ЛїЪµШЦ·
            public uint channelNum;                                         //  [in]DVRµДНЁµАєЕ
            public BLOCKTIME startTime;                                     //	[in]ІйСЇµДїЄКјК±јд
            public BLOCKTIME stopTime;                                      //	[in]ІйСЇµДЅбКшК±јд
            public bool bUseIPServer;                                       //  [in]КЗ·сК№УГIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]Йи±ёµДРтБРєЕ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SECTIONLIST
        {
            public BLOCKTIME startTime;
            public BLOCKTIME stopTime;
            public byte byRecType;
            public IntPtr pNext;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODOPENPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VODїН»§¶Лѕд±ъ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVRµДНшВзµШЦ·
            public uint dvrPort;                                            //	[in]DVRµД¶ЛїЪµШЦ·
            public uint channelNum;                                         //  [in]DVRµДНЁµАєЕ
            public BLOCKTIME startTime;                                     //	[in]ІйСЇµДїЄКјК±јд
            public BLOCKTIME stopTime;                                      //	[in]ІйСЇµДЅбКшК±јд
            public uint uiUser;
            public bool bUseIPServer;                                       //  [in]КЗ·сК№УГIPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]Йи±ёµДРтБРєЕ

            public VodStreamFrameData streamFrameData;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CONNPARAM
        {
            public uint uiUser;
            public ErrorCallback errorCB;
        }


        // ТміЈ»ШµчєЇКэ
        public delegate void ErrorCallback(System.IntPtr hSession, uint dwUser, int lErrorType);
        //ЦЎКэѕЭ»ШµчєЇКэ
        public delegate void VodStreamFrameData(System.IntPtr hStream, uint dwUser, int lFrameType, System.IntPtr pBuffer, uint dwSize);

        //ДЈїйіхКј»Ї
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref CONNPARAM struConn, IntPtr hWnd);

        //ДЈїйПъ»Щ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerDisconnect(IntPtr hSession);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODDeleteSectionList(IntPtr pSecList);

        // ёщѕЭIDЎўК±јд¶ОґтїЄБч»сИЎБчѕд±ъ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseStream(IntPtr hStream);

        //ёщѕЭIDЎўК±јд¶ОґтїЄЕъБїПВФШ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenDownloadStream(ref VODOPENPARAM struVodParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseDownloadStream(IntPtr hStream);

        // їЄКјБчЅвОцЈ¬·ўЛНКэѕЭЦЎ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStartStreamData(IntPtr phStream);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStopStreamData(IntPtr hStream);

        // ёщѕЭК±јд¶ЁО»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);


        // ёщѕЭК±јд¶ЁО»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

        // ёщѕЭК±јд¶ЁО»
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref BLOCKTIME pCurrentTime);

        #endregion


        #region ЦЎ·ЦОцїв


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PACKET_INFO
        {
            public int nPacketType;     // packet type
            // 0:  file head
            // 1:  video I frame
            // 2:  video B frame
            // 3:  video P frame
            // 10: audio frame
            // 11: private frame only for PS


            //      [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
            public IntPtr pPacketBuffer;
            public uint dwPacketSize;
            public int nYear;
            public int nMonth;
            public int nDay;
            public int nHour;
            public int nMinute;
            public int nSecond;
            public uint dwTimeStamp;
        }



        /******************************************************************************
        * functionЈєget a empty port number
        * parametersЈє
        * returnЈє 0 - 499 : empty port number
        *          -1      : server is full  			
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetSafeHandle();


        /******************************************************************************
        * functionЈєopen standard stream data for analyzing
        * parametersЈєlHandle - working port number
        *             pHeader - pointer to file header or info header
        * returnЈєTRUE or FALSE
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);


        /******************************************************************************
        * functionЈєclose analyzing
        * parametersЈєlHandle - working port number
        * returnЈє
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataClose(int iHandle);


        /******************************************************************************
        * functionЈєinput stream data
        * parametersЈєlHandle		- working port number
        *			  pBuffer		- data pointer
        *			  dwBuffersize	- data size
        * returnЈєTRUE or FALSE
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize); //byte []


        /******************************************************************************
        * functionЈєget analyzed packet
        * parametersЈєlHandle		- working port number
        *			  pPacketInfo	- returned structure
        * returnЈє-1 : error
        *          0 : succeed
        *		   1 : failed
        *		   2 : file end (only in file mode)				
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetPacket(int iHandle, ref PACKET_INFO pPacketInfo);  //ТЄ°СpPacketInfoЧЄ»»іЙPACKET_INFOЅб№№


        /******************************************************************************
        * functionЈєget remain data from input buffer
        * parametersЈєlHandle		- working port number
        *			  pBuf	        - pointer to the mem which stored remain data
        *             dwSize        - size of remain data  
        * returnЈє TRUE or FALSE				
        * commentЈє
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);


        [DllImport("AnalyzeData.dll")]
        public static extern uint AnalyzeDataGetLastError(int iHandle);

        #endregion


        #region ВјПсїв

        public const int DATASTREAM_HEAD = 0;		//КэѕЭН·
        public const int DATASTREAM_BITBLOCK = 1;		//ЧЦЅЪКэѕЭ
        public const int DATASTREAM_KEYFRAME = 2;		//№ШјьЦЎКэѕЭ
        public const int DATASTREAM_NORMALFRAME = 3;		//·З№ШјьЦЎКэѕЭ


        public const int MESSAGEVALUE_DISKFULL = 0x01;
        public const int MESSAGEVALUE_SWITCHDISK = 0x02;
        public const int MESSAGEVALUE_CREATEFILE = 0x03;
        public const int MESSAGEVALUE_DELETEFILE = 0x04;
        public const int MESSAGEVALUE_SWITCHFILE = 0x05;




        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STOREINFO
        {
            public int iMaxChannels;
            public int iDiskGroup;
            public int iStreamType;
            public bool bAnalyze;
            public bool bCycWrite;
            public uint uiFileSize;

            public CALLBACKFUN_MESSAGE funCallback;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CREATEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileCreateTime;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CLOSEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileSwitchTime;
        }



        public delegate int CALLBACKFUN_MESSAGE(int iMessageType, System.IntPtr pBuf, int iBufLen);


        [DllImport("RecordDLL.dll")]
        public static extern int Initialize(STOREINFO struStoreInfo);

        [DllImport("RecordDLL.dll")]
        public static extern int Release();

        [DllImport("RecordDLL.dll")]
        public static extern int OpenChannelRecord(string strCameraid, IntPtr pHead, uint dwHeadLength);

        [DllImport("RecordDLL.dll")]
        public static extern bool CloseChannelRecord(int iRecordHandle);

        [DllImport("RecordDLL.dll")]
        public static extern int GetData(int iHandle, int iDataType, IntPtr pBuf, uint uiSize);

        #endregion

        //Йи±ёЗшУтЙиЦГ
        public const int REGIONTYPE = 0;//ґъ±нЗшУт
        public const int MATRIXTYPE = 11;//ѕШХуЅЪµг
        public const int DEVICETYPE = 2;//ґъ±нЙи±ё
        public const int CHANNELTYPE = 3;//ґъ±нНЁµА
        public const int USERTYPE = 5;//ґъ±нУГ»§

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOG_MATRIX
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;
            public uint dwMinorType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;
            public NET_DVR_IPADDR struRemoteHostAddr;
            public uint dwParaType;
            public uint dwChannel;
            public uint dwDiskNumber;
            public uint dwAlarmInPort;
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            public byte byDevSequence;//ІЫО»єЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµШЦ·
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//РтБРєЕ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN - SERIALNO_LEN - MACADDR_LEN - 1)]
            public string sInfo;
        }

        //КУЖµЧЫєПЖЅМЁИнјю
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagVEDIOPLATLOG
        {
            public byte bySearchCondition;//ЛСЛчМхјюЈ¬0-°ґІЫО»єЕЛСЛчЈ¬1-°ґРтБРєЕЛСЛч 2-°ґMACµШЦ·ЅшРРЛСЛч
            public byte byDevSequence;//ІЫО»єЕЈ¬0-79Јє¶ФУ¦ЧУПµНіµДІЫО»єЕЈ»
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//РтБРєЕ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MACµШЦ·
        }

        [DllImportAttribute("HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData);


        [DllImportAttribute("HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
    }
}
