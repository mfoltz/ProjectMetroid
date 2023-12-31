// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.ConditionCheckBegin
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionCheckBegin
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Element;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    [FieldOffset(0)]
    public ConditionElement Element;
    [FieldOffset(40)]
    public int Index;

    static ConditionCheckBegin()
    {
      Il2CppClassPointerStore<ConditionCheckBegin>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (ConditionCheckBegin));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionCheckBegin>.NativeClassPtr);
      ConditionCheckBegin.NativeFieldInfoPtr_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckBegin>.NativeClassPtr, nameof (Element));
      ConditionCheckBegin.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionCheckBegin>.NativeClassPtr, nameof (Index));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionCheckBegin>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
