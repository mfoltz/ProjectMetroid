// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FullscreenMenuViewMapperSystem`1
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class FullscreenMenuViewMapperSystem<TMenu> : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Menu_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr_CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Menu_Protected_get_TMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Menu_Private_set_Void_TMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Final_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuCreated_Protected_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe TMenu Menu
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_get_Menu_Protected_get_TMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.PointerToValueGeneric<TMenu>(objectPointer, false, true);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        TMenu& local1;
        if (!typeof (TMenu).IsValueType)
        {
          __Boxed<TMenu> local2 = (object) value;
          local1 = local2 is string ? (TMenu&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TMenu&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref value;
        *numPtr2 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_set_Menu_Private_set_Void_TMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261962, XrefRangeEnd = 1261992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261992, XrefRangeEnd = 1261995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261995, XrefRangeEnd = 1261996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void OnMenuCreated()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuCreated_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnMenuEnabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnMenuDisabled()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 178542, RefRangeEnd = 178564, XrefRangeStart = 178542, XrefRangeEnd = 178564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenMenuViewMapperSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(57)]
    [CachedScanResults(RefRangeStart = 262491, RefRangeEnd = 262548, XrefRangeStart = 262491, XrefRangeEnd = 262548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenMenuViewMapperSystem()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "FullscreenMenuViewMapperSystem`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMenu>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr);
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Menu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, "<Menu>k__BackingField");
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, nameof (_Query));
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, nameof (CommonClientDataSystem));
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, nameof (PrefabCollectionSystem));
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, nameof (GameDataSystem));
      FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, nameof (InputSystem));
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_get_Menu_Protected_get_TMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667333);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_set_Menu_Private_set_Void_TMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667334);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667335);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667336);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667337);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuCreated_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667338);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuEnabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667339);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnMenuDisabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667340);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667341);
      FullscreenMenuViewMapperSystem<TMenu>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenuViewMapperSystem<TMenu>>.NativeClassPtr, 100667342);
    }

    public FullscreenMenuViewMapperSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMenu _Menu_k__BackingField
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<TMenu>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Menu_k__BackingField), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr targetAddress = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Menu_k__BackingField);
        System.Type type = typeof (TMenu);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num1 = ptr;
              System.IntPtr num2 = IL2CPP.il2cpp_object_unbox(ptr);
              int num3 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num1), (uint&) System.IntPtr.Zero);
              __memcpy(targetAddress, num2, num3);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, targetAddress, il2Cpp);
          }
        }
        else
        {
          TMenu menu = value;
          *(TMenu*) targetAddress = menu;
        }
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe CommonClientDataSystem CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenuViewMapperSystem<TMenu>.NativeFieldInfoPtr_InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
