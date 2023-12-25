// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FloatMinMax
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class FloatMinMax : PropertyAttribute
  {
    private static readonly IntPtr NativeFieldInfoPtr_Min;
    private static readonly IntPtr NativeFieldInfoPtr_Max;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FloatMinMax()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FloatMinMax.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FloatMinMax()
    {
      Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (FloatMinMax));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr);
      FloatMinMax.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr, nameof (Min));
      FloatMinMax.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr, nameof (Max));
      FloatMinMax.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatMinMax>.NativeClassPtr, 100692293);
    }

    public FloatMinMax(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Min
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatMinMax.NativeFieldInfoPtr_Min));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatMinMax.NativeFieldInfoPtr_Min)) = value;
      }
    }

    public unsafe float Max
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatMinMax.NativeFieldInfoPtr_Max));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatMinMax.NativeFieldInfoPtr_Max)) = value;
      }
    }
  }
}
