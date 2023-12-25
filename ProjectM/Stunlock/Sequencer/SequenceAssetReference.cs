// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.SequenceAssetReference
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SequenceAssetReference
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SequenceEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceAssetReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAsset_Public_Static_Boolean_EntityManager_SequenceAssetReference_0;
    [FieldOffset(0)]
    public Entity SequenceEntity;
    [FieldOffset(8)]
    public int AssetIndex;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 193134, RefRangeEnd = 193146, XrefRangeStart = 193134, XrefRangeEnd = 193146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceAssetReference(Entity sequenceEntity, int assetIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &sequenceEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &assetIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceAssetReference.NativeMethodInfoPtr__ctor_Public_Void_Entity_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SequenceAssetReference other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceAssetReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceAssetReference_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923735, XrefRangeEnd = 923739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceAssetReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceAssetReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923739, XrefRangeEnd = 923744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryGetAsset<T>(
      EntityManager entityManager,
      SequenceAssetReference sequenceAssetReference)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sequenceAssetReference;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceAssetReference.MethodInfoStoreGeneric_TryGetAsset_Public_Static_Boolean_EntityManager_SequenceAssetReference_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SequenceAssetReference()
    {
      Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (SequenceAssetReference));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr);
      SequenceAssetReference.NativeFieldInfoPtr_SequenceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, nameof (SequenceEntity));
      SequenceAssetReference.NativeFieldInfoPtr_AssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, nameof (AssetIndex));
      SequenceAssetReference.NativeMethodInfoPtr__ctor_Public_Void_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, 100663910);
      SequenceAssetReference.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SequenceAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, 100663911);
      SequenceAssetReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, 100663912);
      SequenceAssetReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, 100663913);
      SequenceAssetReference.NativeMethodInfoPtr_TryGetAsset_Public_Static_Boolean_EntityManager_SequenceAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, 100663914);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_TryGetAsset_Public_Static_Boolean_EntityManager_SequenceAssetReference_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceAssetReference.NativeMethodInfoPtr_TryGetAsset_Public_Static_Boolean_EntityManager_SequenceAssetReference_0, Il2CppClassPointerStore<SequenceAssetReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
