using System;
using System.Collections;
using System.IO;
using UnityEngine;

namespace HephaestusMobile.LocalData {
    public class LocalDataManager : MonoBehaviour, ILocalDataManager {

        #region ILocalDataManager

        #region GetData

        /// <summary>
        /// Returns data as string from the local storage. 
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <returns></returns>
        public string GetLocalData(string dataKey) {
            return PlayerPrefs.GetString(dataKey);
        }

        /// <summary>
        /// Returns data as integer from the local storage.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <returns></returns>
        public int GetLocalDataInt(string dataKey) {
            return PlayerPrefs.GetInt(dataKey);
        }

        /// <summary>
        /// Returns data as float from the local storage.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <returns></returns>
        public float GetLocalDataFloat(string dataKey) {
            return PlayerPrefs.GetFloat(dataKey);
        }

        /// <summary>
        /// Returns data as boolean from the local storage.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <returns></returns>
        public bool GetLocalDataBoolean(string dataKey) {
            var value = PlayerPrefs.GetInt(dataKey);
            return value == 1;
        }

        /// <summary>
        /// Check if data exists.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <returns></returns>
        public bool IsDataExists(string dataKey) {
            return PlayerPrefs.HasKey(dataKey);
        }

        #endregion

        #region SaveData

        /// <summary>
        /// Save data as string to local storage data.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <param name="data">Data as string.</param>
        /// <param name="callback">Callback after data was saved.</param>
        public void SaveLocalData(string dataKey, string data, Action callback = null) {
            PlayerPrefs.SetString(dataKey, data);
            PlayerPrefs.Save();
            callback?.Invoke();
        }

        /// <summary>
        /// Save data as string to local storage data.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <param name="data">Data as integer.</param>
        /// <param name="callback">Callback after data was saved.</param>
        public void SaveLocalDataInt(string dataKey, int data, Action callback = null) {
            PlayerPrefs.SetInt(dataKey, data);
            PlayerPrefs.Save();
            callback?.Invoke();
        }

        /// <summary>
        /// Save data as string to local storage data.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <param name="data">Data as float.</param>
        /// <param name="callback">Callback after data was saved.</param>
        public void SaveLocalDataFloat(string dataKey, float data, Action callback = null) {
            PlayerPrefs.SetFloat(dataKey, data);
            PlayerPrefs.Save();
            callback?.Invoke();
        }

        /// <summary>
        /// Save data as string to local storage data.
        /// </summary>
        /// <param name="dataKey">Data key.</param>
        /// <param name="data">Data as boolean.</param>
        /// <param name="callback">Callback after data was saved.</param>
        public void SaveLocalDataBoolean(string dataKey, bool data, Action callback = null) {
            PlayerPrefs.SetInt(dataKey, data ? 1 : 0);
        }

        #endregion

        #region DeleteData

        /// <summary>
        /// Find data in local storage by key and delete.
        /// </summary>
        public void DeleteData(string dataKey) {
            if (PlayerPrefs.HasKey(dataKey)) {
                PlayerPrefs.DeleteKey(dataKey);
                PlayerPrefs.Save();
            }
        }

        #endregion

        #endregion
    }

}