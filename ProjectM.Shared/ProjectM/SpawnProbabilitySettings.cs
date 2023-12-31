// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnProbabilitySettings
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
  public class SpawnProbabilitySettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnProbability;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnProbabilitySettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnProbabilitySettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnProbabilitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnProbabilitySettings()
    {
      Il2CppClassPointerStore<SpawnProbabilitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnProbabilitySettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnProbabilitySettings>.NativeClassPtr);
      SpawnProbabilitySettings.NativeFieldInfoPtr_SpawnProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnProbabilitySettings>.NativeClassPtr, nameof (SpawnProbability));
      SpawnProbabilitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnProbabilitySettings>.NativeClassPtr, 100666010);
    }

    public SpawnProbabilitySettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SpawnProbability
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnProbabilitySettings.NativeFieldInfoPtr_SpawnProbability));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnProbabilitySettings.NativeFieldInfoPtr_SpawnProbability)) = value;
      }
    }
  }
}
