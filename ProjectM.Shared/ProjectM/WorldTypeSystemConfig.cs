// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldTypeSystemConfig
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class WorldTypeSystemConfig : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr__ExcludedSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisabledSystems;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Abstract_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AdditionalSystems_Public_get_IEnumerable_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ExcludedSystems_Public_get_IEnumerable_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DisabledSystems_Public_get_IEnumerable_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncludeInternalSystem_Public_Void_Assembly_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeInternalSystem_Public_Void_Assembly_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableInternalSystem_Public_Void_Assembly_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncludeSystem_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeSystem_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSystem_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncludeSystem_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeSystem_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSystem_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncludeSystem_Public_Void_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeSystem_Public_Void_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSystem_Public_Void_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindType_Protected_Boolean_Assembly_String_byref_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe bool RequireExplicitSpawnInWorldDeclaration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldTypeSystemConfig.NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe IEnumerable<Il2CppSystem.Type> AdditionalSystems
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_get_AdditionalSystems_Public_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Type>) null : new IEnumerable<Il2CppSystem.Type>(pointer);
      }
    }

    public unsafe IEnumerable<Il2CppSystem.Type> ExcludedSystems
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_get_ExcludedSystems_Public_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Type>) null : new IEnumerable<Il2CppSystem.Type>(pointer);
      }
    }

    public unsafe IEnumerable<Il2CppSystem.Type> DisabledSystems
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_get_DisabledSystems_Public_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<Il2CppSystem.Type>) null : new IEnumerable<Il2CppSystem.Type>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720845, XrefRangeEnd = 720847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IncludeInternalSystem(Assembly assembly, string typeName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assembly);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeInternalSystem_Public_Void_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720847, XrefRangeEnd = 720849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExcludeInternalSystem(Assembly assembly, string typeName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assembly);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeInternalSystem_Public_Void_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720849, XrefRangeEnd = 720851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableInternalSystem(Assembly assembly, string typeName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assembly);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_DisableInternalSystem_Public_Void_Assembly_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 720857, RefRangeEnd = 720902, XrefRangeStart = 720851, XrefRangeEnd = 720857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IncludeSystem<T>()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.MethodInfoStoreGeneric_IncludeSystem_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(18)]
    [CachedScanResults(RefRangeStart = 720908, RefRangeEnd = 720926, XrefRangeStart = 720902, XrefRangeEnd = 720908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExcludeSystem<T>()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.MethodInfoStoreGeneric_ExcludeSystem_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720926, XrefRangeEnd = 720932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableSystem<T>()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.MethodInfoStoreGeneric_DisableSystem_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 720941, RefRangeEnd = 720944, XrefRangeStart = 720932, XrefRangeEnd = 720941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IncludeSystem(string typeStr)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 720953, RefRangeEnd = 720964, XrefRangeStart = 720944, XrefRangeEnd = 720953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExcludeSystem(string typeStr)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 720973, RefRangeEnd = 720978, XrefRangeStart = 720964, XrefRangeEnd = 720973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableSystem(string typeStr)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(typeStr);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 720994, RefRangeEnd = 720997, XrefRangeStart = 720978, XrefRangeEnd = 720994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IncludeSystem(Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 721013, RefRangeEnd = 721016, XrefRangeStart = 720997, XrefRangeEnd = 721013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ExcludeSystem(Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 721032, RefRangeEnd = 721035, XrefRangeStart = 721016, XrefRangeEnd = 721032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisableSystem(Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 721068, RefRangeEnd = 721071, XrefRangeStart = 721035, XrefRangeEnd = 721068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindType(Assembly assembly, string typeName, out Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assembly);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(typeName);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr_TryFindType_Protected_Boolean_Assembly_String_byref_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Type local = ref type;
      System.IntPtr pointer = zero;
      Il2CppSystem.Type type1 = pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      local = type1;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 721089, RefRangeEnd = 721096, XrefRangeStart = 721071, XrefRangeEnd = 721089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldTypeSystemConfig()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeSystemConfig.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldTypeSystemConfig()
    {
      Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldTypeSystemConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr);
      WorldTypeSystemConfig.NativeFieldInfoPtr__AdditionalSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, nameof (_AdditionalSystems));
      WorldTypeSystemConfig.NativeFieldInfoPtr__ExcludedSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, nameof (_ExcludedSystems));
      WorldTypeSystemConfig.NativeFieldInfoPtr__DisabledSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, nameof (_DisabledSystems));
      WorldTypeSystemConfig.NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663709);
      WorldTypeSystemConfig.NativeMethodInfoPtr_get_AdditionalSystems_Public_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663710);
      WorldTypeSystemConfig.NativeMethodInfoPtr_get_ExcludedSystems_Public_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663711);
      WorldTypeSystemConfig.NativeMethodInfoPtr_get_DisabledSystems_Public_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663712);
      WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeInternalSystem_Public_Void_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663713);
      WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeInternalSystem_Public_Void_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663714);
      WorldTypeSystemConfig.NativeMethodInfoPtr_DisableInternalSystem_Public_Void_Assembly_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663715);
      WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663716);
      WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663717);
      WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663718);
      WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663719);
      WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663720);
      WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663721);
      WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663722);
      WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663723);
      WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663724);
      WorldTypeSystemConfig.NativeMethodInfoPtr_TryFindType_Protected_Boolean_Assembly_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663725);
      WorldTypeSystemConfig.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr, 100663726);
    }

    public WorldTypeSystemConfig(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HashSet<Il2CppSystem.Type> _AdditionalSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__AdditionalSystems));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__AdditionalSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<Il2CppSystem.Type> _ExcludedSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__ExcludedSystems));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__ExcludedSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HashSet<Il2CppSystem.Type> _DisabledSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__DisabledSystems));
        return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeSystemConfig.NativeFieldInfoPtr__DisabledSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_IncludeSystem_Public_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(WorldTypeSystemConfig.NativeMethodInfoPtr_IncludeSystem_Public_Void_0, Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ExcludeSystem_Public_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(WorldTypeSystemConfig.NativeMethodInfoPtr_ExcludeSystem_Public_Void_0, Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_DisableSystem_Public_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(WorldTypeSystemConfig.NativeMethodInfoPtr_DisableSystem_Public_Void_0, Il2CppClassPointerStore<WorldTypeSystemConfig>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
