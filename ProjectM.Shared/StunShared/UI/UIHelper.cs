// Decompiled with JetBrains decompiler
// Type: StunShared.UI.UIHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM;
using ProjectM.UI;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace StunShared.UI
{
  public class UIHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGameObject_Public_Static_GameObject_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiatePrefab_Public_Static_T_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiatePrefabUnderAnchor_Public_Static_T_T_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeNewGameObject_Private_Static_Void_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnEventSystemIfNotExists_Public_Static_Void_EventSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedStringOrDefault_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Static_Void_RawImage_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Static_Void_Transform_Transform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetFillAmount_Public_Static_Void_Image_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetSprite_Public_Static_Void_Image_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Graphic_Color32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_TextMeshProUGUI_Color32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Static_Void_RectTransform_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeString_Public_Static_String_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RotateVector_Public_Static_Vector3_Vector2_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_RectTransform_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppArrayBase_1_T_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_T_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_T_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_byref_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_byref_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_RectTransform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_RectTransform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_RectTransform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IfSetActive_Public_Static_Boolean_RectTransform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetComponentEnabled_Public_Static_Void_Behaviour_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeSizedRawImage_Public_Static_Boolean_RawImage_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTo2DPos_Public_Static_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Static_Void_Image_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyRectData_Internal_Static_Void_RectTransform_RectTransform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HexToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ByteArrayToHex_Public_Static_String_Il2CppStructArray_1_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_Image_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_RawImage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CaptureScreenshot_Public_Static_Void_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenshotFileName_Private_Static_String_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToRoman_Public_Static_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyInitialLoadUI_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeselectAll_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonHovered_Public_Static_Boolean_SimpleStunButton_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRestrictedItemTypeIcon_Public_Static_Sprite_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRestrictedItemName_Public_Static_LocalizationKey_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCategoryIcon_Public_Static_Sprite_ItemCategorySettings_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCategoryName_Public_Static_LocalizationKey_ItemCategorySettings_ItemCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetItemCategoryVisualizationData_Public_Static_Boolean_ItemCategorySettings_ItemCategory_byref_ItemCategoryVisualizationData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDirection_Public_Static_CardinalDirection_float2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetShowPassword_Public_Static_Void_TMP_InputField_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 718012, RefRangeEnd = 718013, XrefRangeStart = 718004, XrefRangeEnd = 718012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameObject InstantiateGameObject(GameObject prefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_InstantiateGameObject_Public_Static_GameObject_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718013, XrefRangeEnd = 718021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameObject InstantiateGameObjectUnderAnchor(
      GameObject prefab,
      Transform anchor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anchor);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 718029, RefRangeEnd = 718046, XrefRangeStart = 718021, XrefRangeEnd = 718029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameObject InstantiateGameObjectUnderAnchor(
      GameObject prefab,
      RectTransform anchor)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anchor);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 718051, RefRangeEnd = 718052, XrefRangeStart = 718046, XrefRangeEnd = 718051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T InstantiatePrefab<T>(T prefab) where T : MonoBehaviour
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) prefab;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref prefab;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UIHelper.MethodInfoStoreGeneric_InstantiatePrefab_Public_Static_T_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(161)]
    [CachedScanResults(RefRangeStart = 718057, RefRangeEnd = 718218, XrefRangeStart = 718052, XrefRangeEnd = 718057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T InstantiatePrefabUnderAnchor<T>(T prefab, RectTransform anchor) where T : MonoBehaviour
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) prefab;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref prefab;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anchor);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(UIHelper.MethodInfoStoreGeneric_InstantiatePrefabUnderAnchor_Public_Static_T_T_RectTransform_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 718230, RefRangeEnd = 718236, XrefRangeStart = 718218, XrefRangeEnd = 718230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeNewGameObject(GameObject gameObject)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_InitializeNewGameObject_Private_Static_Void_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 718255, RefRangeEnd = 718257, XrefRangeStart = 718236, XrefRangeEnd = 718255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SpawnEventSystemIfNotExists(EventSystem eventSystemPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventSystemPrefab);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SpawnEventSystemIfNotExists_Public_Static_Void_EventSystem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 718265, RefRangeEnd = 718267, XrefRangeStart = 718257, XrefRangeEnd = 718265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetLocalizedStringOrDefault(string keyOrText)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(keyOrText);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetLocalizedStringOrDefault_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718267, XrefRangeEnd = 718276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTexture(RawImage image, Texture2D texture)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetTexture_Public_Static_Void_RawImage_Texture2D_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718276, XrefRangeEnd = 718282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetParent(
      Transform transform,
      Transform parent,
      bool worldPositionStays = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPositionStays;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetParent_Public_Static_Void_Transform_Transform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 718283, RefRangeEnd = 718304, XrefRangeStart = 718282, XrefRangeEnd = 718283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetFillAmount(Image image, float fillAmount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fillAmount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetFillAmount_Public_Static_Void_Image_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 718313, RefRangeEnd = 718321, XrefRangeStart = 718304, XrefRangeEnd = 718313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetSprite(Image image, Sprite sprite)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetSprite_Public_Static_Void_Image_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 718324, RefRangeEnd = 718339, XrefRangeStart = 718321, XrefRangeEnd = 718324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetColor(Graphic graphic, Color32 color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphic);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetColor_Public_Static_Void_Graphic_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 718346, RefRangeEnd = 718350, XrefRangeStart = 718339, XrefRangeEnd = 718346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetColor(TextMeshProUGUI text, Color32 color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetColor_Public_Static_Void_TextMeshProUGUI_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718350, XrefRangeEnd = 718351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetPosition(RectTransform rect, Vector2 screenPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &screenPosition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetPosition_Public_Static_Void_RectTransform_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 718382, RefRangeEnd = 718387, XrefRangeStart = 718351, XrefRangeEnd = 718382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetTimeString(float timeLeft)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &timeLeft;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetTimeString_Public_Static_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 718389, RefRangeEnd = 718390, XrefRangeStart = 718387, XrefRangeEnd = 718389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector3 RotateVector(Vector2 vector, float radians)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &vector;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radians;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_RotateVector_Public_Static_Vector3_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718390, XrefRangeEnd = 718391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetLocalPosition(RectTransform rect, Vector2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &position;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_RectTransform_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718391, XrefRangeEnd = 718396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive<T>(Il2CppArrayBase<T> behaviours, bool isActive) where T : MonoBehaviour
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) behaviours);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.MethodInfoStoreGeneric_SetActive_Public_Static_Void_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718396, XrefRangeEnd = 718409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive<T>(List<T> behaviours, bool isActive) where T : MonoBehaviour
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) behaviours);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.MethodInfoStoreGeneric_SetActive_Public_Static_Void_List_1_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718409, XrefRangeEnd = 718410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector2 GetScreenPosition(Camera camera, Vector3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718410, XrefRangeEnd = 718411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector2 GetScreenPosition(
      Camera camera,
      Vector3 worldPosition,
      out float depth)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref depth;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(144)]
    [CachedScanResults(RefRangeStart = 718417, RefRangeEnd = 718561, XrefRangeStart = 718411, XrefRangeEnd = 718417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive<T>(T behaviour, bool isActive) where T : StunGUIBehaviour
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) behaviour;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref behaviour;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.MethodInfoStoreGeneric_SetActive_Public_Static_Void_T_Boolean_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(271)]
    [CachedScanResults(RefRangeStart = 718565, RefRangeEnd = 718836, XrefRangeStart = 718561, XrefRangeEnd = 718565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(MonoBehaviour behaviour, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) behaviour);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718836, XrefRangeEnd = 718844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(
      Transform transform,
      ref GameObject cachedGO,
      bool isActive)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cachedGO);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_byref_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GameObject local = ref cachedGO;
      System.IntPtr pointer = ptr;
      GameObject gameObject = pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      local = gameObject;
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 718852, RefRangeEnd = 718859, XrefRangeStart = 718844, XrefRangeEnd = 718852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(
      MonoBehaviour behaviour,
      ref GameObject cachedGO,
      bool isActive)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) behaviour);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cachedGO);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_byref_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GameObject local = ref cachedGO;
      System.IntPtr pointer = ptr;
      GameObject gameObject = pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      local = gameObject;
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 718862, RefRangeEnd = 718869, XrefRangeStart = 718859, XrefRangeEnd = 718862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(Il2CppReferenceArray<GameObject> gameObjects, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjects);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718869, XrefRangeEnd = 718885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(List<GameObject> gameObjects, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObjects);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(634)]
    [CachedScanResults(RefRangeStart = 718887, RefRangeEnd = 719521, XrefRangeStart = 718885, XrefRangeEnd = 718887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(GameObject gameObject, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719521, XrefRangeEnd = 719539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(List<RectTransform> transforms, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transforms);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_RectTransform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(
      Il2CppReferenceArray<RectTransform> transforms,
      bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transforms);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_RectTransform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(271)]
    [CachedScanResults(RefRangeStart = 718565, RefRangeEnd = 718836, XrefRangeStart = 718565, XrefRangeEnd = 718836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(RectTransform transform, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_RectTransform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 719543, RefRangeEnd = 719547, XrefRangeStart = 719539, XrefRangeEnd = 719543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IfSetActive(RectTransform transform, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_IfSetActive_Public_Static_Boolean_RectTransform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(271)]
    [CachedScanResults(RefRangeStart = 718565, RefRangeEnd = 718836, XrefRangeStart = 718565, XrefRangeEnd = 718836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetActive(Transform transform, bool isActive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isActive;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719547, XrefRangeEnd = 719549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetComponentEnabled(Behaviour component, bool isEnabled)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isEnabled;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetComponentEnabled_Public_Static_Void_Behaviour_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719549, XrefRangeEnd = 719557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SetNativeSizedRawImage(RawImage rawImage, Texture2D texture)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rawImage);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetNativeSizedRawImage_Public_Static_Boolean_RawImage_Texture2D_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 719558, RefRangeEnd = 719561, XrefRangeStart = 719557, XrefRangeEnd = 719558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ConvertTo2DPos(float height)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &height;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_ConvertTo2DPos_Public_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 719573, RefRangeEnd = 719577, XrefRangeStart = 719561, XrefRangeEnd = 719573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetNativeSize(Image image)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetNativeSize_Public_Static_Void_Image_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719577, XrefRangeEnd = 719597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SetNativeSizedSprite(Image image, Sprite sprite)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719597, XrefRangeEnd = 719601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool SetNativeSizedSprite(
      Image image,
      Sprite sprite,
      Vector2 localPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &localPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719601, XrefRangeEnd = 719612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyRectData(RectTransform to, RectTransform from)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_CopyRectData_Internal_Static_Void_RectTransform_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719612, XrefRangeEnd = 719621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStructArray<byte> HexToByteArray(string hexString)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(hexString);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_HexToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719621, XrefRangeEnd = 719635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ByteArrayToHex(Il2CppStructArray<byte> bytes)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bytes);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_ByteArrayToHex_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719635, XrefRangeEnd = 719641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector2 GetImageSize(Image image)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_Image_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Vector2 GetImageSize(RawImage image)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_RawImage_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719641, XrefRangeEnd = 719658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CaptureScreenshot(Nullable_Unboxed<int> sizeMultiplier = default (Nullable_Unboxed<int>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &sizeMultiplier;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_CaptureScreenshot_Public_Static_Void_Nullable_Unboxed_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719658, XrefRangeEnd = 719666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetScreenshotFileName(string baseName, string extName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(baseName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extName);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetScreenshotFileName_Private_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 719720, RefRangeEnd = 719733, XrefRangeStart = 719666, XrefRangeEnd = 719720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ToRoman(int number)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &number;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_ToRoman_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 719754, RefRangeEnd = 719756, XrefRangeStart = 719733, XrefRangeEnd = 719754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyInitialLoadUI()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_DestroyInitialLoadUI_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 719762, RefRangeEnd = 719764, XrefRangeStart = 719756, XrefRangeEnd = 719762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DeselectAll()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_DeselectAll_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 719772, RefRangeEnd = 719778, XrefRangeStart = 719764, XrefRangeEnd = 719772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsButtonHovered(SimpleStunButton button, bool onlyIfInteractable = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &onlyIfInteractable;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_IsButtonHovered_Public_Static_Boolean_SimpleStunButton_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 719782, RefRangeEnd = 719784, XrefRangeStart = 719778, XrefRangeEnd = 719782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Sprite GetRestrictedItemTypeIcon(
      GameDataSystem gameDataSystem,
      ItemCategorySettings itemCategorySettings,
      PrefabGUID restrictedType,
      ItemCategory restrictedCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetRestrictedItemTypeIcon_Public_Static_Sprite_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 719788, RefRangeEnd = 719789, XrefRangeStart = 719784, XrefRangeEnd = 719788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalizationKey GetRestrictedItemName(
      GameDataSystem gameDataSystem,
      ItemCategorySettings itemCategorySettings,
      PrefabGUID restrictedType,
      ItemCategory restrictedCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictedCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetRestrictedItemName_Public_Static_LocalizationKey_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 719810, RefRangeEnd = 719814, XrefRangeStart = 719789, XrefRangeEnd = 719810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Sprite GetItemCategoryIcon(
      ItemCategorySettings itemCategorySettings,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetItemCategoryIcon_Public_Static_Sprite_ItemCategorySettings_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 719835, RefRangeEnd = 719836, XrefRangeStart = 719814, XrefRangeEnd = 719835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe LocalizationKey GetItemCategoryName(
      ItemCategorySettings itemCategorySettings,
      ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetItemCategoryName_Public_Static_LocalizationKey_ItemCategorySettings_ItemCategory_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 719836, XrefRangeEnd = 719863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetItemCategoryVisualizationData(
      ItemCategorySettings itemCategorySettings,
      ItemCategory itemCategory,
      out UIHelper.ItemCategoryVisualizationData data)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) itemCategorySettings);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_TryGetItemCategoryVisualizationData_Public_Static_Boolean_ItemCategorySettings_ItemCategory_byref_ItemCategoryVisualizationData_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref UIHelper.ItemCategoryVisualizationData local = ref data;
      System.IntPtr pointer = zero;
      UIHelper.ItemCategoryVisualizationData visualizationData = pointer == System.IntPtr.Zero ? (UIHelper.ItemCategoryVisualizationData) null : new UIHelper.ItemCategoryVisualizationData(pointer);
      local = visualizationData;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 719879, RefRangeEnd = 719881, XrefRangeStart = 719863, XrefRangeEnd = 719879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CardinalDirection GetDirection(float2 p1, float2 p2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &p1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_GetDirection_Public_Static_CardinalDirection_float2_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CardinalDirection*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 719885, RefRangeEnd = 719888, XrefRangeStart = 719881, XrefRangeEnd = 719885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetShowPassword(TMP_InputField inputField, bool showPassword)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &showPassword;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr_SetShowPassword_Public_Static_Void_TMP_InputField_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UIHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UIHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UIHelper()
    {
      Il2CppClassPointerStore<UIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (UIHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHelper>.NativeClassPtr);
      UIHelper.NativeMethodInfoPtr_InstantiateGameObject_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663572);
      UIHelper.NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663573);
      UIHelper.NativeMethodInfoPtr_InstantiateGameObjectUnderAnchor_Public_Static_GameObject_GameObject_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663574);
      UIHelper.NativeMethodInfoPtr_InstantiatePrefab_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663575);
      UIHelper.NativeMethodInfoPtr_InstantiatePrefabUnderAnchor_Public_Static_T_T_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663576);
      UIHelper.NativeMethodInfoPtr_InitializeNewGameObject_Private_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663577);
      UIHelper.NativeMethodInfoPtr_SpawnEventSystemIfNotExists_Public_Static_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663578);
      UIHelper.NativeMethodInfoPtr_GetLocalizedStringOrDefault_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663579);
      UIHelper.NativeMethodInfoPtr_SetTexture_Public_Static_Void_RawImage_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663580);
      UIHelper.NativeMethodInfoPtr_SetParent_Public_Static_Void_Transform_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663581);
      UIHelper.NativeMethodInfoPtr_SetFillAmount_Public_Static_Void_Image_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663582);
      UIHelper.NativeMethodInfoPtr_SetSprite_Public_Static_Void_Image_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663583);
      UIHelper.NativeMethodInfoPtr_SetColor_Public_Static_Void_Graphic_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663584);
      UIHelper.NativeMethodInfoPtr_SetColor_Public_Static_Void_TextMeshProUGUI_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663585);
      UIHelper.NativeMethodInfoPtr_SetPosition_Public_Static_Void_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663586);
      UIHelper.NativeMethodInfoPtr_GetTimeString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663587);
      UIHelper.NativeMethodInfoPtr_RotateVector_Public_Static_Vector3_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663588);
      UIHelper.NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663589);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663590);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663591);
      UIHelper.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663592);
      UIHelper.NativeMethodInfoPtr_GetScreenPosition_Public_Static_Vector2_Camera_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663593);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663594);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663595);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_byref_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663596);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_MonoBehaviour_byref_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663597);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663598);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663599);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663600);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663601);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppReferenceArray_1_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663602);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663603);
      UIHelper.NativeMethodInfoPtr_IfSetActive_Public_Static_Boolean_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663604);
      UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663605);
      UIHelper.NativeMethodInfoPtr_SetComponentEnabled_Public_Static_Void_Behaviour_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663606);
      UIHelper.NativeMethodInfoPtr_SetNativeSizedRawImage_Public_Static_Boolean_RawImage_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663607);
      UIHelper.NativeMethodInfoPtr_ConvertTo2DPos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663608);
      UIHelper.NativeMethodInfoPtr_SetNativeSize_Public_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663609);
      UIHelper.NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663610);
      UIHelper.NativeMethodInfoPtr_SetNativeSizedSprite_Public_Static_Boolean_Image_Sprite_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663611);
      UIHelper.NativeMethodInfoPtr_CopyRectData_Internal_Static_Void_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663612);
      UIHelper.NativeMethodInfoPtr_HexToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663613);
      UIHelper.NativeMethodInfoPtr_ByteArrayToHex_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663614);
      UIHelper.NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663615);
      UIHelper.NativeMethodInfoPtr_GetImageSize_Public_Static_Vector2_RawImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663616);
      UIHelper.NativeMethodInfoPtr_CaptureScreenshot_Public_Static_Void_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663617);
      UIHelper.NativeMethodInfoPtr_GetScreenshotFileName_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663618);
      UIHelper.NativeMethodInfoPtr_ToRoman_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663619);
      UIHelper.NativeMethodInfoPtr_DestroyInitialLoadUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663620);
      UIHelper.NativeMethodInfoPtr_DeselectAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663621);
      UIHelper.NativeMethodInfoPtr_IsButtonHovered_Public_Static_Boolean_SimpleStunButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663622);
      UIHelper.NativeMethodInfoPtr_GetRestrictedItemTypeIcon_Public_Static_Sprite_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663623);
      UIHelper.NativeMethodInfoPtr_GetRestrictedItemName_Public_Static_LocalizationKey_GameDataSystem_ItemCategorySettings_PrefabGUID_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663624);
      UIHelper.NativeMethodInfoPtr_GetItemCategoryIcon_Public_Static_Sprite_ItemCategorySettings_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663625);
      UIHelper.NativeMethodInfoPtr_GetItemCategoryName_Public_Static_LocalizationKey_ItemCategorySettings_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663626);
      UIHelper.NativeMethodInfoPtr_TryGetItemCategoryVisualizationData_Public_Static_Boolean_ItemCategorySettings_ItemCategory_byref_ItemCategoryVisualizationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663627);
      UIHelper.NativeMethodInfoPtr_GetDirection_Public_Static_CardinalDirection_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663628);
      UIHelper.NativeMethodInfoPtr_SetShowPassword_Public_Static_Void_TMP_InputField_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663629);
      UIHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, 100663630);
    }

    public UIHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public sealed class ItemCategoryVisualizationData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

      static ItemCategoryVisualizationData()
      {
        Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIHelper>.NativeClassPtr, nameof (ItemCategoryVisualizationData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr);
        UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr, nameof (Name));
        UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr, nameof (Icon));
      }

      public ItemCategoryVisualizationData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ItemCategoryVisualizationData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIHelper.ItemCategoryVisualizationData>.NativeClassPtr, data));
      }

      public unsafe LocalizationKey Name
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Name));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Name)) = value;
        }
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHelper.ItemCategoryVisualizationData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_InstantiatePrefab_Public_Static_T_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIHelper.NativeMethodInfoPtr_InstantiatePrefab_Public_Static_T_T_0, Il2CppClassPointerStore<UIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_InstantiatePrefabUnderAnchor_Public_Static_T_T_RectTransform_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIHelper.NativeMethodInfoPtr_InstantiatePrefabUnderAnchor_Public_Static_T_T_RectTransform_0, Il2CppClassPointerStore<UIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetActive_Public_Static_Void_Il2CppArrayBase_1_T_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<UIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetActive_Public_Static_Void_List_1_T_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_List_1_T_Boolean_0, Il2CppClassPointerStore<UIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_SetActive_Public_Static_Void_T_Boolean_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIHelper.NativeMethodInfoPtr_SetActive_Public_Static_Void_T_Boolean_0, Il2CppClassPointerStore<UIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
