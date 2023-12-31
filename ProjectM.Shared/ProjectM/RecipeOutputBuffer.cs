// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeOutputBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RecipeOutputBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public int Amount;

    static RecipeOutputBuffer()
    {
      Il2CppClassPointerStore<RecipeOutputBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RecipeOutputBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeOutputBuffer>.NativeClassPtr);
      RecipeOutputBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputBuffer>.NativeClassPtr, nameof (Guid));
      RecipeOutputBuffer.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeOutputBuffer>.NativeClassPtr, nameof (Amount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeOutputBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
