﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     A unit for expressing the integral of apparent power over time, equal to the product of 1 volt-ampere and 1 hour, or to 3600 joules.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ApparentEnergy
#else
    public partial struct ApparentEnergy : IComparable, IComparable<ApparentEnergy>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ApparentEnergyUnit? _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
#if WINDOWS_UWP
        public double Value => Convert.ToDouble(_value);
#else
        public double Value => _value;
#endif

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public ApparentEnergyUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ApparentEnergy()
        {
            _value = 0;
            _unit = BaseUnit;
        }
#endif

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public ApparentEnergy(double voltamperehours)
        {
            _value = Convert.ToDouble(voltamperehours);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public 
#endif
          ApparentEnergy(double numericValue, ApparentEnergyUnit unit)
        {
            _value = numericValue;
            _unit = unit;
         }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit VoltampereHour.
        /// </summary>
        /// <param name="voltamperehours">Value assuming base unit VoltampereHour.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        ApparentEnergy(long voltamperehours) : this(Convert.ToDouble(voltamperehours), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit VoltampereHour.
        /// </summary>
        /// <param name="voltamperehours">Value assuming base unit VoltampereHour.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        ApparentEnergy(decimal voltamperehours) : this(Convert.ToDouble(voltamperehours), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.ApparentEnergy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static ApparentEnergyUnit BaseUnit => ApparentEnergyUnit.VoltampereHour;

        private static BaseDimensions _baseDimensions = new BaseDimensions(2, 1, -2, 0, 0, 0, 0);

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get
            {
                return _baseDimensions;
            }
        }

        /// <summary>
        ///     All units of measurement for the ApparentEnergy quantity.
        /// </summary>
        public static ApparentEnergyUnit[] Units { get; } = Enum.GetValues(typeof(ApparentEnergyUnit)).Cast<ApparentEnergyUnit>().ToArray();
        /// <summary>
        ///     Get ApparentEnergy in KilovoltampereHours.
        /// </summary>
        public double KilovoltampereHours => As(ApparentEnergyUnit.KilovoltampereHour);
        /// <summary>
        ///     Get ApparentEnergy in MegavoltampereHours.
        /// </summary>
        public double MegavoltampereHours => As(ApparentEnergyUnit.MegavoltampereHour);
        /// <summary>
        ///     Get ApparentEnergy in VoltampereHours.
        /// </summary>
        public double VoltampereHours => As(ApparentEnergyUnit.VoltampereHour);

        #endregion

        #region Static

        public static ApparentEnergy Zero => new ApparentEnergy(0, BaseUnit);

        /// <summary>
        ///     Get ApparentEnergy from KilovoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromKilovoltampereHours(double kilovoltamperehours)
#else
        public static ApparentEnergy FromKilovoltampereHours(QuantityValue kilovoltamperehours)
#endif
        {
            double value = (double) kilovoltamperehours;
            return new ApparentEnergy(value, ApparentEnergyUnit.KilovoltampereHour);
        }

        /// <summary>
        ///     Get ApparentEnergy from MegavoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromMegavoltampereHours(double megavoltamperehours)
#else
        public static ApparentEnergy FromMegavoltampereHours(QuantityValue megavoltamperehours)
#endif
        {
            double value = (double) megavoltamperehours;
            return new ApparentEnergy(value, ApparentEnergyUnit.MegavoltampereHour);
        }

        /// <summary>
        ///     Get ApparentEnergy from VoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromVoltampereHours(double voltamperehours)
#else
        public static ApparentEnergy FromVoltampereHours(QuantityValue voltamperehours)
