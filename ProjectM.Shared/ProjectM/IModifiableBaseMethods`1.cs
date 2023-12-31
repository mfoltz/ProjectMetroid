// Decompiled with JetBrains decompiler
// Type: ProjectM.IModifiableBaseMethods`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class IModifiableBaseMethods<TValue> : Il2CppObjectBase
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ServerGameManager_Entity_ModificationId_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ClientGameManager_Entity_ModificationId_TValue_0;

    [CallerCount(0)]
    public virtual unsafe ModificationId ApplyModification(
      ServerGameManager game,
      Entity self,
      Entity target,
      ModificationType modType,
      TValue modValue,
      int priority = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe bool ModifyModification(
      ServerGameManager game,
      Entity entity,
      ModificationId id,
      TValue modValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ServerGameManager_Entity_ModificationId_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe ModificationId ApplyModification(
      ClientGameManager game,
      Entity self,
      Entity target,
      ModificationType modType,
      TValue modValue,
      int priority = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modType;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ModificationId*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe bool ModifyModification(
      ClientGameManager game,
      Entity entity,
      ModificationId id,
      TValue modValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TValue& local1;
      if (!typeof (TValue).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TValue> local2 = (object) modValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref modValue;
      *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ClientGameManager_Entity_ModificationId_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    static IModifiableBaseMethods()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IModifiableBaseMethods<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "IModifiableBaseMethods`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ServerGameManager_Entity_Entity_ModificationType_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableBaseMethods<TValue>>.NativeClassPtr, 100665740);
      IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ServerGameManager_Entity_ModificationId_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableBaseMethods<TValue>>.NativeClassPtr, 100665741);
      IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ApplyModification_Public_Abstract_Virtual_New_ModificationId_ClientGameManager_Entity_Entity_ModificationType_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableBaseMethods<TValue>>.NativeClassPtr, 100665742);
      IModifiableBaseMethods<TValue>.NativeMethodInfoPtr_ModifyModification_Public_Abstract_Virtual_New_Boolean_ClientGameManager_Entity_ModificationId_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableBaseMethods<TValue>>.NativeClassPtr, 100665743);
    }

    public IModifiableBaseMethods(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
