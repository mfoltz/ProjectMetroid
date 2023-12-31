// Decompiled with JetBrains decompiler
// Type: ProjectM.NetworkedEntityModificationBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetworkedEntityModificationBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_NetworkedEntity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_NetworkedEntity_0;
    [FieldOffset(0)]
    public ModificationData<NetworkedEntity> _ModData_k__BackingField;

    public virtual unsafe ModificationData<NetworkedEntity> ModData
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetworkedEntityModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_NetworkedEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ModificationData<NetworkedEntity>*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetworkedEntityModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_NetworkedEntity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static NetworkedEntityModificationBuffer()
    {
      Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NetworkedEntityModificationBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr);
      NetworkedEntityModificationBuffer.NativeFieldInfoPtr__ModData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr, "<ModData>k__BackingField");
      NetworkedEntityModificationBuffer.NativeMethodInfoPtr_get_ModData_Public_Virtual_Final_New_get_ModificationData_1_NetworkedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr, 100665662);
      NetworkedEntityModificationBuffer.NativeMethodInfoPtr_set_ModData_Public_Virtual_Final_New_set_Void_ModificationData_1_NetworkedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr, 100665663);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkedEntityModificationBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
