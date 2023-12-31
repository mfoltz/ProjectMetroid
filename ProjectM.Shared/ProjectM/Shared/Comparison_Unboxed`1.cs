// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Comparison_Unboxed`1
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace ProjectM.Shared
{
  public struct Comparison_Unboxed<TValue> where TValue : unmanaged
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_ValueRHS;
    public ConditionTypes Type;
    public TValue ValueRHS;

    static Comparison_Unboxed()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Comparison_Unboxed<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", "Comparison`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparison_Unboxed<TValue>>.NativeClassPtr);
      Comparison_Unboxed<TValue>.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparison_Unboxed<TValue>>.NativeClassPtr, nameof (Type));
      Comparison_Unboxed<TValue>.NativeFieldInfoPtr_ValueRHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparison_Unboxed<TValue>>.NativeClassPtr, nameof (ValueRHS));
    }

    public Comparison<TValue> BoxIl2CppObject()
    {
      return new Comparison<TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Comparison_Unboxed<TValue>>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
