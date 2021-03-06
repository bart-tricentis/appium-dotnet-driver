﻿/*
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * See the NOTICE file distributed with this work for additional
 * information regarding copyright ownership.
 * You may obtain a copy of the License at
 * 
 *    http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace OpenQA.Selenium.Appium.Interfaces
{
    public interface IHidesKeyboard
    {
        /// <summary>
        /// Hides the device keyboard.
        /// </summary>
        void HideKeyboard();

        /// <summary>
        /// Hides the device keyboard.
        /// </summary>
        /// <param name="key">The button pressed by the mobile driver to attempt hiding the keyboard.</param>
        void HideKeyboard(string key);

        /// <summary>
        /// Hides the device keyboard.
        /// </summary>
        /// <param name="strategy">Hide keyboard strategy (optional, UIAutomation only). Available strategies - 'press', 'pressKey', 'swipeDown', 'tapOut', 'tapOutside', 'default'.</param>
        /// <param name="key">The button pressed by the mobile driver to attempt hiding the keyboard.</param>
        void HideKeyboard(string strategy, string key);

        /// <summary>
        /// Whether or not the soft keyboard is shown
        /// </summary>
        /// <returns><see cref="true"/> if keyboard is shown, <see cref="false"/> if not.</returns>
        bool IsKeyboardShown();
    }
}