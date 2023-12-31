﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Vsempoka
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Докум постав.
    /// </summary>
    // *** Start programmer edit section *** (ДокумПостав CustomAttributes)

    // *** End programmer edit section *** (ДокумПостав CustomAttributes)
    [AutoAltered()]
    [Caption("Документ поставки")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДокумПоставE", new string[] {
            "Дата as \'Дата\'",
            "НомерДокПост as \'Номер документа поставки\'",
            "Клиенты as \'Клиент\'",
            "Клиенты.Заказчик as \'Заказчик\'",
            "Организация as \'Организация\'",
            "Организация.НаимОрганиз as \'Наименование организации\'"}, Hidden=new string[] {
            "Клиенты.Заказчик",
            "Организация.НаимОрганиз"})]
    [AssociatedDetailViewAttribute("ДокумПоставE", "ИнфорОЗаказе", "ИнфорОЗаказеE", true, "", "Информация о заказе", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ДокумПоставE", "Клиенты", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Заказчик")]
    [MasterViewDefineAttribute("ДокумПоставE", "Организация", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НаимОрганиз")]
    [View("ДокумПоставL", new string[] {
            "Дата as \'Дата\'",
            "НомерДокПост as \'Номер документа поставки\'",
            "Клиенты.Заказчик as \'Заказчик\'",
            "Организация.НаимОрганиз as \'Наименование организации\'"})]
    public class ДокумПостав : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private int fНомерДокПост;
        
        private IIS.Vsempoka.Клиенты fКлиенты;
        
        private IIS.Vsempoka.Организация fОрганизация;
        
        private IIS.Vsempoka.DetailArrayOfИнфорОЗаказе fИнфорОЗаказе;
        
        // *** Start programmer edit section *** (ДокумПостав CustomMembers)

        // *** End programmer edit section *** (ДокумПостав CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (ДокумПостав.Дата CustomAttributes)

        // *** End programmer edit section *** (ДокумПостав.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (ДокумПостав.Дата Get start)

                // *** End programmer edit section *** (ДокумПостав.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (ДокумПостав.Дата Get end)

                // *** End programmer edit section *** (ДокумПостав.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумПостав.Дата Set start)

                // *** End programmer edit section *** (ДокумПостав.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (ДокумПостав.Дата Set end)

                // *** End programmer edit section *** (ДокумПостав.Дата Set end)
            }
        }
        
        /// <summary>
        /// НомерДокПост.
        /// </summary>
        // *** Start programmer edit section *** (ДокумПостав.НомерДокПост CustomAttributes)

        // *** End programmer edit section *** (ДокумПостав.НомерДокПост CustomAttributes)
        public virtual int НомерДокПост
        {
            get
            {
                // *** Start programmer edit section *** (ДокумПостав.НомерДокПост Get start)

                // *** End programmer edit section *** (ДокумПостав.НомерДокПост Get start)
                int result = this.fНомерДокПост;
                // *** Start programmer edit section *** (ДокумПостав.НомерДокПост Get end)

                // *** End programmer edit section *** (ДокумПостав.НомерДокПост Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумПостав.НомерДокПост Set start)

                // *** End programmer edit section *** (ДокумПостав.НомерДокПост Set start)
                this.fНомерДокПост = value;
                // *** Start programmer edit section *** (ДокумПостав.НомерДокПост Set end)

                // *** End programmer edit section *** (ДокумПостав.НомерДокПост Set end)
            }
        }
        
        /// <summary>
        /// Докум постав.
        /// </summary>
        // *** Start programmer edit section *** (ДокумПостав.Клиенты CustomAttributes)

        // *** End programmer edit section *** (ДокумПостав.Клиенты CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиенты"})]
        [NotNull()]
        public virtual IIS.Vsempoka.Клиенты Клиенты
        {
            get
            {
                // *** Start programmer edit section *** (ДокумПостав.Клиенты Get start)

                // *** End programmer edit section *** (ДокумПостав.Клиенты Get start)
                IIS.Vsempoka.Клиенты result = this.fКлиенты;
                // *** Start programmer edit section *** (ДокумПостав.Клиенты Get end)

                // *** End programmer edit section *** (ДокумПостав.Клиенты Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумПостав.Клиенты Set start)

                // *** End programmer edit section *** (ДокумПостав.Клиенты Set start)
                this.fКлиенты = value;
                // *** Start programmer edit section *** (ДокумПостав.Клиенты Set end)

                // *** End programmer edit section *** (ДокумПостав.Клиенты Set end)
            }
        }
        
        /// <summary>
        /// Докум постав.
        /// </summary>
        // *** Start programmer edit section *** (ДокумПостав.Организация CustomAttributes)

        // *** End programmer edit section *** (ДокумПостав.Организация CustomAttributes)
        [PropertyStorage(new string[] {
                "Организация"})]
        [NotNull()]
        public virtual IIS.Vsempoka.Организация Организация
        {
            get
            {
                // *** Start programmer edit section *** (ДокумПостав.Организация Get start)

                // *** End programmer edit section *** (ДокумПостав.Организация Get start)
                IIS.Vsempoka.Организация result = this.fОрганизация;
                // *** Start programmer edit section *** (ДокумПостав.Организация Get end)

                // *** End programmer edit section *** (ДокумПостав.Организация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумПостав.Организация Set start)

                // *** End programmer edit section *** (ДокумПостав.Организация Set start)
                this.fОрганизация = value;
                // *** Start programmer edit section *** (ДокумПостав.Организация Set end)

                // *** End programmer edit section *** (ДокумПостав.Организация Set end)
            }
        }
        
        /// <summary>
        /// Докум постав.
        /// </summary>
        // *** Start programmer edit section *** (ДокумПостав.ИнфорОЗаказе CustomAttributes)

        // *** End programmer edit section *** (ДокумПостав.ИнфорОЗаказе CustomAttributes)
        public virtual IIS.Vsempoka.DetailArrayOfИнфорОЗаказе ИнфорОЗаказе
        {
            get
            {
                // *** Start programmer edit section *** (ДокумПостав.ИнфорОЗаказе Get start)

                // *** End programmer edit section *** (ДокумПостав.ИнфорОЗаказе Get start)
                if ((this.fИнфорОЗаказе == null))
                {
                    this.fИнфорОЗаказе = new IIS.Vsempoka.DetailArrayOfИнфорОЗаказе(this);
                }
                IIS.Vsempoka.DetailArrayOfИнфорОЗаказе result = this.fИнфорОЗаказе;
                // *** Start programmer edit section *** (ДокумПостав.ИнфорОЗаказе Get end)

                // *** End programmer edit section *** (ДокумПостав.ИнфорОЗаказе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ДокумПостав.ИнфорОЗаказе Set start)

                // *** End programmer edit section *** (ДокумПостав.ИнфорОЗаказе Set start)
                this.fИнфорОЗаказе = value;
                // *** Start programmer edit section *** (ДокумПостав.ИнфорОЗаказе Set end)

                // *** End programmer edit section *** (ДокумПостав.ИнфорОЗаказе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДокумПоставE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокумПоставE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокумПоставE", typeof(IIS.Vsempoka.ДокумПостав));
                }
            }
            
            /// <summary>
            /// "ДокумПоставL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДокумПоставL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДокумПоставL", typeof(IIS.Vsempoka.ДокумПостав));
                }
            }
        }
    }
}
