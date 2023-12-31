// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveECSTransformConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RemoveECSTransformConversionSystem : GameObjectConversionSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr_ComponentsToRemove;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveTranform_Private_Void_Component_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_PrefabGuidComponent_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_Entity_RemoveECSTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_Entity_Transform_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727515, XrefRangeEnd = 727545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveECSTransformConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 727571, RefRangeEnd = 727574, XrefRangeStart = 727545, XrefRangeEnd = 727571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveTranform(Component component)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveECSTransformConversionSystem.NativeMethodInfoPtr_RemoveTranform_Private_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveECSTransformConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveECSTransformConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727574, XrefRangeEnd = 727575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_0(Entity entity, PrefabGuidComponent prefabGuidComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefabGuidComponent);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727575, XrefRangeEnd = 727617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_1(Entity entity, RemoveECSTransform removeComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) removeComponent);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_Entity_RemoveECSTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_2(Entity entity, Transform transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_Entity_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveECSTransformConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveECSTransformConversionSystem()
    {
      Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RemoveECSTransformConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr);
      RemoveECSTransformConversionSystem.NativeFieldInfoPtr_ComponentsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, nameof (ComponentsToRemove));
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664408);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr_RemoveTranform_Private_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664409);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664410);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_Entity_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664412);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_Entity_RemoveECSTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664413);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_Entity_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664414);
      RemoveECSTransformConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveECSTransformConversionSystem>.NativeClassPtr, 100664415);
    }

    public RemoveECSTransformConversionSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ComponentTypes ComponentsToRemove
    {
      get
      {
        ComponentTypes componentsToRemove;
        IL2CPP.il2cpp_field_static_get_value(RemoveECSTransformConversionSystem.NativeFieldInfoPtr_ComponentsToRemove, (void*) &componentsToRemove);
        return componentsToRemove;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RemoveECSTransformConversionSystem.NativeFieldInfoPtr_ComponentsToRemove, (void*) &value);
      }
    }
  }
}
