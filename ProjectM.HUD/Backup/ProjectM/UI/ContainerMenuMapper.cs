// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ContainerMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class ContainerMenuMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__InitMenuQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetItemDatasQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__ContainerSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__ContainerSubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__SalvageList;
    private static readonly System.IntPtr NativeFieldInfoPtr__Target;
    private static readonly System.IntPtr NativeFieldInfoPtr__InteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr__ContainerContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrevContainerTag;
    private static readonly System.IntPtr NativeFieldInfoPtr___ContainerMenuInitData_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ContainerMenuInitData_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___ContainerMenuInit_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ContainerMenuInit_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalUser_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_0_Private_Void_Entity_byref_InitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_1_Private_Void_Entity_ContainerMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_2_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_3_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_4_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_5_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_6_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_7_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_8_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_9_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_10_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_11_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_12_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__20_13_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInitData_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInit_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233323, XrefRangeEnd = 1233352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233352, XrefRangeEnd = 1233396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233396, XrefRangeEnd = 1233449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233449, XrefRangeEnd = 1233464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233464, XrefRangeEnd = 1233497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233497, XrefRangeEnd = 1233501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233501, XrefRangeEnd = 1233539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233539, XrefRangeEnd = 1233543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetTargetInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity GetLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233543, XrefRangeEnd = 1233557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContainerMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1233557, RefRangeEnd = 1233558, XrefRangeStart = 1233557, XrefRangeEnd = 1233557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_0(Entity entity, ref ContainerMenu.InitData initData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_0_Private_Void_Entity_byref_InitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1233759, RefRangeEnd = 1233761, XrefRangeStart = 1233558, XrefRangeEnd = 1233759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_1(Entity entity, ContainerMenu container)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_1_Private_Void_Entity_ContainerMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__20_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_2_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__20_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_3_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 72810, RefRangeEnd = 72822, XrefRangeStart = 72810, XrefRangeEnd = 72822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity _OnStartRunning_b__20_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_4_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233761, XrefRangeEnd = 1233763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233763, XrefRangeEnd = 1233766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_7()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233766, XrefRangeEnd = 1233768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_8()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233768, XrefRangeEnd = 1233784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_9()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233784, XrefRangeEnd = 1233805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_10()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233805, XrefRangeEnd = 1233810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_11()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233810, XrefRangeEnd = 1233827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_12(string x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_12_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233827, XrefRangeEnd = 1233844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__20_13(string x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_13_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233844, XrefRangeEnd = 1233911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ContainerMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233911, XrefRangeEnd = 1233927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForContainerMenuInitData_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInitData_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233927, XrefRangeEnd = 1233943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForContainerMenuInit_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInit_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233943, XrefRangeEnd = 1233959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ContainerMenuMapper()
    {
      Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ContainerMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr);
      ContainerMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_Query));
      ContainerMenuMapper.NativeFieldInfoPtr__InitMenuQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_InitMenuQuery));
      ContainerMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_GetItemDatasQuery));
      ContainerMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      ContainerMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      ContainerMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      ContainerMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_InventorySubMenu));
      ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_InventorySubMenuEntity));
      ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_ContainerSubMenu));
      ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_ContainerSubMenuEntity));
      ContainerMenuMapper.NativeFieldInfoPtr__SalvageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_SalvageList));
      ContainerMenuMapper.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_Target));
      ContainerMenuMapper.NativeFieldInfoPtr__InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_InteractBuff));
      ContainerMenuMapper.NativeFieldInfoPtr__ContainerContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_ContainerContextEntriesCache));
      ContainerMenuMapper.NativeFieldInfoPtr__PrevContainerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, nameof (_PrevContainerTag));
      ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>ContainerMenuInitData_entityQuery");
      ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>ContainerMenuInitData_profilerMarker");
      ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>ContainerMenuInit_entityQuery");
      ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>ContainerMenuInit_profilerMarker");
      ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ContainerMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665563);
      ContainerMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665564);
      ContainerMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665565);
      ContainerMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665566);
      ContainerMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665567);
      ContainerMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665568);
      ContainerMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665569);
      ContainerMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665570);
      ContainerMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665571);
      ContainerMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665572);
      ContainerMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665573);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_0_Private_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665574);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_1_Private_Void_Entity_ContainerMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665575);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_2_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665576);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_3_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665577);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_4_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665578);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665579);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665580);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665581);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665582);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665583);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665584);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665585);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_12_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665586);
      ContainerMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__20_13_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665587);
      ContainerMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665588);
      ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInitData_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665589);
      ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForContainerMenuInit_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665590);
      ContainerMenuMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, 100665591);
    }

    public ContainerMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _InitMenuQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InitMenuQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InitMenuQuery)) = value;
      }
    }

    public unsafe EntityQuery _GetItemDatasQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventorySubMenu _InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _InventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity)) = value;
      }
    }

    public unsafe InventorySubMenu _ContainerSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _ContainerSubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerSubMenuEntity)) = value;
      }
    }

    public unsafe List<CostData> _SalvageList
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__SalvageList));
        return pointer == System.IntPtr.Zero ? (List<CostData>) null : new List<CostData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__SalvageList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public unsafe Entity _InteractBuff
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InteractBuff));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__InteractBuff)) = value;
      }
    }

    public unsafe List<InputContextEntry.Data> _ContainerContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__ContainerContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _PrevContainerTag
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__PrevContainerTag)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr__PrevContainerTag), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe EntityQuery __ContainerMenuInitData_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ContainerMenuInitData_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInitData_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __ContainerMenuInit_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ContainerMenuInit_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___ContainerMenuInit_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.ContainerMenuMapper/<>c__DisplayClass22_0")]
    public sealed class __c__DisplayClass22_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasBurnContainer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ContainerMenu_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass22_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ContainerMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ContainerMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass22_0()
      {
        Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>c__DisplayClass22_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr);
        ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
        ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, nameof (localPlayerEntity));
        ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, nameof (localUserEntity));
        ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_hasBurnContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, nameof (hasBurnContainer));
        ContainerMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, 100665592);
        ContainerMenuMapper.__c__DisplayClass22_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_ContainerMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, 100665593);
      }

      public __c__DisplayClass22_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass22_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass22_0>.NativeClassPtr, data));
      }

      public unsafe ContainerMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ContainerMenuMapper) null : new ContainerMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localPlayerEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localPlayerEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localPlayerEntity)) = value;
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe bool hasBurnContainer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_hasBurnContainer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass22_0.NativeFieldInfoPtr_hasBurnContainer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ContainerMenuMapper/ProjectM.UI.<>c__DisplayClass_ContainerMenuInitData")]
    public sealed class __c__DisplayClass_ContainerMenuInitData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233161, RefRangeEnd = 1233162, XrefRangeStart = 1233159, XrefRangeEnd = 1233161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref ContainerMenu.InitData initData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233162, XrefRangeEnd = 1233164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233170, RefRangeEnd = 1233171, XrefRangeStart = 1233164, XrefRangeEnd = 1233170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233173, RefRangeEnd = 1233174, XrefRangeStart = 1233171, XrefRangeEnd = 1233173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ContainerMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233174, XrefRangeEnd = 1233180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ContainerMenuInitData()
      {
        Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>c__DisplayClass_ContainerMenuInitData");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, nameof (hostInstance));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, nameof (_runtimes));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, 100665594);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, 100665595);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, 100665596);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, 100665597);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, 100665598);
      }

      public __c__DisplayClass_ContainerMenuInitData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ContainerMenuInitData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, data));
      }

      public unsafe ContainerMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ContainerMenuMapper) null : new ContainerMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_initData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ContainerMenu.InitData> forParameter_initData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1233153, RefRangeEnd = 1233154, XrefRangeStart = 1233149, XrefRangeEnd = 1233153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ContainerMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1233158, RefRangeEnd = 1233159, XrefRangeStart = 1233154, XrefRangeEnd = 1233158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_initData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_initData));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, 100665599);
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, 100665600);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_initData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ContainerMenu.InitData>.Runtime runtime_initData;

          static Runtimes()
          {
            Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_initData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_initData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInitData.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ContainerMenuMapper/ProjectM.UI.<>c__DisplayClass_ContainerMenuInit")]
    public sealed class __c__DisplayClass_ContainerMenuInit : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ContainerMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233190, XrefRangeEnd = 1233192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ContainerMenu container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ContainerMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233192, XrefRangeEnd = 1233213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233219, RefRangeEnd = 1233220, XrefRangeStart = 1233213, XrefRangeEnd = 1233219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ContainerMenuMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ContainerMenuInit()
      {
        Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>c__DisplayClass_ContainerMenuInit");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, nameof (hostInstance));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, nameof (_runtimes));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, nameof (_performLambdaDelegate));
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_ContainerMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, 100665601);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, 100665603);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, 100665604);
        ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, 100665605);
      }

      public __c__DisplayClass_ContainerMenuInit(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_ContainerMenuInit()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, data));
      }

      public unsafe ContainerMenuMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ContainerMenuMapper) null : new ContainerMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_container;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<ContainerMenu> forParameter_container;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233180, XrefRangeEnd = 1233184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ContainerMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1233189, RefRangeEnd = 1233190, XrefRangeStart = 1233184, XrefRangeEnd = 1233189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_container));
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, 100665606);
          ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, 100665607);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_container;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_ManagedComponentData<ContainerMenu>.StructuralChangeRuntime runtime_container;

          static Runtimes()
          {
            Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_container));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_ContainerMenuInit.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ContainerMenuMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasBurnContainer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ContainerMenu_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_byref___c__DisplayClass22_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233299, RefRangeEnd = 1233300, XrefRangeStart = 1233230, XrefRangeEnd = 1233299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ContainerMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ContainerMenu_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233300, XrefRangeEnd = 1233301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ContainerMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233302, RefRangeEnd = 1233303, XrefRangeStart = 1233301, XrefRangeEnd = 1233302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ContainerMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233303, XrefRangeEnd = 1233314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233320, RefRangeEnd = 1233321, XrefRangeStart = 1233314, XrefRangeEnd = 1233320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1233322, RefRangeEnd = 1233323, XrefRangeStart = 1233321, XrefRangeEnd = 1233322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ContainerMenuMapper componentSystem,
        ref ContainerMenuMapper.__c__DisplayClass22_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_byref___c__DisplayClass22_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (localPlayerEntity));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (localUserEntity));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hasBurnContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hasBurnContainer));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ContainerMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665608);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665609);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665610);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665612);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665613);
        ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_byref___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100665614);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ContainerMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ContainerMenuMapper) null : new ContainerMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localPlayerEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayerEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localPlayerEntity)) = value;
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe bool hasBurnContainer
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hasBurnContainer));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hasBurnContainer)) = value;
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_menu;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<ContainerMenu> forParameter_menu;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233220, XrefRangeEnd = 1233224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ContainerMenuMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1233229, RefRangeEnd = 1233230, XrefRangeStart = 1233224, XrefRangeEnd = 1233229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_menu));
          ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ContainerMenuMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665615);
          ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100665616);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_menu;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_ManagedComponentData<ContainerMenu>.StructuralChangeRuntime runtime_menu;

          static Runtimes()
          {
            Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_menu));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContainerMenuMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
