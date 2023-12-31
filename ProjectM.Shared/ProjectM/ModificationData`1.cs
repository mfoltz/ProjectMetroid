// Decompiled with JetBrains decompiler
// Type: ProjectM.ModificationData`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public struct ModificationData<T> where T : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
    private static readonly System.IntPtr NativeFieldInfoPtr_ModifiableId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Source;
    public ModificationId Id;
    public ModificationType ModType;
    public T ModValue;
    public int Priority;
    public int ModifiableId;
    public Entity Source;

    static ModificationData()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", "ModificationData`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr);
      ModificationData<T>.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (Id));
      ModificationData<T>.NativeFieldInfoPtr_ModType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (ModType));
      ModificationData<T>.NativeFieldInfoPtr_ModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (ModValue));
      ModificationData<T>.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (Priority));
      ModificationData<T>.NativeFieldInfoPtr_ModifiableId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (ModifiableId));
      ModificationData<T>.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, nameof (Source));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModificationData<T>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
