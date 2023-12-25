﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.RenderingMetadata
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class RenderingMetadata : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PercentValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondsRemaning;
    private static readonly System.IntPtr NativeFieldInfoPtr_Percent;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeRemaning;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFile;

    static RenderingMetadata()
    {
      Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RenderingMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr);
      RenderingMetadata.NativeFieldInfoPtr_PercentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, nameof (PercentValue));
      RenderingMetadata.NativeFieldInfoPtr_SecondsRemaning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, nameof (SecondsRemaning));
      RenderingMetadata.NativeFieldInfoPtr_Percent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, nameof (Percent));
      RenderingMetadata.NativeFieldInfoPtr_TimeRemaning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, nameof (TimeRemaning));
      RenderingMetadata.NativeFieldInfoPtr_TargetFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, nameof (TargetFile));
    }

    public RenderingMetadata(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public RenderingMetadata()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingMetadata>.NativeClassPtr, data));
    }

    public unsafe float PercentValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_PercentValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_PercentValue)) = value;
      }
    }

    public unsafe float SecondsRemaning
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_SecondsRemaning));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_SecondsRemaning)) = value;
      }
    }

    public unsafe string Percent
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_Percent)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_Percent), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string TimeRemaning
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_TimeRemaning)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_TimeRemaning), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string TargetFile
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_TargetFile)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderingMetadata.NativeFieldInfoPtr_TargetFile), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
