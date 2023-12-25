// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.BetaInformationPanel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
namespace ProjectM.UI
{
  public class BetaInformationPanel : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__WebRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextRequestTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_RootTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimerText;
    private static readonly System.IntPtr NativeFieldInfoPtr__BetaInformationData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277491, XrefRangeEnd = 1277492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaInformationPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277492, XrefRangeEnd = 1277595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaInformationPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BetaInformationPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BetaInformationPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BetaInformationPanel()
    {
      Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (BetaInformationPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr);
      BetaInformationPanel.NativeFieldInfoPtr__WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (_WebRequest));
      BetaInformationPanel.NativeFieldInfoPtr_NextRequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (NextRequestTime));
      BetaInformationPanel.NativeFieldInfoPtr_RootTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (RootTransform));
      BetaInformationPanel.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (HeaderText));
      BetaInformationPanel.NativeFieldInfoPtr_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (DescriptionText));
      BetaInformationPanel.NativeFieldInfoPtr_TimerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (TimerText));
      BetaInformationPanel.NativeFieldInfoPtr__BetaInformationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, nameof (_BetaInformationData));
      BetaInformationPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, 100668703);
      BetaInformationPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, 100668704);
      BetaInformationPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaInformationPanel>.NativeClassPtr, 100668705);
    }

    public BetaInformationPanel(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnityWebRequest _WebRequest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr__WebRequest));
        return pointer == System.IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr__WebRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<float> NextRequestTime
    {
      get
      {
        return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_NextRequestTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_NextRequestTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe RectTransform RootTransform
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_RootTransform));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_RootTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text DescriptionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_DescriptionText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_DescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TimerText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_TimerText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr_TimerText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.Nullable<BetaInformationData> _BetaInformationData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr__BetaInformationData);
        return new Il2CppSystem.Nullable<BetaInformationData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<BetaInformationData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BetaInformationPanel.NativeFieldInfoPtr__BetaInformationData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<BetaInformationData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
