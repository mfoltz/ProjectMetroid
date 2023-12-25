// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PrisonMenuMapper
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

#nullable disable
namespace ProjectM.UI
{
  public class PrisonMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetItemDatasQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrisonSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrisonSubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__Target;
    private static readonly System.IntPtr NativeFieldInfoPtr__InteractBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrisonContextEntriesCache;
    private static readonly System.IntPtr NativeFieldInfoPtr__HighlightHelper;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_PrisonMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__16_6_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242434, XrefRangeEnd = 1242455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242455, XrefRangeEnd = 1242514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242514, XrefRangeEnd = 1242554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242554, XrefRangeEnd = 1242569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242569, XrefRangeEnd = 1242594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242594, XrefRangeEnd = 1242601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242601, XrefRangeEnd = 1242627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242627, XrefRangeEnd = 1242631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkId GetTargetInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NetworkId*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242631, XrefRangeEnd = 1242641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrisonMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242641, XrefRangeEnd = 1242647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_0(Entity entity, ref PrisonMenu.InitData initData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref initData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242647, XrefRangeEnd = 1242769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_1(Entity entity, PrisonMenu prisonMenu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prisonMenu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_PrisonMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 648756, RefRangeEnd = 648758, XrefRangeStart = 648756, XrefRangeEnd = 648758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity _OnStartRunning_b__16_2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__16_3()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242769, XrefRangeEnd = 1242775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_4()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242775, XrefRangeEnd = 1242778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_5()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242778, XrefRangeEnd = 1242781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__16_6()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrisonMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrisonMenuMapper()
    {
      Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PrisonMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr);
      PrisonMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_Query));
      PrisonMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_GetItemDatasQuery));
      PrisonMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_InventorySubMenu));
      PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_InventorySubMenuEntity));
      PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_PrisonSubMenu));
      PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_PrisonSubMenuEntity));
      PrisonMenuMapper.NativeFieldInfoPtr__Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_Target));
      PrisonMenuMapper.NativeFieldInfoPtr__InteractBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_InteractBuff));
      PrisonMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      PrisonMenuMapper.NativeFieldInfoPtr__PrisonContextEntriesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_PrisonContextEntriesCache));
      PrisonMenuMapper.NativeFieldInfoPtr__HighlightHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, nameof (_HighlightHelper));
      PrisonMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666143);
      PrisonMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666144);
      PrisonMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666145);
      PrisonMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666146);
      PrisonMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666147);
      PrisonMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666148);
      PrisonMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666149);
      PrisonMenuMapper.NativeMethodInfoPtr_GetTargetInventory_Private_NetworkId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666150);
      PrisonMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666151);
      PrisonMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666152);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_0_Private_Void_Entity_byref_InitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666153);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_1_Private_Void_Entity_PrisonMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666154);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_2_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666155);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_3_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666156);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666157);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666158);
      PrisonMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__16_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666159);
      PrisonMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, 100666160);
    }

    public PrisonMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _GetItemDatasQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery)) = value;
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventorySubMenu _InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _InventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity)) = value;
      }
    }

    public unsafe PrisonSubMenu _PrisonSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenu));
        return pointer == System.IntPtr.Zero ? (PrisonSubMenu) null : new PrisonSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _PrisonSubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonSubMenuEntity)) = value;
      }
    }

    public unsafe Entity _Target
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__Target));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__Target)) = value;
      }
    }

    public unsafe Entity _InteractBuff
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InteractBuff));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__InteractBuff)) = value;
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<InputContextEntry.Data> _PrisonContextEntriesCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonContextEntriesCache));
        return pointer == System.IntPtr.Zero ? (List<InputContextEntry.Data>) null : new List<InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__PrisonContextEntriesCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIHighlightHelper _HighlightHelper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__HighlightHelper));
        return pointer == System.IntPtr.Zero ? (UIHighlightHelper) null : new UIHighlightHelper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.NativeFieldInfoPtr__HighlightHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.PrisonMenuMapper/<>c__DisplayClass18_0")]
    public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localControlledEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_PrisonMenu_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass18_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242354, XrefRangeEnd = 1242434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, PrisonMenu menu)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrisonMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_PrisonMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass18_0()
      {
        Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrisonMenuMapper>.NativeClassPtr, "<>c__DisplayClass18_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr);
        PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
        PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localControlledEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, nameof (localControlledEntity));
        PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, nameof (localUserEntity));
        PrisonMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, 100666161);
        PrisonMenuMapper.__c__DisplayClass18_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_PrisonMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrisonMenuMapper.__c__DisplayClass18_0>.NativeClassPtr, 100666162);
      }

      public __c__DisplayClass18_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrisonMenuMapper __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (PrisonMenuMapper) null : new PrisonMenuMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localControlledEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localControlledEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localControlledEntity)) = value;
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrisonMenuMapper.__c__DisplayClass18_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }
    }
  }
}
