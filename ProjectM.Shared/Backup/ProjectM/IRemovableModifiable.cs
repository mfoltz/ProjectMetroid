// Decompiled with JetBrains decompiler
// Type: ProjectM.IRemovableModifiable
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class IRemovableModifiable : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt16_0;
    private static readonly IntPtr NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0;

    public virtual unsafe ushort Id
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRemovableModifiable.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe bool RemoveModification(
      EntityManager entityManager,
      Entity entity,
      ModificationId id,
      string callerFilePath = null,
      int callerLineNumber = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &id;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(callerFilePath);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &callerLineNumber;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRemovableModifiable.NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static IRemovableModifiable()
    {
      Il2CppClassPointerStore<IRemovableModifiable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (IRemovableModifiable));
      IRemovableModifiable.NativeMethodInfoPtr_get_Id_Public_Abstract_Virtual_New_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemovableModifiable>.NativeClassPtr, 100665744);
      IRemovableModifiable.NativeMethodInfoPtr_RemoveModification_Public_Abstract_Virtual_New_Boolean_EntityManager_Entity_ModificationId_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemovableModifiable>.NativeClassPtr, 100665745);
    }

    public IRemovableModifiable(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
