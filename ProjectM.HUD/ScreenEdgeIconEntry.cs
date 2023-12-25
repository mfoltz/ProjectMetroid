// Decompiled with JetBrains decompiler
// Type: ScreenEdgeIconEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ScreenEdgeIconEntry : UIEntry
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_Text;
  private static readonly System.IntPtr NativeFieldInfoPtr_Arrow;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrowRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_DegreeAdjust;
  private static readonly System.IntPtr NativeFieldInfoPtr_LK_Distance;
  private static readonly System.IntPtr NativeFieldInfoPtr__LS;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParentRect;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentRect_Public_get_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_byref_Data_ScreenEdgeIconDataComponent_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetData_old_Public_Void_float3_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WorldToScreenSpace_Private_Vector3_Vector3_Camera_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe RectTransform ParentRect
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206323, XrefRangeEnd = 1206333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr_get_ParentRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
  }

  [CallerCount(0)]
  public new unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1206378, RefRangeEnd = 1206379, XrefRangeStart = 1206333, XrefRangeEnd = 1206378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData(
    [In] ref ScreenEdgeIconEntry.Data data,
    ScreenEdgeIconDataComponent iconData,
    Camera camera)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_ScreenEdgeIconDataComponent_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206379, XrefRangeEnd = 1206387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetData_old(float3 worldPosition, float scaleFactor, bool someBool)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &worldPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scaleFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &someBool;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr_SetData_old_Public_Void_float3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1206387, XrefRangeEnd = 1206392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 WorldToScreenSpace(Vector3 worldPos, Camera camera, RectTransform area)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &worldPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) area);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr_WorldToScreenSpace_Private_Vector3_Vector3_Camera_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(41)]
  [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScreenEdgeIconEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScreenEdgeIconEntry()
  {
    Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (ScreenEdgeIconEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr);
    ScreenEdgeIconEntry.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (CanvasGroup));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (Icon));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (Text));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_Arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (Arrow));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_ArrowRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (ArrowRect));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_DegreeAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (DegreeAdjust));
    ScreenEdgeIconEntry.NativeFieldInfoPtr_LK_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (LK_Distance));
    ScreenEdgeIconEntry.NativeFieldInfoPtr__LS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (_LS));
    ScreenEdgeIconEntry.NativeFieldInfoPtr__ParentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (_ParentRect));
    ScreenEdgeIconEntry.NativeMethodInfoPtr_get_ParentRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663384);
    ScreenEdgeIconEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663385);
    ScreenEdgeIconEntry.NativeMethodInfoPtr_SetData_Public_Void_byref_Data_ScreenEdgeIconDataComponent_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663386);
    ScreenEdgeIconEntry.NativeMethodInfoPtr_SetData_old_Public_Void_float3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663387);
    ScreenEdgeIconEntry.NativeMethodInfoPtr_WorldToScreenSpace_Private_Vector3_Vector3_Camera_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663388);
    ScreenEdgeIconEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, 100663389);
  }

  public ScreenEdgeIconEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CanvasGroup CanvasGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_CanvasGroup));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text Text
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Text));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Arrow
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Arrow));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_Arrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image ArrowRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_ArrowRect));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_ArrowRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float DegreeAdjust
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_DegreeAdjust));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_DegreeAdjust)) = value;
    }
  }

  public unsafe LocalizationKey LK_Distance
  {
    get
    {
      return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_LK_Distance));
    }
    [param: In] set
    {
      *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr_LK_Distance)) = value;
    }
  }

  public LocalizedString _LS
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr__LS);
      return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr__LS), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe RectTransform _ParentRect
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr__ParentRect));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconEntry.NativeFieldInfoPtr__ParentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Distance;
    private static readonly System.IntPtr NativeFieldInfoPtr_IconDataGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScaleFactor;
    [FieldOffset(0)]
    public float3 WorldPosition;
    [FieldOffset(12)]
    public float Distance;
    [FieldOffset(16)]
    public PrefabGUID IconDataGuid;
    [FieldOffset(20)]
    public float ScaleFactor;

    static Data()
    {
      Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenEdgeIconEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr);
      ScreenEdgeIconEntry.Data.NativeFieldInfoPtr_WorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr, nameof (WorldPosition));
      ScreenEdgeIconEntry.Data.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr, nameof (Distance));
      ScreenEdgeIconEntry.Data.NativeFieldInfoPtr_IconDataGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr, nameof (IconDataGuid));
      ScreenEdgeIconEntry.Data.NativeFieldInfoPtr_ScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr, nameof (ScaleFactor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenEdgeIconEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
