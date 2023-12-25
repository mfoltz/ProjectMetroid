// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.OpenHUDMenuSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class OpenHUDMenuSystem : ComponentSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentMenuType_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedHUDMenus;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentMenuEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentMenuType_Public_get_HUDMenuType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentMenuType_Private_set_Void_HUDMenuType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentMenu_Public_get_HUDMenu_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_OpenHUDMenuSystem_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe HUDMenuType CurrentMenuType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.NativeMethodInfoPtr_get_CurrentMenuType_Public_get_HUDMenuType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(HUDMenuType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.NativeMethodInfoPtr_set_CurrentMenuType_Private_set_Void_HUDMenuType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe HUDMenu CurrentMenu
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.NativeMethodInfoPtr_get_CurrentMenu_Public_get_HUDMenu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HUDMenu) null : new HUDMenu(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277035, XrefRangeEnd = 1277039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe OpenHUDMenuSystem Get(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.NativeMethodInfoPtr_Get_Public_Static_OpenHUDMenuSystem_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (OpenHUDMenuSystem) null : new OpenHUDMenuSystem(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277039, XrefRangeEnd = 1277050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OpenHUDMenuSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277050, XrefRangeEnd = 1277079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OpenHUDMenuSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277079, XrefRangeEnd = 1277087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OpenHUDMenuSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OpenHUDMenuSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OpenHUDMenuSystem()
    {
      Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (OpenHUDMenuSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr);
      OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, "<CurrentMenuType>k__BackingField");
      OpenHUDMenuSystem.NativeFieldInfoPtr__CachedHUDMenus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, nameof (_CachedHUDMenus));
      OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, nameof (_CurrentMenu));
      OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, nameof (_CurrentMenuEntity));
      OpenHUDMenuSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, nameof (_Query));
      OpenHUDMenuSystem.NativeMethodInfoPtr_get_CurrentMenuType_Public_get_HUDMenuType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668651);
      OpenHUDMenuSystem.NativeMethodInfoPtr_set_CurrentMenuType_Private_set_Void_HUDMenuType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668652);
      OpenHUDMenuSystem.NativeMethodInfoPtr_get_CurrentMenu_Public_get_HUDMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668653);
      OpenHUDMenuSystem.NativeMethodInfoPtr_Get_Public_Static_OpenHUDMenuSystem_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668654);
      OpenHUDMenuSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668655);
      OpenHUDMenuSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668656);
      OpenHUDMenuSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668657);
      OpenHUDMenuSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, 100668658);
    }

    public OpenHUDMenuSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HUDMenuType _CurrentMenuType_k__BackingField
    {
      get
      {
        return *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuType_k__BackingField));
      }
      [param: In] set
      {
        *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuType_k__BackingField)) = value;
      }
    }

    public unsafe Dictionary<HUDMenuType, HUDMenu> _CachedHUDMenus
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CachedHUDMenus));
        return pointer == System.IntPtr.Zero ? (Dictionary<HUDMenuType, HUDMenu>) null : new Dictionary<HUDMenuType, HUDMenu>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CachedHUDMenus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDMenu _CurrentMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenu));
        return pointer == System.IntPtr.Zero ? (HUDMenu) null : new HUDMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _CurrentMenuEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__CurrentMenuEntity)) = value;
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.OpenHUDMenuSystem/<>c__DisplayClass12_0")]
    public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_canvasBase;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_OpenMenuEvent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, UICanvasBase canvas)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276989, XrefRangeEnd = 1277035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, ref OpenMenuEvent viewEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref viewEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_OpenMenuEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpenHUDMenuSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr);
        OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (canvasBase));
        OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
        OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr, 100668659);
        OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr, 100668660);
        OpenHUDMenuSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_OpenMenuEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenHUDMenuSystem.__c__DisplayClass12_0>.NativeClassPtr, 100668661);
      }

      public __c__DisplayClass12_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe UICanvasBase canvasBase
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_canvasBase));
          return pointer == System.IntPtr.Zero ? (UICanvasBase) null : new UICanvasBase(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_canvasBase), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe OpenHUDMenuSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (OpenHUDMenuSystem) null : new OpenHUDMenuSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OpenHUDMenuSystem.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
