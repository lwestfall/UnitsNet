﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricPotentialDc.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialDcTestsBase
    {
        protected abstract double KilovoltsDcInOneVoltDc { get; }
        protected abstract double MegavoltsDcInOneVoltDc { get; }
        protected abstract double MicrovoltsDcInOneVoltDc { get; }
        protected abstract double MillivoltsDcInOneVoltDc { get; }
        protected abstract double VoltsDcInOneVoltDc { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsDcTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsDcTolerance { get { return 1e-5; } }
        protected virtual double VoltsDcTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void VoltDcToElectricPotentialDcUnits()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(KilovoltsDcInOneVoltDc, voltdc.KilovoltsDc, KilovoltsDcTolerance);
            AssertEx.EqualTolerance(MegavoltsDcInOneVoltDc, voltdc.MegavoltsDc, MegavoltsDcTolerance);
            AssertEx.EqualTolerance(MicrovoltsDcInOneVoltDc, voltdc.MicrovoltsDc, MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(MillivoltsDcInOneVoltDc, voltdc.MillivoltsDc, MillivoltsDcTolerance);
            AssertEx.EqualTolerance(VoltsDcInOneVoltDc, voltdc.VoltsDc, VoltsDcTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricPotentialDc.From(1, ElectricPotentialDcUnit.KilovoltDc).KilovoltsDc, KilovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MegavoltDc).MegavoltsDc, MegavoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MicrovoltDc).MicrovoltsDc, MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.From(1, ElectricPotentialDcUnit.MillivoltDc).MillivoltsDc, MillivoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.From(1, ElectricPotentialDcUnit.VoltDc).VoltsDc, VoltsDcTolerance);
        }

        [Fact]
        public void As()
        {
            var voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(KilovoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.KilovoltDc), KilovoltsDcTolerance);
            AssertEx.EqualTolerance(MegavoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MegavoltDc), MegavoltsDcTolerance);
            AssertEx.EqualTolerance(MicrovoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MicrovoltDc), MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(MillivoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.MillivoltDc), MillivoltsDcTolerance);
            AssertEx.EqualTolerance(VoltsDcInOneVoltDc, voltdc.As(ElectricPotentialDcUnit.VoltDc), VoltsDcTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromKilovoltsDc(voltdc.KilovoltsDc).VoltsDc, KilovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMegavoltsDc(voltdc.MegavoltsDc).VoltsDc, MegavoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMicrovoltsDc(voltdc.MicrovoltsDc).VoltsDc, MicrovoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromMillivoltsDc(voltdc.MillivoltsDc).VoltsDc, MillivoltsDcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialDc.FromVoltsDc(voltdc.VoltsDc).VoltsDc, VoltsDcTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotentialDc v = ElectricPotentialDc.FromVoltsDc(1);
            AssertEx.EqualTolerance(-1, -v.VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialDc.FromVoltsDc(3)-v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialDc.FromVoltsDc(10)/5).VoltsDc, VoltsDcTolerance);
            AssertEx.EqualTolerance(2, ElectricPotentialDc.FromVoltsDc(10)/ElectricPotentialDc.FromVoltsDc(5), VoltsDcTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotentialDc oneVoltDc = ElectricPotentialDc.FromVoltsDc(1);
            ElectricPotentialDc twoVoltsDc = ElectricPotentialDc.FromVoltsDc(2);

            Assert.True(oneVoltDc < twoVoltsDc);
            Assert.True(oneVoltDc <= twoVoltsDc);
            Assert.True(twoVoltsDc > oneVoltDc);
            Assert.True(twoVoltsDc >= oneVoltDc);

            Assert.False(oneVoltDc > twoVoltsDc);
            Assert.False(oneVoltDc >= twoVoltsDc);
            Assert.False(twoVoltsDc < oneVoltDc);
            Assert.False(twoVoltsDc <= oneVoltDc);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Equal(0, voltdc.CompareTo(voltdc));
            Assert.True(voltdc.CompareTo(ElectricPotentialDc.Zero) > 0);
            Assert.True(ElectricPotentialDc.Zero.CompareTo(voltdc) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Throws<ArgumentException>(() => voltdc.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.Throws<ArgumentNullException>(() => voltdc.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricPotentialDc a = ElectricPotentialDc.FromVoltsDc(1);
            ElectricPotentialDc b = ElectricPotentialDc.FromVoltsDc(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricPotentialDc v = ElectricPotentialDc.FromVoltsDc(1);
            Assert.True(v.Equals(ElectricPotentialDc.FromVoltsDc(1)));
            Assert.False(v.Equals(ElectricPotentialDc.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.False(voltdc.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotentialDc voltdc = ElectricPotentialDc.FromVoltsDc(1);
            Assert.False(voltdc.Equals(null));
        }
    }
}
