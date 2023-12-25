// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.EmotesMenuMapperSystem
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
  public class EmotesMenuMapperSystem : PowerSelectionMenuMapperSystem<EmotesMenu>
  {
    private static readonly IntPtr NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262041, XrefRangeEnd = 1262046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnAbilityEquipped(int slotIndex, PrefabGUID ability)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &slotIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ability;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EmotesMenuMapperSystem.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262046, XrefRangeEnd = 1262051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetMappedAbilities(NativeList<PrefabGUID> result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &result;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EmotesMenuMapperSystem.NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262051, XrefRangeEnd = 1262054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EmotesMenuMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EmotesMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262054, XrefRangeEnd = 1262057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EmotesMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EmotesMenuMapperSystem()
    {
      Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (EmotesMenuMapperSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr);
      EmotesMenuMapperSystem.NativeMethodInfoPtr_OnAbilityEquipped_Protected_Virtual_Void_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr, 100667351);
      EmotesMenuMapperSystem.NativeMethodInfoPtr_GetMappedAbilities_Protected_Virtual_Void_NativeList_1_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr, 100667352);
      EmotesMenuMapperSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr, 100667353);
      EmotesMenuMapperSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotesMenuMapperSystem>.NativeClassPtr, 100667354);
    }

    public EmotesMenuMapperSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
