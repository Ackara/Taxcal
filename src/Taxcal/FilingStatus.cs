using System.ComponentModel.DataAnnotations;

namespace Tekcari.Taxcal
{
    /// <summary>
    /// Represents a filing status
    /// </summary>
    /// <see cref="https://www.irs.gov/newsroom/correct-filing-status"/>
    public enum FilingStatus
    {
        /// <summary>
        /// Normally this status is for taxpayers who aren’t married, or who are divorced or legally separated under state law.
        /// </summary>
        Single,

        /// <summary>
        /// A married couple can choose to file two separate tax returns. This may benefit them if it results in less tax owed than if they file a joint tax return. Taxpayers may want to prepare their taxes both ways before they choose. They can also use this status if each wants to be responsible only for their own tax.
        /// </summary>
        [Display(Name = "Married Filing Separately")]
        MarriedSeperately,

        /// <summary>
        /// If taxpayers are married, they can file a joint tax return. If a spouse died in 2016, the widowed spouse can often file a joint return for that year.
        /// </summary>
        [Display(Name = "Married Filing Jointly")]
        MarriedJointly,

        /// <summary>
        /// In most cases, this status applies to a taxpayer who is not married, but there are some special rules. For example, the taxpayer must have paid more than half the cost of keeping up a home for themselves and a qualifying person. Don’t choose this status by mistake. Be sure to check all the rules.
        /// </summary>
        [Display(Name = "Head of Household")]
        HeadOfHousehold,

        /// <summary>
        /// This status may apply to a taxpayer if their spouse died during 2014 or 2015 and they have a dependent child. Other conditions also apply.
        /// </summary>
        [Display(Name = "Qualifying Widow(er) with Dependent Child")]
        Widow
    }
}