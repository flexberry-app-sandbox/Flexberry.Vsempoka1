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
    /// Клиенты.
    /// </summary>
    // *** Start programmer edit section *** (Клиенты CustomAttributes)

    // *** End programmer edit section *** (Клиенты CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КлиентыE", new string[] {
            "Заказчик as \'Заказчик\'",
            "Телефон as \'Телефон\'",
            "АдресПоствки as \'Адрес поствки\'",
            "РасчетСчет as \'Расчетный счет\'"})]
    [View("КлиентыL", new string[] {
            "Заказчик as \'Заказчик\'",
            "Телефон as \'Телефон\'",
            "АдресПоствки as \'Адрес поствки\'",
            "РасчетСчет as \'Расчетный счет\'"})]
    public class Клиенты : ICSSoft.STORMNET.DataObject
    {
        
        private string fЗаказчик;
        
        private int fТелефон;
        
        private string fАдресПоствки;
        
        private int fРасчетСчет;
        
        // *** Start programmer edit section *** (Клиенты CustomMembers)

        // *** End programmer edit section *** (Клиенты CustomMembers)

        
        /// <summary>
        /// АдресПоствки.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.АдресПоствки CustomAttributes)

        // *** End programmer edit section *** (Клиенты.АдресПоствки CustomAttributes)
        [StrLen(255)]
        public virtual string АдресПоствки
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.АдресПоствки Get start)

                // *** End programmer edit section *** (Клиенты.АдресПоствки Get start)
                string result = this.fАдресПоствки;
                // *** Start programmer edit section *** (Клиенты.АдресПоствки Get end)

                // *** End programmer edit section *** (Клиенты.АдресПоствки Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.АдресПоствки Set start)

                // *** End programmer edit section *** (Клиенты.АдресПоствки Set start)
                this.fАдресПоствки = value;
                // *** Start programmer edit section *** (Клиенты.АдресПоствки Set end)

                // *** End programmer edit section *** (Клиенты.АдресПоствки Set end)
            }
        }
        
        /// <summary>
        /// Заказчик.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Заказчик CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Заказчик CustomAttributes)
        [StrLen(255)]
        public virtual string Заказчик
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Заказчик Get start)

                // *** End programmer edit section *** (Клиенты.Заказчик Get start)
                string result = this.fЗаказчик;
                // *** Start programmer edit section *** (Клиенты.Заказчик Get end)

                // *** End programmer edit section *** (Клиенты.Заказчик Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Заказчик Set start)

                // *** End programmer edit section *** (Клиенты.Заказчик Set start)
                this.fЗаказчик = value;
                // *** Start programmer edit section *** (Клиенты.Заказчик Set end)

                // *** End programmer edit section *** (Клиенты.Заказчик Set end)
            }
        }
        
        /// <summary>
        /// РасчетСчет.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.РасчетСчет CustomAttributes)

        // *** End programmer edit section *** (Клиенты.РасчетСчет CustomAttributes)
        public virtual int РасчетСчет
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.РасчетСчет Get start)

                // *** End programmer edit section *** (Клиенты.РасчетСчет Get start)
                int result = this.fРасчетСчет;
                // *** Start programmer edit section *** (Клиенты.РасчетСчет Get end)

                // *** End programmer edit section *** (Клиенты.РасчетСчет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.РасчетСчет Set start)

                // *** End programmer edit section *** (Клиенты.РасчетСчет Set start)
                this.fРасчетСчет = value;
                // *** Start programmer edit section *** (Клиенты.РасчетСчет Set end)

                // *** End programmer edit section *** (Клиенты.РасчетСчет Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Телефон CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Телефон CustomAttributes)
        public virtual int Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Get start)

                // *** End programmer edit section *** (Клиенты.Телефон Get start)
                int result = this.fТелефон;
                // *** Start programmer edit section *** (Клиенты.Телефон Get end)

                // *** End programmer edit section *** (Клиенты.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Set start)

                // *** End programmer edit section *** (Клиенты.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Клиенты.Телефон Set end)

                // *** End programmer edit section *** (Клиенты.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КлиентыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыE", typeof(IIS.Vsempoka.Клиенты));
                }
            }
            
            /// <summary>
            /// "КлиентыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыL", typeof(IIS.Vsempoka.Клиенты));
                }
            }
        }
    }
}
