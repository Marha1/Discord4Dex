using Application.Dtos.Channel;
using Application.Dtos.Guild;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace Application.Interfaces;

public interface IDiscord
{

/// <summary>
/// Интерфейс апи дискорда
/// </summary>


    /// <summary>
    /// Получение всех серверов (гильдий) пользователя
    /// </summary>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Список все серверов (гильдий) пользователя.</returns>
    [Get("/users/@me/guilds")]
    public Task<List<GetAllGuildsResponse>> GetGuildsAsync([Header("Authorization")] string authorization);

    /// <summary>
    /// Получение сервера (гильдии) по идентификатору
    /// </summary>
    /// <param name="guildId">Идентификатор.</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Сервер (гильдия).</returns>
    [Get("/guilds/{guildId}")]
    public Task<GetByIdGuildResponse> GetGuildAsync(string guildId, [Header("Authorization")] string authorization);

    /// <summary>
    /// Создание сервера (гильдии)
    /// </summary>
    /// <param name="guild">Данные сервера (гильдии).</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Созданный сервер (гильдия).</returns>
    [Post("/guilds")]
    public Task<CreateGuildResponse> CreateGuildAsync([FromBody] CreateGuildRequest guild, [Header("Authorization")] string authorization);

    /// <summary>
    /// Обновление сервера (гильдии)
    /// </summary>
    /// <param name="guildId">Идентификатор сервера (гильдии).</param>
    /// <param name="guild">Данные для обновления.</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Обновленный сервер (гильдия).</returns>
    [Patch("/guilds/{guildId}")]
    public Task<UpdateGuildResponse> UpdateGuildAsync(string guildId, [FromBody] UpdateGuildRequest guild, [Header("Authorization")] string authorization);

    /// <summary>
    /// Удаление сервера (гильдии)
    /// </summary>
    /// <param name="guildId">Идентификатор сервера (гильдии).</param>
    /// <param name="authorization">Токен авторизации.</param>
    [Delete("/guilds/{guildId}")]
    public Task DeleteGuildAsync(string guildId, [Header("Authorization")] string authorization);
    
    /// <summary>
    /// Получение всех каналов на сервере (гильдии)
    /// </summary>
    /// <param name="guildId">Идентификатор сервера (гильдии).</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Список всех каналов.</returns>
    [Get("/guilds/{guildId}/channels")]
    public Task<List<GetAllChannelsResponse>> GetChannelsAsync(string guildId, [Header("Authorization")] string authorization);

    /// <summary>
    /// Получение канала по идентификатору
    /// </summary>
    /// <param name="channelId">Идентификатор канала.</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Канал.</returns>
    [Get("/channels/{channelId}")]
    public Task<GetByIdChannelResponse> GetChannelAsync(string channelId, [Header("Authorization")] string authorization);

    /// <summary>
    /// Создание канала
    /// </summary>
    /// <param name="guildId">Идентификатор сервера (гильдии).</param>
    /// <param name="channel">Данные для создания.</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns></returns>
    [Post("/guilds/{guildId}/channels")]
    public Task<CreateChannelResponse> CreateChannelAsync(string guildId, [FromBody] CreateChannelRequest channel, [Header("Authorization")] string authorization);

    /// <summary>
    /// Обновление канала
    /// </summary>
    /// <param name="channelId">Идентификатор канала.</param>
    /// <param name="channel">Данные для обновления.</param>
    /// <param name="authorization">Токен авторизации.</param>
    /// <returns>Обновленный канал.</returns>
    [Patch("/channels/{channelId}")]
    public Task<UpdateChannelResponse> UpdateChannelAsync(string channelId, [FromBody] UpdateChannelRequest channel, [Header("Authorization")] string authorization);

    /// <summary>
    /// Удаление канала
    /// </summary>
    /// <param name="channelId">Идентификатор канала.</param>
    /// <param name="authorization">Токен авторизации.</param>
    [Delete("/channels/{channelId}")]
    public Task DeleteChannelAsync(string channelId, [Header("Authorization")] string authorization);
}

