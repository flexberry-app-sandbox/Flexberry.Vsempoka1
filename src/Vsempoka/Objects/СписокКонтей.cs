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
    /// Список контей.
    /// </summary>
    // *** Start programmer edit section *** (СписокКонтей CustomAttributes)

    // *** End programmer edit section *** (СписокКонтей CustomAttributes)
    [AutoAltered()]
    [Caption("Список контейнеров")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СписокКонтейE", new string[] {
            "НомерКонтей as \'Номер контейнера\'",
            "НаименКонтей as \'Наименование контейнера\'"})]
    [View("СписокКонтейL", new string[] {
            "НомерКонтей as \'Номер контейнера\'",
            "НаименКонтей as \'Наименование контейнера\'"})]
    public class СписокКонтей : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерКонтей;
        
        private string fНаименКонтей;
        
        // *** Start programmer edit section *** (СписокКонтей CustomMembers)

        // *** End programmer edit section *** (СписокКонтей CustomMembers)

        
        /// <summary>
        /// НаименКонтей.
        /// </summary>
        // *** Start programmer edit section *** (СписокКонтей.НаименКонтей CustomAttributes)

        // *** End programmer edit section *** (СписокКонтей.НаименКонтей CustomAttributes)
        [StrLen(255)]
        public virtual string НаименКонтей
        {
            get
            {
                // *** Start programmer edit section *** (СписокКонтей.НаименКонтей Get start)

                // *** End programmer edit section *** (СписокКонтей.НаименКонтей Get start)
                string result = this.fНаименКонтей;
                // *** Start programmer edit section *** (СписокКонтей.НаименКонтей Get end)

                // *** End programmer edit section *** (СписокКонтей.НаименКонтей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СписокКонтей.НаименКонтей Set start)

                // *** End programmer edit section *** (СписокКонтей.НаименКонтей Set start)
                this.fНаименКонтей = value;
                // *** Start programmer edit section *** (СписокКонтей.НаименКонтей Set end)

                // *** End programmer edit section *** (СписокКонтей.НаименКонтей Set end)
            }
        }
        
        /// <summary>
        /// НомерКонтей.
        /// </summary>
        // *** Start programmer edit section *** (СписокКонтей.НомерКонтей CustomAttributes)

        // *** End programmer edit section *** (СписокКонтей.НомерКонтей CustomAttributes)
        public virtual int НомерКонтей
        {
            get
            {
                // *** Start programmer edit section *** (СписокКонтей.НомерКонтей Get start)

                // *** End programmer edit section *** (СписокКонтей.НомерКонтей Get start)
                int result = this.fНомерКонтей;
                // *** Start programmer edit section *** (СписокКонтей.НомерКонтей Get end)

                // *** End programmer edit section *** (СписокКонтей.НомерКонтей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СписокКонтей.НомерКонтей Set start)

                // *** End programmer edit section *** (СписокКонтей.НомерКонтей Set start)
                this.fНомерКонтей = value;
                // *** Start programmer edit section *** (СписокКонтей.НомерКонтей Set end)

                // *** End programmer edit section *** (СписокКонтей.НомерКонтей Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СписокКонтейE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СписокКонтейE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СписокКонтейE", typeof(IIS.Vsempoka.СписокКонтей));
                }
            }
            
            /// <summary>
            /// "СписокКонтейL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СписокКонтейL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СписокКонтейL", typeof(IIS.Vsempoka.СписокКонтей));
                }
            }
        }
    }
}
