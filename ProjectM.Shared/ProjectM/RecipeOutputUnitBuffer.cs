// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeOutputUnitBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RecipeOutputUnitBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public int Stacks;

    static RecipeOutputUnitBuffer()
    {
      Il2CppClassPointerStore<RecipeOutputUnitBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RecipeOutputUnitBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeOutputUnitBuffer>.NativeClassPtr);
      RecipeOutputUnitBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputUnitBuffer>.NativeClassPtr, nameof (Guid));
      RecipeOutputUnitBuffer.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputUnitBuffer>.NativeClassPtr, nameof (Stacks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeOutputUnitBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
