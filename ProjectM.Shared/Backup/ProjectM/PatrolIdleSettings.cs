// Decompiled with JetBrains decompiler
// Type: ProjectM.PatrolIdleSettings
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
  public class PatrolIdleSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Duration;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749153, XrefRangeEnd = 749154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolIdleSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolIdleSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolIdleSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolIdleSettings()
    {
      Il2CppClassPointerStore<PatrolIdleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PatrolIdleSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolIdleSettings>.NativeClassPtr);
      PatrolIdleSettings.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolIdleSettings>.NativeClassPtr, nameof (Duration));
      PatrolIdleSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolIdleSettings>.NativeClassPtr, 100665969);
    }

    public PatrolIdleSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolIdleSettings.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolIdleSettings.NativeFieldInfoPtr_Duration)) = value;
      }
    }
  }
}
