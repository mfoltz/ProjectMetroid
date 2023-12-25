// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UseServantMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class UseServantMenuMapper : ComponentSystem
  {
    private static readonly IntPtr NativeFieldInfoPtr__Query;
    private static readonly IntPtr NativeFieldInfoPtr__GetItemDatasQuery;
    private static readonly IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly IntPtr NativeFieldInfoPtr__InventorySubMenu;
    private static readonly IntPtr NativeFieldInfoPtr__InventorySubMenuEntity;
    private static readonly IntPtr NativeFieldInfoPtr__ServantInventorySubMenu;
    private static readonly IntPtr NativeFieldInfoPtr__ServantInventorySubMenuEntity;
    private static readonly IntPtr NativeFieldInfoPtr__Target;
    private static readonly IntPtr NativeFieldInfoPtr__InteractBuff;
    private static readonly IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly IntPtr NativeFieldInfoPtr__UseServantContextEntriesCache;
    private static readonly IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLocalUser_Private_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UseServantMenu_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__18_0_Private_Void_Entity_UseServantMenu_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254425, XrefRangeEnd = 1254446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref blockInputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254446, XrefRangeEnd = 1254453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &inputState;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254453, XrefRangeEnd = 1254498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254498, XrefRangeEnd = 1254513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254513, XrefRangeEnd = 1254544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254544, XrefRangeEnd = 1254551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254551, XrefRangeEnd = 1254560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1243841, RefRangeEnd = 1243843, XrefRangeStart = 1243841, XrefRangeEnd = 1243843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalUser()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1243843, RefRangeEnd = 1243845, XrefRangeStart = 1243843, XrefRangeEnd = 1243845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254560, XrefRangeEnd = 1254570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UseServantMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254570, XrefRangeEnd = 1254576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_0(Entity entity, ref UseServantMenu.InitData initData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref initData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254576, XrefRangeEnd = 1254689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_1(Entity entity, UseServantMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UseServantMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__16_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__16_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254689, XrefRangeEnd = 1254831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__18_0(Entity entity, UseServantMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UseServantMenuMapper.NativeMethodInfoPtr__OnUpdate_b__18_0_Private_Void_Entity_UseServantMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UseServantMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UseServantMenuMapper()
    {
      Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UseServantMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr);
      UseServantMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_Query));
      UseServantMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_GetItemDatasQuery));
      UseServantMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_InventorySubMenu));
      UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_InventorySubMenuEntity));
      UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_ServantInventorySubMenu));
      UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_ServantInventorySubMenuEntity));
      UseServantMenuMapper.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_Target));
      UseServantMenuMapper.NativeFieldInfoPtr__InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_InteractBuff));
      UseServantMenuMapper.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_GameDataSystem));
      UseServantMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      UseServantMenuMapper.NativeFieldInfoPtr__UseServantContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, nameof (_UseServantContextEntriesCache));
      UseServantMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666812);
      UseServantMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666813);
      UseServantMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666814);
      UseServantMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666815);
      UseServantMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666816);
      UseServantMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666817);
      UseServantMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666818);
      UseServantMenuMapper.NativeMethodInfoPtr_GetLocalUser_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666819);
      UseServantMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666820);
      UseServantMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666821);
      UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666822);
      UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_UseServantMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666823);
      UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666824);
      UseServantMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666825);
      UseServantMenuMapper.NativeMethodInfoPtr__OnUpdate_b__18_0_Private_Void_Entity_UseServantMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666826);
      UseServantMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseServantMenuMapper>.NativeClassPtr, 100666827);
    }

    public UseServantMenuMapper(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _GetItemDatasQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventorySubMenu _InventorySubMenu
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenu));
        return pointer == IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _InventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity)) = value;
      }
    }

    public unsafe ServantInventorySubMenu _ServantInventorySubMenu
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenu));
        return pointer == IntPtr.Zero ? (ServantInventorySubMenu) null : new ServantInventorySubMenu(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _ServantInventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__ServantInventorySubMenuEntity)) = value;
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public unsafe Entity _InteractBuff
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InteractBuff));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__InteractBuff)) = value;
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__GameDataSystem));
        return pointer == IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _UseServantContextEntriesCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__UseServantContextEntriesCache));
        return pointer == IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseServantMenuMapper.NativeFieldInfoPtr__UseServantContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
