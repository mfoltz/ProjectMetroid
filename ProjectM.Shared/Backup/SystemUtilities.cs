// Decompiled with JetBrains decompiler
// Type: SystemUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
public static class SystemUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntityQueryDesc_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntityQueryDescWithAny_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_Il2CppStructArray_1_ComponentType_0;

  [CallerCount(111)]
  [CachedScanResults(RefRangeStart = 716671, RefRangeEnd = 716782, XrefRangeStart = 716608, XrefRangeEnd = 716671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQueryDesc CreateEntityQueryDesc(
    EntityQueryOptions options,
    [Optional] Il2CppStructArray<ComponentType> componentTypes)
  {
    if (componentTypes == null)
      componentTypes = new Il2CppStructArray<ComponentType>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.NativeMethodInfoPtr_CreateEntityQueryDesc_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (EntityQueryDesc) null : new EntityQueryDesc(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716782, XrefRangeEnd = 716846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EntityQueryDesc CreateEntityQueryDescWithAny(
    EntityQueryOptions options,
    Il2CppStructArray<ComponentType> any,
    [Optional] Il2CppStructArray<ComponentType> componentTypes)
  {
    if (componentTypes == null)
      componentTypes = new Il2CppStructArray<ComponentType>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) any);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.NativeMethodInfoPtr_CreateEntityQueryDescWithAny_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_Il2CppStructArray_1_ComponentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (EntityQueryDesc) null : new EntityQueryDesc(pointer);
  }

  public static EntityQueryDesc CreateEntityQueryDesc(
    EntityQueryOptions options,
    params ComponentType[] componentTypes)
  {
    return SystemUtilities.CreateEntityQueryDesc(options, new Il2CppStructArray<ComponentType>(componentTypes));
  }

  public static EntityQueryDesc CreateEntityQueryDescWithAny(
    EntityQueryOptions options,
    Il2CppStructArray<ComponentType> any,
    params ComponentType[] componentTypes)
  {
    return SystemUtilities.CreateEntityQueryDescWithAny(options, any, new Il2CppStructArray<ComponentType>(componentTypes));
  }

  static SystemUtilities()
  {
    Il2CppClassPointerStore<SystemUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (SystemUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemUtilities>.NativeClassPtr);
    SystemUtilities.NativeMethodInfoPtr_CreateEntityQueryDesc_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities>.NativeClassPtr, 100663449);
    SystemUtilities.NativeMethodInfoPtr_CreateEntityQueryDescWithAny_Public_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities>.NativeClassPtr, 100663450);
  }

  public SystemUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("SystemUtilities/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_0_Internal_Boolean_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_1_Internal_Boolean_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_2_Internal_ComponentType_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_0_Internal_Boolean_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_1_Internal_Boolean_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_2_Internal_ComponentType_ComponentType_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _CreateEntityQueryDesc_b__0_0(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_0_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CreateEntityQueryDesc_b__0_1(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_1_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716606, XrefRangeEnd = 716608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ComponentType _CreateEntityQueryDesc_b__0_2(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_2_Internal_ComponentType_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ComponentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CreateEntityQueryDescWithAny_b__1_0(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_0_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _CreateEntityQueryDescWithAny_b__1_1(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_1_Internal_Boolean_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ComponentType _CreateEntityQueryDescWithAny_b__1_2(ComponentType x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &x;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_2_Internal_ComponentType_ComponentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ComponentType*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SystemUtilities>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr);
      SystemUtilities.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9");
      SystemUtilities.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__0_0");
      SystemUtilities.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__0_1");
      SystemUtilities.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__0_2");
      SystemUtilities.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__1_0");
      SystemUtilities.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__1_1");
      SystemUtilities.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, "<>9__1_2");
      SystemUtilities.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663452);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_0_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663453);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_1_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663454);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDesc_b__0_2_Internal_ComponentType_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663455);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_0_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663456);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_1_Internal_Boolean_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663457);
      SystemUtilities.__c.NativeMethodInfoPtr__CreateEntityQueryDescWithAny_b__1_2_Internal_ComponentType_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemUtilities.__c>.NativeClassPtr, 100663458);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe SystemUtilities.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (SystemUtilities.__c) null : new SystemUtilities.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, bool> __9__0_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, bool> __9__0_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, ComponentType> __9__0_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, ComponentType>) null : new Il2CppSystem.Func<ComponentType, ComponentType>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__0_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, bool> __9__1_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, bool> __9__1_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, bool>) null : new Il2CppSystem.Func<ComponentType, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ComponentType, ComponentType> __9__1_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ComponentType, ComponentType>) null : new Il2CppSystem.Func<ComponentType, ComponentType>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SystemUtilities.__c.NativeFieldInfoPtr___9__1_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
