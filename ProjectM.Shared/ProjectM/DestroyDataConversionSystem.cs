// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyDataConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DestroyDataConversionSystem : GameObjectConversionSystem
  {
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_PrefabGuidComponent_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723973, XrefRangeEnd = 723982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyDataConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 724016, RefRangeEnd = 724018, XrefRangeStart = 723982, XrefRangeEnd = 724016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddComponentRecursively(Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDataConversionSystem.NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyDataConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDataConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724018, XrefRangeEnd = 724021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(PrefabGuidComponent component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyDataConversionSystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyDataConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyDataConversionSystem()
    {
      Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DestroyDataConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr);
      DestroyDataConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr, 100664032);
      DestroyDataConversionSystem.NativeMethodInfoPtr_AddComponentRecursively_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr, 100664033);
      DestroyDataConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr, 100664034);
      DestroyDataConversionSystem.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr, 100664035);
      DestroyDataConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyDataConversionSystem>.NativeClassPtr, 100664036);
    }

    public DestroyDataConversionSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