#endif
        {
            double value = (double) voltamperehours;
            return new ApparentEnergy(value, ApparentEnergyUnit.VoltampereHour);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ApparentEnergy from nullable KilovoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromKilovoltampereHours(QuantityValue? kilovoltamperehours)
        {
            if (kilovoltamperehours.HasValue)
            {
                return FromKilovoltampereHours(kilovoltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentEnergy from nullable MegavoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromMegavoltampereHours(QuantityValue? megavoltamperehours)
        {
            if (megavoltamperehours.HasValue)
            {
                return FromMegavoltampereHours(megavoltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentEnergy from nullable VoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromVoltampereHours(QuantityValue? voltamperehours)
        {
            if (voltamperehours.HasValue)
            {
                return FromVoltampereHours(voltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentEnergy unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ApparentEnergy From(double value, ApparentEnergyUnit fromUnit)
#else
        public static ApparentEnergy From(QuantityValue value, ApparentEnergyUnit fromUnit)
#endif
        {
            return new ApparentEnergy((double)value, fromUnit);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentEnergy unit value.</returns>
        public static ApparentEnergy? From(QuantityValue? value, ApparentEnergyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return new ApparentEnergy((double)value.Value, fromUnit);
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ApparentEnergyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(
          ApparentEnergyUnit unit,
#if WINDOWS_UWP
          [CanBeNull] string cultureName)
#else
          [CanBeNull] IFormatProvider provider)
#endif
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ApparentEnergy operator -(ApparentEnergy right)
        {
            return new ApparentEnergy(-right.Value, right.Unit);
        }

        public static ApparentEnergy operator +(ApparentEnergy left, ApparentEnergy right)
        {
            return new ApparentEnergy(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static ApparentEnergy operator -(ApparentEnergy left, ApparentEnergy right)
        {
            return new ApparentEnergy(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static ApparentEnergy operator *(double left, ApparentEnergy right)
        {
            return new ApparentEnergy(left * right.Value, right.Unit);
        }

        public static ApparentEnergy operator *(ApparentEnergy left, double right)
        {
            return new ApparentEnergy(left.Value * right, left.Unit);
        }

        public static ApparentEnergy operator /(ApparentEnergy left, double right)
        {
            return new ApparentEnergy(left.Value / right, left.Unit);
        }

        public static double operator /(ApparentEnergy left, ApparentEnergy right)
        {
            return left.VoltampereHours / right.VoltampereHours;
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ApparentEnergy)) throw new ArgumentException("Expected type ApparentEnergy.", "obj");
            return CompareTo((ApparentEnergy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ApparentEnergy other)
        {
            return AsBaseUnitVoltampereHours().CompareTo(other.AsBaseUnitVoltampereHours());
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ApparentEnergy left, ApparentEnergy right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(ApparentEnergy left, ApparentEnergy right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(ApparentEnergy left, ApparentEnergy right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(ApparentEnergy left, ApparentEnergy right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(ApparentEnergy left, ApparentEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(ApparentEnergy left, ApparentEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return AsBaseUnitVoltampereHours().Equals(((ApparentEnergy) obj).AsBaseUnitVoltampereHours());
        }

        /// <summary>
        ///     Compare equality to another ApparentEnergy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(ApparentEnergy other, ApparentEnergy maxError)
        {
            return Math.Abs(AsBaseUnitVoltampereHours() - other.AsBaseUnitVoltampereHours()) <= maxError.AsBaseUnitVoltampereHours();
        }

        public override int GetHashCode()
        {
			return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ApparentEnergyUnit unit)
        {
            if (Unit == unit)
            {
                return (double)Value;
            }

            double baseUnitValue = AsBaseUnitVoltampereHours();

            switch (unit)
            {
                case ApparentEnergyUnit.KilovoltampereHour: return (baseUnitValue) / 1e3d;
                case ApparentEnergyUnit.MegavoltampereHour: return (baseUnitValue) / 1e6d;
                case ApparentEnergyUnit.VoltampereHour: return baseUnitValue;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ApparentEnergy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ApparentEnergy Parse(
            string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            if (str == null) throw new ArgumentNullException("str");

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return QuantityParser.Parse<ApparentEnergy, ApparentEnergyUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ApparentEnergyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromVoltampereHours(x.VoltampereHours + y.VoltampereHours));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ApparentEnergy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse(
            [CanBeNull] string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
          out ApparentEnergy result)
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif
            try
            {

                result = Parse(
                  str,
#if WINDOWS_UWP
                  cultureName);
#else
                  provider);
#endif

                return true;
            }
            catch
            {
                result = default(ApparentEnergy);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentEnergyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from other .NET targets.")]
        public static ApparentEnergyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static ApparentEnergyUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<ApparentEnergyUnit>(str.Trim());

            if (unit == ApparentEnergyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ApparentEnergyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is VoltampereHour
        /// </summary>
        public static ApparentEnergyUnit ToStringDefaultUnit { get; set; } = ApparentEnergyUnit.VoltampereHour;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ApparentEnergyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>String representation.</returns>
        public string ToString(
          ApparentEnergyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            ApparentEnergyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            ApparentEnergyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ApparentEnergy
        /// </summary>
        public static ApparentEnergy MaxValue => new ApparentEnergy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ApparentEnergy
        /// </summary>
        public static ApparentEnergy MinValue => new ApparentEnergy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnitVoltampereHours()
        {
            if (Unit == ApparentEnergyUnit.VoltampereHour) { return _value; }

            switch (Unit)
            {
                case ApparentEnergyUnit.KilovoltampereHour: return (_value) * 1e3d;
                case ApparentEnergyUnit.MegavoltampereHour: return (_value) * 1e6d;
                case ApparentEnergyUnit.VoltampereHour: return _value;
                default:
                    throw new NotImplementedException("Unit not implemented: " + Unit);
            }
        }

        /// <summary>Convenience method for working with internal numeric type.</summary>
        private double AsBaseNumericType(ApparentEnergyUnit unit) => Convert.ToDouble(As(unit));

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ApparentEnergy.BaseDimensions;
    }
}
