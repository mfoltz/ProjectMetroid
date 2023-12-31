// Decompiled with JetBrains decompiler
// Type: ProjectM.RefinementstationRecipesBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RefinementstationRecipesBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Unlocked;
    [FieldOffset(0)]
    public PrefabGUID RecipeGuid;
    [FieldOffset(4)]
    public bool Unlocked;

    static RefinementstationRecipesBuffer()
    {
      Il2CppClassPointerStore<RefinementstationRecipesBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RefinementstationRecipesBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefinementstationRecipesBuffer>.NativeClassPtr);
      RefinementstationRecipesBuffer.NativeFieldInfoPtr_RecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipesBuffer>.NativeClassPtr, nameof (RecipeGuid));
      RefinementstationRecipesBuffer.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefinementstationRecipesBuffer>.NativeClassPtr, nameof (Unlocked));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefinementstationRecipesBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
