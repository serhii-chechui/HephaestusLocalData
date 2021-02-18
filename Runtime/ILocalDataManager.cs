using System;
using UnityEngine;

namespace HephaestusMobile.LocalData {
    public interface ILocalDataManager {

        #region GetData

		/// <inheridoc/>
        string GetLocalData(string dataKey);

		/// <inheridoc/>
        int GetLocalDataInt(string dataKey);

		/// <inheridoc/>
        float GetLocalDataFloat(string dataKey);

		/// <inheridoc/>
        bool GetLocalDataBoolean(string dataKey);

		/// <inheridoc/>        
        bool IsDataExists(string dataKey);

        #endregion

        #region SaveData
		
		/// <inheridoc/>
        void SaveLocalData(string dataKey, string data, Action callback = null);

		/// <inheridoc/>
        void SaveLocalDataInt(string dataKey, int data, Action callback = null);

		/// <inheridoc/>
        void SaveLocalDataFloat(string dataKey, float data, Action callback = null);

		/// <inheridoc/>
        void SaveLocalDataBoolean(string dataKey, bool data, Action callback = null);

        #endregion

        #region DeleteData

        /// <inheridoc/>
        void DeleteData(string dataKey);

        #endregion
    }
}
