// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InventoryMenuMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

#nullable disable
namespace ProjectM.UI
{
  public class InventoryMenuMapper : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__EmptySubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__MountSubMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__InventorySubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__MountSubMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetItemDatasQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMountFeedInventory_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMount_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMountInventory_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__13_0_Private_Void_Entity_InventoryMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnStartRunning_b__13_1_Private_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__15_0_Private_Void_Entity_InventoryMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237114, XrefRangeEnd = 1237136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237136, XrefRangeEnd = 1237147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237147, XrefRangeEnd = 1237177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237177, XrefRangeEnd = 1237185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237185, XrefRangeEnd = 1237197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237197, XrefRangeEnd = 1237202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237202, XrefRangeEnd = 1237211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237211, XrefRangeEnd = 1237217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetMountFeedInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_GetMountFeedInventory_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1237247, RefRangeEnd = 1237251, XrefRangeStart = 1237217, XrefRangeEnd = 1237247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetMount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_GetMount_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237251, XrefRangeEnd = 1237257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetMountInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_GetMountInventory_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe Entity GetLocalPlayer()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryMenuMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237257, XrefRangeEnd = 1237359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnStartRunning_b__13_0(Entity entity, InventoryMenu inventoryMenu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventoryMenu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__13_0_Private_Void_Entity_InventoryMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Entity _OnStartRunning_b__13_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__13_1_Private_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237359, XrefRangeEnd = 1237397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__15_0(Entity entity, InventoryMenu menu)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) menu);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.NativeMethodInfoPtr__OnUpdate_b__15_0_Private_Void_Entity_InventoryMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryMenuMapper()
    {
      Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InventoryMenuMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr);
      InventoryMenuMapper.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_InputSystem));
      InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_InventorySubMenu));
      InventoryMenuMapper.NativeFieldInfoPtr__EmptySubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_EmptySubMenu));
      InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_MountSubMenu));
      InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_InventorySubMenuEntity));
      InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_MountSubMenuEntity));
      InventoryMenuMapper.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_Query));
      InventoryMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_GetItemDatasQuery));
      InventoryMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, nameof (_CommonClientDataSystem));
      InventoryMenuMapper.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665851);
      InventoryMenuMapper.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665852);
      InventoryMenuMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665853);
      InventoryMenuMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665854);
      InventoryMenuMapper.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665855);
      InventoryMenuMapper.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665856);
      InventoryMenuMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665857);
      InventoryMenuMapper.NativeMethodInfoPtr_GetMountFeedInventory_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665858);
      InventoryMenuMapper.NativeMethodInfoPtr_GetMount_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665859);
      InventoryMenuMapper.NativeMethodInfoPtr_GetMountInventory_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665860);
      InventoryMenuMapper.NativeMethodInfoPtr_GetLocalPlayer_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665861);
      InventoryMenuMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665862);
      InventoryMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__13_0_Private_Void_Entity_InventoryMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665863);
      InventoryMenuMapper.NativeMethodInfoPtr__OnStartRunning_b__13_1_Private_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665864);
      InventoryMenuMapper.NativeMethodInfoPtr__OnUpdate_b__15_0_Private_Void_Entity_InventoryMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665865);
      InventoryMenuMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, 100665866);
    }

    public InventoryMenuMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventorySubMenu _InventorySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenu));
        return pointer == System.IntPtr.Zero ? (InventorySubMenu) null : new InventorySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EmptySubMenu _EmptySubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__EmptySubMenu));
        return pointer == System.IntPtr.Zero ? (EmptySubMenu) null : new EmptySubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__EmptySubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MountSubMenu _MountSubMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenu));
        return pointer == System.IntPtr.Zero ? (MountSubMenu) null : new MountSubMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _InventorySubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__InventorySubMenuEntity)) = value;
      }
    }

    public unsafe Entity _MountSubMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__MountSubMenuEntity)) = value;
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _GetItemDatasQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__GetItemDatasQuery)) = value;
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.InventoryMenuMapper/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_horse;
      private static readonly System.IntPtr NativeFieldInfoPtr_userTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserCharacterPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_nearestDist;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetMount_b__0_Internal_Void_Entity_byref_Translation_byref_Team_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass17_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237113, XrefRangeEnd = 1237114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _GetMount_b__0(Entity entity, ref Translation translation, ref Team team)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref team;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InventoryMenuMapper.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMount_b__0_Internal_Void_Entity_byref_Translation_byref_Team_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InventoryMenuMapper>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr);
        InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_horse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, nameof (horse));
        InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_userTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, nameof (userTeam));
        InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_localUserCharacterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, nameof (localUserCharacterPosition));
        InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_nearestDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, nameof (nearestDist));
        InventoryMenuMapper.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, 100665867);
        InventoryMenuMapper.__c__DisplayClass17_0.NativeMethodInfoPtr__GetMount_b__0_Internal_Void_Entity_byref_Translation_byref_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryMenuMapper.__c__DisplayClass17_0>.NativeClassPtr, 100665868);
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Entity horse
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_horse));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_horse)) = value;
        }
      }

      public unsafe Team userTeam
      {
        get
        {
          return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_userTeam));
        }
        [param: In] set
        {
          *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_userTeam)) = value;
        }
      }

      public unsafe float3 localUserCharacterPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_localUserCharacterPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_localUserCharacterPosition)) = value;
        }
      }

      public unsafe float nearestDist
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_nearestDist));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryMenuMapper.__c__DisplayClass17_0.NativeFieldInfoPtr_nearestDist)) = value;
        }
      }
    }
  }
}
