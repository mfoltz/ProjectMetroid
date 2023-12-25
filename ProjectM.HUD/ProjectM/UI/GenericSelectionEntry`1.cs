// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.GenericSelectionEntry`1
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class GenericSelectionEntry<TData> : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Abstract_Virtual_New_Void_byref_TData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe void Refresh([In] ref TData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericSelectionEntry<TData>.NativeMethodInfoPtr_Refresh_Internal_Abstract_Virtual_New_Void_byref_TData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TData local = ref data;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TData>(objectPointer, false, false);
      local = (TData) valueGeneric;
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1228506, RefRangeEnd = 1228516, XrefRangeStart = 1228504, XrefRangeEnd = 1228506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericSelectionEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionEntry<TData>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericSelectionEntry<TData>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GenericSelectionEntry()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GenericSelectionEntry<TData>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", "GenericSelectionEntry`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionEntry<TData>>.NativeClassPtr);
      GenericSelectionEntry<TData>.NativeMethodInfoPtr_Refresh_Internal_Abstract_Virtual_New_Void_byref_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionEntry<TData>>.NativeClassPtr, 100665163);
      GenericSelectionEntry<TData>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionEntry<TData>>.NativeClassPtr, 100665164);
    }

    public GenericSelectionEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
