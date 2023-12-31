// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolSpeedSettings
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
namespace ProjectM
{
  public class PatrolSpeedSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolSpeedSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolSpeedSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolSpeedSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolSpeedSettings()
    {
      Il2CppClassPointerStore<PatrolSpeedSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PatrolSpeedSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolSpeedSettings>.NativeClassPtr);
      PatrolSpeedSettings.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolSpeedSettings>.NativeClassPtr, nameof (Speed));
      PatrolSpeedSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolSpeedSettings>.NativeClassPtr, 100665970);
    }

    public PatrolSpeedSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpeedSettings.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolSpeedSettings.NativeFieldInfoPtr_Speed)) = value;
      }
    }
  }
}
