// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomWorld
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CustomWorld : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_World;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParentedSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr_CatchIncorrectDestroy;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_World_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTickedSystem_Public_Void_ComponentSystemGroup_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnhookWorld_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722005, XrefRangeEnd = 722015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomWorld(World world, World parentWorld)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorld.NativeMethodInfoPtr__ctor_Public_Void_World_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722015, XrefRangeEnd = 722020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTickedSystem(
      ComponentSystemGroup parentTickGroup,
      ComponentSystemBase tickedSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentTickGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tickedSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorld.NativeMethodInfoPtr_AddTickedSystem_Public_Void_ComponentSystemGroup_ComponentSystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722053, RefRangeEnd = 722054, XrefRangeStart = 722020, XrefRangeEnd = 722053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnhookWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorld.NativeMethodInfoPtr_UnhookWorld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 722063, RefRangeEnd = 722065, XrefRangeStart = 722054, XrefRangeEnd = 722063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorld.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CustomWorld()
    {
      Il2CppClassPointerStore<CustomWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CustomWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr);
      CustomWorld.NativeFieldInfoPtr_ParentWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, nameof (ParentWorld));
      CustomWorld.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, nameof (World));
      CustomWorld.NativeFieldInfoPtr__ParentedSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, nameof (_ParentedSystems));
      CustomWorld.NativeFieldInfoPtr_CatchIncorrectDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, nameof (CatchIncorrectDestroy));
      CustomWorld.NativeMethodInfoPtr__ctor_Public_Void_World_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, 100663752);
      CustomWorld.NativeMethodInfoPtr_AddTickedSystem_Public_Void_ComponentSystemGroup_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, 100663753);
      CustomWorld.NativeMethodInfoPtr_UnhookWorld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, 100663754);
      CustomWorld.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, 100663755);
    }

    public CustomWorld(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe World ParentWorld
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_ParentWorld));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_ParentWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe World World
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_World));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_World), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CustomWorld.ParentedSystem> _ParentedSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr__ParentedSystems));
        return pointer == System.IntPtr.Zero ? (List<CustomWorld.ParentedSystem>) null : new List<CustomWorld.ParentedSystem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr__ParentedSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeArray<Entity> CatchIncorrectDestroy
    {
      get
      {
        return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_CatchIncorrectDestroy));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.NativeFieldInfoPtr_CatchIncorrectDestroy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class ParentedSystem : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ParentTickGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_TickedSystem;

      static ParentedSystem()
      {
        Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWorld>.NativeClassPtr, nameof (ParentedSystem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr);
        CustomWorld.ParentedSystem.NativeFieldInfoPtr_ParentTickGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr, nameof (ParentTickGroup));
        CustomWorld.ParentedSystem.NativeFieldInfoPtr_TickedSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr, nameof (TickedSystem));
      }

      public ParentedSystem(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ParentedSystem()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomWorld.ParentedSystem>.NativeClassPtr, data));
      }

      public unsafe ComponentSystemGroup ParentTickGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.ParentedSystem.NativeFieldInfoPtr_ParentTickGroup));
          return pointer == System.IntPtr.Zero ? (ComponentSystemGroup) null : new ComponentSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.ParentedSystem.NativeFieldInfoPtr_ParentTickGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentSystemBase TickedSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.ParentedSystem.NativeFieldInfoPtr_TickedSystem));
          return pointer == System.IntPtr.Zero ? (ComponentSystemBase) null : new ComponentSystemBase(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorld.ParentedSystem.NativeFieldInfoPtr_TickedSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
