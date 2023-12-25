// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform
{
  public sealed class InitializeOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductName_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProductVersion_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_Nullable_Unboxed_1_InitializeThreadAffinity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0;

    public unsafe System.IntPtr AllocateMemoryFunction
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr ReallocateMemoryFunction
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr ReleaseMemoryFunction
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductName
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductVersion
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe System.IntPtr SystemInitializeOptions
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Nullable_Unboxed<InitializeThreadAffinity> OverrideThreadAffinity
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_Nullable_Unboxed_1_InitializeThreadAffinity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Nullable_Unboxed<InitializeThreadAffinity>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static InitializeOptions()
    {
      Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Platform", nameof (InitializeOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr);
      InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<AllocateMemoryFunction>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ReallocateMemoryFunction>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ReleaseMemoryFunction>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ProductName>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ProductVersion>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<SystemInitializeOptions>k__BackingField");
      InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<OverrideThreadAffinity>k__BackingField");
      InitializeOptions.NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674654);
      InitializeOptions.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674655);
      InitializeOptions.NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674656);
      InitializeOptions.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674657);
      InitializeOptions.NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674658);
      InitializeOptions.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674659);
      InitializeOptions.NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674660);
      InitializeOptions.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674661);
      InitializeOptions.NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674662);
      InitializeOptions.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674663);
      InitializeOptions.NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674664);
      InitializeOptions.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674665);
      InitializeOptions.NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_Nullable_Unboxed_1_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674666);
      InitializeOptions.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_Nullable_Unboxed_1_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100674667);
    }

    public InitializeOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public InitializeOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, data));
    }

    public unsafe System.IntPtr _AllocateMemoryFunction_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField)) = value;
      }
    }

    public unsafe System.IntPtr _ReallocateMemoryFunction_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField)) = value;
      }
    }

    public unsafe System.IntPtr _ReleaseMemoryFunction_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField)) = value;
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _ProductName_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String _ProductVersion_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe System.IntPtr _SystemInitializeOptions_k__BackingField
    {
      get
      {
        return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField));
      }
      [param: In] set
      {
        *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField)) = value;
      }
    }

    public unsafe Nullable_Unboxed<InitializeThreadAffinity> _OverrideThreadAffinity_k__BackingField
    {
      get
      {
        return *(Nullable_Unboxed<InitializeThreadAffinity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<InitializeThreadAffinity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
