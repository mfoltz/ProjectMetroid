// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.CreateCharacterEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateCharacterEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GenderIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SkintoneIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FaceIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EyeColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairStyleIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_HairColorIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FeaturesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessoriesIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public byte GenderIndex;
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
    [FieldOffset(8)]
    public FixedString64 Name;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146074, XrefRangeEnd = 1146083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateCharacterEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1146092, RefRangeEnd = 1146093, XrefRangeStart = 1146083, XrefRangeEnd = 1146092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateCharacterEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateCharacterEvent()
    {
      Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (CreateCharacterEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr);
      CreateCharacterEvent.NativeFieldInfoPtr_GenderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (GenderIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_SkintoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (SkintoneIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_FaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (FaceIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_EyeColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (EyeColorIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_HairStyleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (HairStyleIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_HairColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (HairColorIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_FeaturesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (FeaturesIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_AccessoriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (AccessoriesIndex));
      CreateCharacterEvent.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, nameof (Name));
      CreateCharacterEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, 100690944);
      CreateCharacterEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, 100690945);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateCharacterEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
