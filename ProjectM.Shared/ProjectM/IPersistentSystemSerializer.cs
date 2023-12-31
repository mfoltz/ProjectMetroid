// Decompiled with JetBrains decompiler
// Type: ProjectM.IPersistentSystemSerializer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Network;
using System;

#nullable disable
namespace ProjectM
{
  public class IPersistentSystemSerializer : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_PersistentIdentifier_Public_Abstract_Virtual_New_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_0;
    private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_0;

    public virtual unsafe string PersistentIdentifier
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPersistentSystemSerializer.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref netBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPersistentSystemSerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) ref netBuffer;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPersistentSystemSerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IPersistentSystemSerializer()
    {
      Il2CppClassPointerStore<IPersistentSystemSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IPersistentSystemSerializer));
      IPersistentSystemSerializer.NativeMethodInfoPtr_get_PersistentIdentifier_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistentSystemSerializer>.NativeClassPtr, 100665819);
      IPersistentSystemSerializer.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Void_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistentSystemSerializer>.NativeClassPtr, 100665820);
      IPersistentSystemSerializer.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistentSystemSerializer>.NativeClassPtr, 100665821);
    }

    public IPersistentSystemSerializer(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
