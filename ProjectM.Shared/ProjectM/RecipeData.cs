// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RecipeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_HudSortingOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreServerSettings;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public float CraftDuration;
    [FieldOffset(16)]
    public int HudSortingOrder;
    [FieldOffset(20)]
    public bool AlwaysUnlocked;
    [FieldOffset(21)]
    public bool HideInStation;
    [FieldOffset(22)]
    public bool IgnoreServerSettings;

    static RecipeData()
    {
      Il2CppClassPointerStore<RecipeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RecipeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeData>.NativeClassPtr);
      RecipeData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (Entity));
      RecipeData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (Guid));
      RecipeData.NativeFieldInfoPtr_CraftDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (CraftDuration));
      RecipeData.NativeFieldInfoPtr_HudSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (HudSortingOrder));
      RecipeData.NativeFieldInfoPtr_AlwaysUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (AlwaysUnlocked));
      RecipeData.NativeFieldInfoPtr_HideInStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (HideInStation));
      RecipeData.NativeFieldInfoPtr_IgnoreServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, nameof (IgnoreServerSettings));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
