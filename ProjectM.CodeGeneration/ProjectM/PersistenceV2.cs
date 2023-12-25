// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceV2
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class PersistenceV2 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SERIALIZATION_FORMAT_VERSION;

    static PersistenceV2()
    {
      Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM", nameof (PersistenceV2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr);
      PersistenceV2.NativeFieldInfoPtr_SERIALIZATION_FORMAT_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (SERIALIZATION_FORMAT_VERSION));
    }

    public PersistenceV2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int SERIALIZATION_FORMAT_VERSION
    {
      get
      {
        int serializationFormatVersion;
        IL2CPP.il2cpp_field_static_get_value(PersistenceV2.NativeFieldInfoPtr_SERIALIZATION_FORMAT_VERSION, (void*) &serializationFormatVersion);
        return serializationFormatVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PersistenceV2.NativeFieldInfoPtr_SERIALIZATION_FORMAT_VERSION, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LoadedTag
    {
      static LoadedTag()
      {
        Il2CppClassPointerStore<PersistenceV2.LoadedTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (LoadedTag));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.LoadedTag>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2.LoadedTag>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct DontSaveEntity
    {
      static DontSaveEntity()
      {
        Il2CppClassPointerStore<PersistenceV2.DontSaveEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (DontSaveEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.DontSaveEntity>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2.DontSaveEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct StoreSubSceneEntity
    {
      static StoreSubSceneEntity()
      {
        Il2CppClassPointerStore<PersistenceV2.StoreSubSceneEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (StoreSubSceneEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.StoreSubSceneEntity>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2.StoreSubSceneEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MissingStoreSubSceneEntity
    {
      static MissingStoreSubSceneEntity()
      {
        Il2CppClassPointerStore<PersistenceV2.MissingStoreSubSceneEntity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (MissingStoreSubSceneEntity));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.MissingStoreSubSceneEntity>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceV2.MissingStoreSubSceneEntity>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public class IncludeComponentAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe IncludeComponentAttribute()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.IncludeComponentAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.IncludeComponentAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static IncludeComponentAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.IncludeComponentAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (IncludeComponentAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.IncludeComponentAttribute>.NativeClassPtr);
        PersistenceV2.IncludeComponentAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.IncludeComponentAttribute>.NativeClassPtr, 100663299);
      }

      public IncludeComponentAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class ExcludeComponentAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Options;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceOptions_0;

      [CallerCount(19)]
      [CachedScanResults(RefRangeStart = 73013, RefRangeEnd = 73032, XrefRangeStart = 73013, XrefRangeEnd = 73032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExcludeComponentAttribute(ExcludePersistenceOptions options = ExcludePersistenceOptions.CopyDataFromPrefab)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.ExcludeComponentAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &options;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.ExcludeComponentAttribute.NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ExcludeComponentAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.ExcludeComponentAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (ExcludeComponentAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.ExcludeComponentAttribute>.NativeClassPtr);
        PersistenceV2.ExcludeComponentAttribute.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2.ExcludeComponentAttribute>.NativeClassPtr, nameof (Options));
        PersistenceV2.ExcludeComponentAttribute.NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.ExcludeComponentAttribute>.NativeClassPtr, 100663300);
      }

      public ExcludeComponentAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ExcludePersistenceOptions Options
      {
        get
        {
          return *(ExcludePersistenceOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2.ExcludeComponentAttribute.NativeFieldInfoPtr_Options));
        }
        [param: In] set
        {
          *(ExcludePersistenceOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2.ExcludeComponentAttribute.NativeFieldInfoPtr_Options)) = value;
        }
      }
    }

    public class ExcludeFieldAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Options;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceFieldOptions_0;

      [CallerCount(19)]
      [CachedScanResults(RefRangeStart = 73013, RefRangeEnd = 73032, XrefRangeStart = 73013, XrefRangeEnd = 73032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExcludeFieldAttribute(ExcludePersistenceFieldOptions options = ExcludePersistenceFieldOptions.CopyDataFromPrefab)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.ExcludeFieldAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &options;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.ExcludeFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceFieldOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ExcludeFieldAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.ExcludeFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (ExcludeFieldAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.ExcludeFieldAttribute>.NativeClassPtr);
        PersistenceV2.ExcludeFieldAttribute.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceV2.ExcludeFieldAttribute>.NativeClassPtr, nameof (Options));
        PersistenceV2.ExcludeFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_ExcludePersistenceFieldOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.ExcludeFieldAttribute>.NativeClassPtr, 100663301);
      }

      public ExcludeFieldAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ExcludePersistenceFieldOptions Options
      {
        get
        {
          return *(ExcludePersistenceFieldOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2.ExcludeFieldAttribute.NativeFieldInfoPtr_Options));
        }
        [param: In] set
        {
          *(ExcludePersistenceFieldOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceV2.ExcludeFieldAttribute.NativeFieldInfoPtr_Options)) = value;
        }
      }
    }

    public class ComponentExcludesEntityAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ComponentExcludesEntityAttribute()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.ComponentExcludesEntityAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.ComponentExcludesEntityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ComponentExcludesEntityAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.ComponentExcludesEntityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (ComponentExcludesEntityAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.ComponentExcludesEntityAttribute>.NativeClassPtr);
        PersistenceV2.ComponentExcludesEntityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.ComponentExcludesEntityAttribute>.NativeClassPtr, 100663302);
      }

      public ComponentExcludesEntityAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class PersistenceTestingSystemAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PersistenceTestingSystemAttribute()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.PersistenceTestingSystemAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.PersistenceTestingSystemAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PersistenceTestingSystemAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.PersistenceTestingSystemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (PersistenceTestingSystemAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.PersistenceTestingSystemAttribute>.NativeClassPtr);
        PersistenceV2.PersistenceTestingSystemAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.PersistenceTestingSystemAttribute>.NativeClassPtr, 100663303);
      }

      public PersistenceTestingSystemAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class IgnoreRemappingErrorAttribute : Il2CppSystem.Attribute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe IgnoreRemappingErrorAttribute()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceV2.IgnoreRemappingErrorAttribute>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceV2.IgnoreRemappingErrorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static IgnoreRemappingErrorAttribute()
      {
        Il2CppClassPointerStore<PersistenceV2.IgnoreRemappingErrorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceV2>.NativeClassPtr, nameof (IgnoreRemappingErrorAttribute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2.IgnoreRemappingErrorAttribute>.NativeClassPtr);
        PersistenceV2.IgnoreRemappingErrorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2.IgnoreRemappingErrorAttribute>.NativeClassPtr, 100663304);
      }

      public IgnoreRemappingErrorAttribute(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
