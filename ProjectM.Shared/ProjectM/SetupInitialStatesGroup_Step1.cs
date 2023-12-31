// Decompiled with JetBrains decompiler
// Type: ProjectM.SetupInitialStatesGroup_Step1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SetupInitialStatesGroup_Step1 : ComponentSystemGroup
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761988, XrefRangeEnd = 761992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupInitialStatesGroup_Step1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupInitialStatesGroup_Step1>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupInitialStatesGroup_Step1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupInitialStatesGroup_Step1.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupInitialStatesGroup_Step1()
    {
      Il2CppClassPointerStore<SetupInitialStatesGroup_Step1>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SetupInitialStatesGroup_Step1));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupInitialStatesGroup_Step1>.NativeClassPtr);
      SetupInitialStatesGroup_Step1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupInitialStatesGroup_Step1>.NativeClassPtr, 100667283);
      SetupInitialStatesGroup_Step1.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupInitialStatesGroup_Step1>.NativeClassPtr, 100667284);
    }

    public SetupInitialStatesGroup_Step1(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
