// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityDebuggingUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class EntityDebuggingUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpComponent_Public_Static_Void_World_Entity_ComponentType_Boolean_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintFields_Private_Static_Void_Int32_StringBuilder_ptr_Byte_HashSet_1_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendIndent_Private_Static_Void_Int32_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySpecialTypeHandling_Private_Static_Boolean_FieldInfo_ptr_Byte_StringBuilder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpBlobAsset_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpBlobArray_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadField_Private_Static_T_FieldInfo_ptr_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintPrimitiveValue_Private_Static_Void_StringBuilder_Type_ptr_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Read_Private_Static_T_ptr_Byte_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 733824, RefRangeEnd = 733826, XrefRangeStart = 733813, XrefRangeEnd = 733824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpEntity(World world, Entity entity, bool fullDump)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullDump;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 733850, RefRangeEnd = 733852, XrefRangeStart = 733826, XrefRangeEnd = 733850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpEntity(
      World world,
      Entity entity,
      bool fullDump,
      StringBuilder stringBuilder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fullDump;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 733897, RefRangeEnd = 733899, XrefRangeStart = 733852, XrefRangeEnd = 733897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpComponent(
      World world,
      Entity entity,
      ComponentType componentType,
      bool fullDump,
      StringBuilder stringBuilder)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &componentType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &fullDump;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_DumpComponent_Public_Static_Void_World_Entity_ComponentType_Boolean_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 733970, RefRangeEnd = 733974, XrefRangeStart = 733899, XrefRangeEnd = 733970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrintFields(
      int indent,
      StringBuilder sb,
      byte* dataPtr,
      HashSet<Il2CppSystem.Type> alreadyVisitedTypes,
      Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) dataPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyVisitedTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_PrintFields_Private_Static_Void_Int32_StringBuilder_ptr_Byte_HashSet_1_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733974, XrefRangeEnd = 733976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AppendIndent(int indent, StringBuilder sb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_AppendIndent_Private_Static_Void_Int32_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734084, RefRangeEnd = 734085, XrefRangeStart = 733976, XrefRangeEnd = 734084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TrySpecialTypeHandling(
      FieldInfo field,
      byte* fieldPtr,
      StringBuilder sb)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) fieldPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_TrySpecialTypeHandling_Private_Static_Boolean_FieldInfo_ptr_Byte_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734090, RefRangeEnd = 734091, XrefRangeStart = 734085, XrefRangeEnd = 734090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpBlobAsset(
      int indent,
      StringBuilder sb,
      FieldInfo blobField,
      HashSet<Il2CppSystem.Type> alreadyVisitedTypes,
      byte* fieldPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blobField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyVisitedTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) fieldPtr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_DumpBlobAsset_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734125, RefRangeEnd = 734126, XrefRangeStart = 734091, XrefRangeEnd = 734125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpBlobArray(
      int indent,
      StringBuilder sb,
      FieldInfo blobArrayField,
      HashSet<Il2CppSystem.Type> alreadyVisitedTypes,
      byte* blobArrayFieldPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &indent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blobArrayField);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) alreadyVisitedTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) blobArrayFieldPtr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_DumpBlobArray_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 734127, RefRangeEnd = 734129, XrefRangeStart = 734126, XrefRangeEnd = 734127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T ReadField<T>(FieldInfo field, byte* parentPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) parentPtr;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.MethodInfoStoreGeneric_ReadField_Private_Static_T_FieldInfo_ptr_Byte_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 734221, RefRangeEnd = 734222, XrefRangeStart = 734129, XrefRangeEnd = 734221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrintPrimitiveValue(StringBuilder sb, Il2CppSystem.Type type, byte* fieldPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) (void*) fieldPtr;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.NativeMethodInfoPtr_PrintPrimitiveValue_Private_Static_Void_StringBuilder_Type_ptr_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(83)]
    [CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T Read<T>(byte* dataPtr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) (void*) dataPtr;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(EntityDebuggingUtility.MethodInfoStoreGeneric_Read_Private_Static_T_ptr_Byte_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static EntityDebuggingUtility()
    {
      Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityDebuggingUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr);
      EntityDebuggingUtility.NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664846);
      EntityDebuggingUtility.NativeMethodInfoPtr_DumpEntity_Public_Static_Void_World_Entity_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664847);
      EntityDebuggingUtility.NativeMethodInfoPtr_DumpComponent_Public_Static_Void_World_Entity_ComponentType_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664848);
      EntityDebuggingUtility.NativeMethodInfoPtr_PrintFields_Private_Static_Void_Int32_StringBuilder_ptr_Byte_HashSet_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664849);
      EntityDebuggingUtility.NativeMethodInfoPtr_AppendIndent_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664850);
      EntityDebuggingUtility.NativeMethodInfoPtr_TrySpecialTypeHandling_Private_Static_Boolean_FieldInfo_ptr_Byte_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664851);
      EntityDebuggingUtility.NativeMethodInfoPtr_DumpBlobAsset_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664852);
      EntityDebuggingUtility.NativeMethodInfoPtr_DumpBlobArray_Private_Static_Void_Int32_StringBuilder_FieldInfo_HashSet_1_Type_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664853);
      EntityDebuggingUtility.NativeMethodInfoPtr_ReadField_Private_Static_T_FieldInfo_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664854);
      EntityDebuggingUtility.NativeMethodInfoPtr_PrintPrimitiveValue_Private_Static_Void_StringBuilder_Type_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664855);
      EntityDebuggingUtility.NativeMethodInfoPtr_Read_Private_Static_T_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr, 100664856);
    }

    public EntityDebuggingUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_ReadField_Private_Static_T_FieldInfo_ptr_Byte_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityDebuggingUtility.NativeMethodInfoPtr_ReadField_Private_Static_T_FieldInfo_ptr_Byte_0, Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Read_Private_Static_T_ptr_Byte_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityDebuggingUtility.NativeMethodInfoPtr_Read_Private_Static_T_ptr_Byte_0, Il2CppClassPointerStore<EntityDebuggingUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
