// Decompiled with JetBrains decompiler
// Type: MountStatEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
public class MountStatEntry : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ValueText;
  private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalValueText;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGradiantColor_Private_Static_Color_Single_float2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 1205537, RefRangeEnd = 1205543, XrefRangeStart = 1205513, XrefRangeEnd = 1205537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshData(MountStatEntry.Data data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &data;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountStatEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205543, XrefRangeEnd = 1205544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color GetGradiantColor(float value, float2 valueSpan)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &valueSpan;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MountStatEntry.NativeMethodInfoPtr_GetGradiantColor_Private_Static_Color_Single_float2_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MountStatEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MountStatEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MountStatEntry()
  {
    Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (MountStatEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr);
    MountStatEntry.NativeFieldInfoPtr_ValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, nameof (ValueText));
    MountStatEntry.NativeFieldInfoPtr_AdditionalValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, nameof (AdditionalValueText));
    MountStatEntry.NativeMethodInfoPtr_RefreshData_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, 100663329);
    MountStatEntry.NativeMethodInfoPtr_GetGradiantColor_Private_Static_Color_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, 100663330);
    MountStatEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, 100663331);
  }

  public MountStatEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedText ValueText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountStatEntry.NativeFieldInfoPtr_ValueText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountStatEntry.NativeFieldInfoPtr_ValueText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedText AdditionalValueText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountStatEntry.NativeFieldInfoPtr_AdditionalValueText));
      return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MountStatEntry.NativeFieldInfoPtr_AdditionalValueText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalValue;
    [FieldOffset(0)]
    public float Value;
    [FieldOffset(4)]
    public float2 ValueRange;
    [FieldOffset(12)]
    public Nullable_Unboxed<float> AdditionalValue;

    static Data()
    {
      Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MountStatEntry>.NativeClassPtr, nameof (Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr);
      MountStatEntry.Data.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr, nameof (Value));
      MountStatEntry.Data.NativeFieldInfoPtr_ValueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr, nameof (ValueRange));
      MountStatEntry.Data.NativeFieldInfoPtr_AdditionalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr, nameof (AdditionalValue));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MountStatEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
