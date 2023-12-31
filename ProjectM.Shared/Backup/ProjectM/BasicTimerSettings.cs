// Decompiled with JetBrains decompiler
// Type: ProjectM.BasicTimerSettings
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
  [Serializable]
  public class BasicTimerSettings : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Time;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BasicTimerSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicTimerSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BasicTimerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BasicTimerSettings()
    {
      Il2CppClassPointerStore<BasicTimerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BasicTimerSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicTimerSettings>.NativeClassPtr);
      BasicTimerSettings.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerSettings>.NativeClassPtr, nameof (Time));
      BasicTimerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerSettings>.NativeClassPtr, 100663662);
    }

    public BasicTimerSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasicTimerSettings.NativeFieldInfoPtr_Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BasicTimerSettings.NativeFieldInfoPtr_Time)) = value;
      }
    }
  }
}
