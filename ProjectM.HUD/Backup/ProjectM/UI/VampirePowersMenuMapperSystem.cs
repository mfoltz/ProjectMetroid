// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VampirePowersMenuMapperSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Collections;

#nullable disable
namespace ProjectM.UI
{
  public class VampirePowersMenuMapperSystem : PowerSelectionMenuMapperSystem<VampirePowersMenu>
  {
    private static readonly IntPtr NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262292, XrefRangeEnd = 1262297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnAbilityEquipped(int slotIndex, PrefabGUID ability)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &slotIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ability;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VampirePowersMenuMapperSystem.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262297, XrefRangeEnd = 1262302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetMappedAbilities(NativeList<PrefabGUID> result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &result;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VampirePowersMenuMapperSystem.NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262302, XrefRangeEnd = 1262305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VampirePowersMenuMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VampirePowersMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262305, XrefRangeEnd = 1262308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VampirePowersMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VampirePowersMenuMapperSystem()
    {
      Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VampirePowersMenuMapperSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr);
      VampirePowersMenuMapperSystem.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr, 100667384);
      VampirePowersMenuMapperSystem.NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr, 100667385);
      VampirePowersMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr, 100667386);
      VampirePowersMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VampirePowersMenuMapperSystem>.NativeClassPtr, 100667387);
    }

    public VampirePowersMenuMapperSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
