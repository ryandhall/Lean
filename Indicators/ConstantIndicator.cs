﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using QuantConnect.Data;

namespace QuantConnect.Indicators
{
    /// <summary>
    /// An indicator that will always return the same value.
    /// </summary>
    /// <typeparam name="T">The type of input this indicator takes</typeparam>
    public class ConstantIndicator<T> : IndicatorBase<T>
        where T : BaseData
    {
        private readonly decimal _value;

        /// <summary>
        /// Gets a flag indicating when this indicator is ready and fully initialized
        /// </summary>
        public override bool IsReady
        {
            get { return true; }
        }

        /// <summary>
        /// Creates a new ConstantIndicator that will always return the specified value
        /// </summary>
        /// <param name="name">The name of this indicator</param>
        /// <param name="value">The constant value to be returned</param>
        public ConstantIndicator(string name, decimal value)
            : base(name)
        {
            _value = value;
        }

        /// <summary>
        /// Computes the next value of this indicator from the given state
        /// </summary>
        /// <param name="input">The input given to the indicator</param>
        /// <returns>A new value for this indicator</returns>
        protected override decimal ComputeNextValue(T input)
        {
            return _value;
        }
    }
}