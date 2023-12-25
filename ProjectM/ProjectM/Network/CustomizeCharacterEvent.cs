// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CustomizeCharacterEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CustomizeCharacterEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyTypeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoriesIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContainsValidData_Public_Boolean_Entity_UserContentFlags_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Boolean_Byte_UserContentFlags_DynamicBuffer_1_T_0;
    [FieldOffset(0)]
    public byte BodyTypeIndex;
    [FieldOffset(1)]
    public byte SkintoneIndex;
    [FieldOffset(2)]
    public byte FaceIndex;
    [FieldOffset(3)]
    public byte EyeColorIndex;
    [FieldOffset(4)]
    public byte HairStyleIndex;
    [FieldOffset(5)]
    public byte HairColorIndex;
    [FieldOffset(6)]
    public byte FeaturesIndex;
    [FieldOffset(7)]
    public byte AccessoriesIndex;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145790, XrefRangeEnd = 1145798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizeCharacterEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145806, RefRangeEnd = 1145807, XrefRangeStart = 1145798, XrefRangeEnd = 1145806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomizeCharacterEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1145842, RefRangeEnd = 1145843, XrefRangeStart = 1145807, XrefRangeEnd = 1145842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ContainsValidData(
      Entity customizationSettingsEntity,
      UserContentFlags userContent,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &customizationSettingsEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomizeCharacterEvent.NativeMethodInfoPtr_ContainsValidData_Public_Boolean_Entity_UserContentFlags_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145843, XrefRangeEnd = 1145846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckFeaturesRequirements<T>(
      byte index,
      UserContentFlags userContent,
      DynamicBuffer<T> features)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userContent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &features;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomizeCharacterEvent.MethodInfoStoreGeneric_CheckFeaturesRequirements_Private_Boolean_Byte_UserContentFlags_DynamicBuffer_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CustomizeCharacterEvent()
    {
      Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CustomizeCharacterEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr);
      CustomizeCharacterEvent.NativeFieldInfoPtr_BodyTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (BodyTypeIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (SkintoneIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (FaceIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (EyeColorIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (HairStyleIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (HairColorIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (FeaturesIndex));
      CustomizeCharacterEvent.NativeFieldInfoPtr_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, nameof (AccessoriesIndex));
      CustomizeCharacterEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, 100690856);
      CustomizeCharacterEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, 100690857);
      CustomizeCharacterEvent.NativeMethodInfoPtr_ContainsValidData_Public_Boolean_Entity_UserContentFlags_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, 100690858);
      CustomizeCharacterEvent.NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Boolean_Byte_UserContentFlags_DynamicBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, 100690859);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_CheckFeaturesRequirements_Private_Boolean_Byte_UserContentFlags_DynamicBuffer_1_T_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomizeCharacterEvent.NativeMethodInfoPtr_CheckFeaturesRequirements_Private_Boolean_Byte_UserContentFlags_DynamicBuffer_1_T_0, Il2CppClassPointerStore<CustomizeCharacterEvent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
