// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.InteractEvents_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  public class InteractEvents_Client : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractEvents_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractEvents_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractEvents_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractEvents_Client()
    {
      Il2CppClassPointerStore<InteractEvents_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (InteractEvents_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractEvents_Client>.NativeClassPtr);
      InteractEvents_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractEvents_Client>.NativeClassPtr, 100691003);
    }

    public InteractEvents_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RenameInteractable
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NewName;
      private static readonly System.IntPtr NativeFieldInfoPtr_InteractableId;
      private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
      [FieldOffset(0)]
      public FixedString64 NewName;
      [FieldOffset(64)]
      public NetworkId InteractableId;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1146443, XrefRangeEnd = 1146448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractEvents_Client.RenameInteractable.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1146453, RefRangeEnd = 1146454, XrefRangeStart = 1146448, XrefRangeEnd = 1146453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref netBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractEvents_Client.RenameInteractable.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RenameInteractable()
      {
        Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractEvents_Client>.NativeClassPtr, nameof (RenameInteractable));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr);
        InteractEvents_Client.RenameInteractable.NativeFieldInfoPtr_NewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr, nameof (NewName));
        InteractEvents_Client.RenameInteractable.NativeFieldInfoPtr_InteractableId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr, nameof (InteractableId));
        InteractEvents_Client.RenameInteractable.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr, 100691004);
        InteractEvents_Client.RenameInteractable.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr, 100691005);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractEvents_Client.RenameInteractable>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
