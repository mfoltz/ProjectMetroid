// Decompiled with JetBrains decompiler
// Type: StunShared.UI.StunGUIBehaviour
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public class StunGUIBehaviour : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__CachedGameObject_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__Rect;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CachedGameObject_Public_get_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_CachedGameObject_Public_set_Void_GameObject_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717712, XrefRangeEnd = 717714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe GameObject CachedGameObject
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr_get_CachedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr_set_CachedGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe RectTransform Rect
    {
      [CallerCount(101), CachedScanResults(RefRangeStart = 717722, RefRangeEnd = 717823, XrefRangeStart = 717714, XrefRangeEnd = 717722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunGUIBehaviour()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunGUIBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunGUIBehaviour()
    {
      Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "StunShared.UI", nameof (StunGUIBehaviour));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr);
      StunGUIBehaviour.NativeFieldInfoPtr__CachedGameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, "<CachedGameObject>k__BackingField");
      StunGUIBehaviour.NativeFieldInfoPtr__Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, nameof (_Rect));
      StunGUIBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663555);
      StunGUIBehaviour.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663556);
      StunGUIBehaviour.NativeMethodInfoPtr_get_CachedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663557);
      StunGUIBehaviour.NativeMethodInfoPtr_set_CachedGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663558);
      StunGUIBehaviour.NativeMethodInfoPtr_get_Rect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663559);
      StunGUIBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunGUIBehaviour>.NativeClassPtr, 100663560);
    }

    public StunGUIBehaviour(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject _CachedGameObject_k__BackingField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunGUIBehaviour.NativeFieldInfoPtr__CachedGameObject_k__BackingField));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunGUIBehaviour.NativeFieldInfoPtr__CachedGameObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform _Rect
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunGUIBehaviour.NativeFieldInfoPtr__Rect));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunGUIBehaviour.NativeFieldInfoPtr__Rect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
