// Decompiled with JetBrains decompiler
// Type: ProjectM.SerializeGroup
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
  public class SerializeGroup : ComponentSystemGroup
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762048, XrefRangeEnd = 762052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializeGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializeGroup()
    {
      Il2CppClassPointerStore<SerializeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SerializeGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeGroup>.NativeClassPtr);
      SerializeGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeGroup>.NativeClassPtr, 100667313);
      SerializeGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeGroup>.NativeClassPtr, 100667314);
    }

    public SerializeGroup(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
