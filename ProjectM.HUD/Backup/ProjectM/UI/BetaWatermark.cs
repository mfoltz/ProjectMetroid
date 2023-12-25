// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BetaWatermark
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Auth;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class BetaWatermark : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BetaWatermarkTransform;
    private static readonly IntPtr NativeFieldInfoPtr_SteamIdText;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyShowInView;
    private static readonly IntPtr NativeFieldInfoPtr_InfluenceHideIfInView;
    private static readonly IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277595, XrefRangeEnd = 1277603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaWatermark.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaWatermark.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BetaWatermark()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaWatermark.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BetaWatermark()
    {
      Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BetaWatermark));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr);
      BetaWatermark.NativeFieldInfoPtr_BetaWatermarkTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, nameof (BetaWatermarkTransform));
      BetaWatermark.NativeFieldInfoPtr_SteamIdText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, nameof (SteamIdText));
      BetaWatermark.NativeFieldInfoPtr_OnlyShowInView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, nameof (OnlyShowInView));
      BetaWatermark.NativeFieldInfoPtr_InfluenceHideIfInView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, nameof (InfluenceHideIfInView));
      BetaWatermark.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, nameof (_SteamPlatformSystem));
      BetaWatermark.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, 100668706);
      BetaWatermark.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, 100668707);
      BetaWatermark.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaWatermark>.NativeClassPtr, 100668708);
    }

    public BetaWatermark(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RectTransform BetaWatermarkTransform
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_BetaWatermarkTransform));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_BetaWatermarkTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text SteamIdText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_SteamIdText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_SteamIdText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ViewLocation OnlyShowInView
    {
      get
      {
        return *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_OnlyShowInView));
      }
      [param: In] set
      {
        *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_OnlyShowInView)) = value;
      }
    }

    public unsafe ViewLocation InfluenceHideIfInView
    {
      get
      {
        return *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_InfluenceHideIfInView));
      }
      [param: In] set
      {
        *(ViewLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr_InfluenceHideIfInView)) = value;
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaWatermark.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
